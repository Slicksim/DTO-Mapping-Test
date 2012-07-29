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
    [KnownType(typeof(StateProvince))]
    public partial class SalesTaxRate
    {
        #region Primitive Properties
        [DataMember]
        public virtual int SalesTaxRateID
        {
            get;
            set;
        }
        [DataMember]
        public virtual int StateProvinceID
        {
            get { return _stateProvinceID; }
            set
            {
                if (_stateProvinceID != value)
                {
                    if (StateProvince != null && StateProvince.StateProvinceID != value)
                    {
                        StateProvince = null;
                    }
                    _stateProvinceID = value;
                }
            }
        }
        private int _stateProvinceID;
        [DataMember]
        public virtual byte TaxType
        {
            get;
            set;
        }
        [DataMember]
        public virtual decimal TaxRate
        {
            get;
            set;
        }
        [DataMember]
        public virtual string Name
        {
            get;
            set;
        }
        [DataMember]
        public virtual System.Guid rowguid
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
        public virtual StateProvince StateProvince
        {
            get { return _stateProvince; }
            set
            {
                if (!ReferenceEquals(_stateProvince, value))
                {
                    var previousValue = _stateProvince;
                    _stateProvince = value;
                    FixupStateProvince(previousValue);
                }
            }
        }
        private StateProvince _stateProvince;

        #endregion
        #region Association Fixup
    
        private void FixupStateProvince(StateProvince previousValue)
        {
            if (previousValue != null && previousValue.SalesTaxRates.Contains(this))
            {
                previousValue.SalesTaxRates.Remove(this);
            }
    
            if (StateProvince != null)
            {
                if (!StateProvince.SalesTaxRates.Contains(this))
                {
                    StateProvince.SalesTaxRates.Add(this);
                }
                if (StateProvinceID != StateProvince.StateProvinceID)
                {
                    StateProvinceID = StateProvince.StateProvinceID;
                }
            }
        }

        #endregion
    }
}