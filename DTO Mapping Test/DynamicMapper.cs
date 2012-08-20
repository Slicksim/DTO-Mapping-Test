using System;
using System.Collections.Generic;

namespace DTO_Mapping_Test
{
    public static class DynamicMapper
    {
        private static readonly Dictionary<string, Func<object,string,  object>> Maps = new Dictionary<string, Func<object, string, object>>();
        public static void AddMap<TDest>(Func<object, string, object> expression)
        {
            var key = typeof(TDest).Name;

            if (Maps.ContainsKey(key))
                Maps[key] = expression;
            else
                Maps.Add(key, expression);
        }

        public static TDest GetDynamicMap<TDest>(object x, string baseProperty)
        {
            var key = typeof(TDest).Name;

            if(!Maps.ContainsKey(key))
                throw new KeyNotFoundException();

            var result = Maps[key].Invoke(x, baseProperty);

            return (TDest) result;
        }
    }
}