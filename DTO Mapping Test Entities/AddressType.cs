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
    [KnownType(typeof(BusinessEntityAddress))]
    public partial class AddressType
    {
        #region Primitive Properties
        [DataMember]
        public virtual int AddressTypeID
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
        public virtual ICollection<BusinessEntityAddress> BusinessEntityAddresses
        {
            get
            {
                if (_businessEntityAddresses == null)
                {
                    var newCollection = new FixupCollection<BusinessEntityAddress>();
                    newCollection.CollectionChanged += FixupBusinessEntityAddresses;
                    _businessEntityAddresses = newCollection;
                }
                return _businessEntityAddresses;
            }
            set
            {
                if (!ReferenceEquals(_businessEntityAddresses, value))
                {
                    var previousValue = _businessEntityAddresses as FixupCollection<BusinessEntityAddress>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupBusinessEntityAddresses;
                    }
                    _businessEntityAddresses = value;
                    var newValue = value as FixupCollection<BusinessEntityAddress>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupBusinessEntityAddresses;
                    }
                }
            }
        }
        private ICollection<BusinessEntityAddress> _businessEntityAddresses;

        #endregion
        #region Association Fixup
    
        private void FixupBusinessEntityAddresses(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (BusinessEntityAddress item in e.NewItems)
                {
                    item.AddressType = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (BusinessEntityAddress item in e.OldItems)
                {
                    if (ReferenceEquals(item.AddressType, this))
                    {
                        item.AddressType = null;
                    }
                }
            }
        }

        #endregion
    }
}
