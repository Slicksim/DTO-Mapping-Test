//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.Serialization;

namespace DTO_Mapping_Test_Entities
{
    [DataContract(IsReference = true)]
    [KnownType(typeof(Currency))]
    [KnownType(typeof(SalesOrderHeader))]
    public partial class CurrencyRate
    {
        #region Primitive Properties
        [DataMember]
        public virtual int CurrencyRateID
        {
            get;
            set;
        }
        [DataMember]
        public virtual System.DateTime CurrencyRateDate
        {
            get;
            set;
        }
        [DataMember]
        public virtual string FromCurrencyCode
        {
            get { return _fromCurrencyCode; }
            set
            {
                if (_fromCurrencyCode != value)
                {
                    if (Currency != null && Currency.CurrencyCode != value)
                    {
                        Currency = null;
                    }
                    _fromCurrencyCode = value;
                }
            }
        }
        private string _fromCurrencyCode;
        [DataMember]
        public virtual string ToCurrencyCode
        {
            get { return _toCurrencyCode; }
            set
            {
                if (_toCurrencyCode != value)
                {
                    if (Currency1 != null && Currency1.CurrencyCode != value)
                    {
                        Currency1 = null;
                    }
                    _toCurrencyCode = value;
                }
            }
        }
        private string _toCurrencyCode;
        [DataMember]
        public virtual decimal AverageRate
        {
            get;
            set;
        }
        [DataMember]
        public virtual decimal EndOfDayRate
        {
            get;
            set;
        }
        [DataMember]
        public virtual System.DateTime ModifiedDate
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
        
    
        [DataMember]
        public virtual Currency Currency
        {
            get { return _currency; }
            set
            {
                if (!ReferenceEquals(_currency, value))
                {
                    var previousValue = _currency;
                    _currency = value;
                    FixupCurrency(previousValue);
                }
            }
        }
        private Currency _currency;
        
    
        [DataMember]
        public virtual Currency Currency1
        {
            get { return _currency1; }
            set
            {
                if (!ReferenceEquals(_currency1, value))
                {
                    var previousValue = _currency1;
                    _currency1 = value;
                    FixupCurrency1(previousValue);
                }
            }
        }
        private Currency _currency1;
        
    
        [DataMember]
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders
        {
            get
            {
                if (_salesOrderHeaders == null)
                {
                    var newCollection = new FixupCollection<SalesOrderHeader>();
                    newCollection.CollectionChanged += FixupSalesOrderHeaders;
                    _salesOrderHeaders = newCollection;
                }
                return _salesOrderHeaders;
            }
            set
            {
                if (!ReferenceEquals(_salesOrderHeaders, value))
                {
                    var previousValue = _salesOrderHeaders as FixupCollection<SalesOrderHeader>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupSalesOrderHeaders;
                    }
                    _salesOrderHeaders = value;
                    var newValue = value as FixupCollection<SalesOrderHeader>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupSalesOrderHeaders;
                    }
                }
            }
        }
        private ICollection<SalesOrderHeader> _salesOrderHeaders;

        #endregion
        #region Association Fixup
    
        private void FixupCurrency(Currency previousValue)
        {
            if (previousValue != null && previousValue.CurrencyRates.Contains(this))
            {
                previousValue.CurrencyRates.Remove(this);
            }
    
            if (Currency != null)
            {
                if (!Currency.CurrencyRates.Contains(this))
                {
                    Currency.CurrencyRates.Add(this);
                }
                if (FromCurrencyCode != Currency.CurrencyCode)
                {
                    FromCurrencyCode = Currency.CurrencyCode;
                }
            }
        }
    
        private void FixupCurrency1(Currency previousValue)
        {
            if (previousValue != null && previousValue.CurrencyRates1.Contains(this))
            {
                previousValue.CurrencyRates1.Remove(this);
            }
    
            if (Currency1 != null)
            {
                if (!Currency1.CurrencyRates1.Contains(this))
                {
                    Currency1.CurrencyRates1.Add(this);
                }
                if (ToCurrencyCode != Currency1.CurrencyCode)
                {
                    ToCurrencyCode = Currency1.CurrencyCode;
                }
            }
        }
    
        private void FixupSalesOrderHeaders(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (SalesOrderHeader item in e.NewItems)
                {
                    item.CurrencyRate = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (SalesOrderHeader item in e.OldItems)
                {
                    if (ReferenceEquals(item.CurrencyRate, this))
                    {
                        item.CurrencyRate = null;
                    }
                }
            }
        }

        #endregion
    }
}
