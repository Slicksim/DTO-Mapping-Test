using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace DTO_Mapping_Test.Utility_Classes
{
    public static class QueryableExtensions
    {
        public static ProjectionExpression<TSource> Project<TSource>(this IQueryable<TSource> source)
        {
            return new ProjectionExpression<TSource>(source);
        }
    }

    public class ProjectionExpression<TSource>
    {
        private static readonly Dictionary<string, Expression> ExpressionCache = new Dictionary<string, Expression>();

        private static readonly List<string> VisitedTypes = new List<string>();

        private readonly IQueryable<TSource> _source;

        public ProjectionExpression(IQueryable<TSource> source)
        {
            _source = source;
        }

        public IQueryable<TDest> To<TDest>()
        {
            var queryExpression = GetCachedExpression<TDest>() ?? BuildExpression<TDest>();

            return _source.Select(queryExpression);
        }

        private static Expression<Func<TSource, TDest>> GetCachedExpression<TDest>()
        {
            var key = GetCacheKey<TDest>();

            return ExpressionCache.ContainsKey(key) ? ExpressionCache[key] as Expression<Func<TSource, TDest>> : null;
        }

        private static Expression<Func<TSource, TDest>> BuildExpression<TDest>()
        {
            var parameterExpression = Expression.Parameter(typeof(TSource), "src");


            //var bindings = destinationProperties
            //                    .Select(destinationProperty => BuildBinding(parameterExpression, destinationProperty, sourceProperties))
            //                    .Where(binding => binding != null);

            VisitedTypes.Add(typeof(TSource).FullName);
            var bindings = BuildBindings(typeof(TSource), typeof(TDest), parameterExpression);

            var expression = Expression.Lambda<Func<TSource, TDest>>(Expression.MemberInit(Expression.New(typeof(TDest)), (List<MemberBinding>)bindings), parameterExpression);

            var key = GetCacheKey<TDest>();

            ExpressionCache.Add(key, expression);

            return expression;
        }

        private static MemberAssignment BuildBinding(Expression parameterExpression, MemberInfo destinationProperty, IEnumerable<PropertyInfo> sourceProperties)
        {
            var sourceProperty = sourceProperties.FirstOrDefault(src => src.Name == destinationProperty.Name);

            if (sourceProperty != null)
            {
                return Expression.Bind(destinationProperty, Expression.Property(parameterExpression, sourceProperty));
            }

            var propertyNames = SplitCamelCase(destinationProperty.Name);

            if (propertyNames.Length == 2)
            {
                sourceProperty = sourceProperties.FirstOrDefault(src => src.Name == propertyNames[0]);

                if (sourceProperty != null)
                {
                    var sourceChildProperty = sourceProperty.PropertyType.GetProperties().FirstOrDefault(src => src.Name == propertyNames[1]);

                    if (sourceChildProperty != null)
                    {
                        return Expression.Bind(destinationProperty, Expression.Property(Expression.Property(parameterExpression, sourceProperty), sourceChildProperty));
                    }
                }
            }

            return null;
        }

        private static IList<MemberBinding> BuildBindings(Type sourceType, Type destType, Expression parameterExpression)
        {
            var bindings = new List<MemberBinding>();


            var sourceProperties = sourceType.GetProperties();
            var destinationProperties = destType.GetProperties().Where(dest => dest.CanWrite);

            foreach (var destinationProperty in destinationProperties)
            {
                var sourceProperty = sourceProperties.FirstOrDefault(sp => sp.Name == destinationProperty.Name);
                if (sourceProperty != null)
                {
                    if (sourceProperty.PropertyType.IsSealed)
                        bindings.Add(Expression.Bind(destinationProperty,
                                                     Expression.Property(parameterExpression, sourceProperty)));
                    else
                    {
                        if (VisitedTypes.Contains(sourceProperty.PropertyType.FullName))
                            continue;

                        // have to exclude lists as they are bound with the include statement
                        if (!sourceProperty.PropertyType.Namespace.Equals("System.Collections.Generic", StringComparison.OrdinalIgnoreCase))
                            bindings.Add(Expression.Bind(destinationProperty,
                                                     Expression.MemberInit(
                                                         Expression.New(destinationProperty.PropertyType),
                                                         BuildBindings(sourceProperty.PropertyType,
                                                                       destinationProperty.PropertyType,
                                                                       Expression.Property(parameterExpression,
                                                                                           sourceProperty)))));
                        else
                        {
                            var type = destinationProperty.PropertyType.GetGenericArguments().First();
                            var newList =
                                Expression.New(
                                    typeof(List<>).MakeGenericType(
                                        destinationProperty.PropertyType.GetGenericArguments().First()));
                            var newItem = Expression.New(type);
                            var addMethod =
                                typeof (List<>).MakeGenericType(type).GetMethod("Add");
                            var elementInit1 = Expression.ElementInit(addMethod, newItem);
                            bindings.Add(Expression.Bind(destinationProperty,
                                                         Expression.ListInit(newList, elementInit1)));
                        }
                    }

                }
            }


            return bindings;
        }


        private static string GetCacheKey<TDest>()
        {
            return string.Concat(typeof(TSource).FullName, typeof(TDest).FullName);
        }

        private static string[] SplitCamelCase(string input)
        {
            return Regex.Replace(input, "([A-Z])", " $1", RegexOptions.Compiled).Trim().Split(' ');
        }
    }
}
