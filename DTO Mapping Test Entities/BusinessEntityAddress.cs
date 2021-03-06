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
    [KnownType(typeof(Address))]
    [KnownType(typeof(AddressType))]
    [KnownType(typeof(BusinessEntity))]
    public partial class BusinessEntityAddress
    {
        #region Primitive Properties
        [DataMember]
        public virtual int BusinessEntityID
        {
            get { return _businessEntityID; }
            set
            {
                if (_businessEntityID != value)
                {
                    if (BusinessEntity != null && BusinessEntity.BusinessEntityID != value)
                    {
                        BusinessEntity = null;
                    }
                    _businessEntityID = value;
                }
            }
        }
        private int _businessEntityID;
        [DataMember]
        public virtual int AddressID
        {
            get { return _addressID; }
            set
            {
                if (_addressID != value)
                {
                    if (Address != null && Address.AddressID != value)
                    {
                        Address = null;
                    }
                    _addressID = value;
                }
            }
        }
        private int _addressID;
        [DataMember]
        public virtual int AddressTypeID
        {
            get { return _addressTypeID; }
            set
            {
                if (_addressTypeID != value)
                {
                    if (AddressType != null && AddressType.AddressTypeID != value)
                    {
                        AddressType = null;
                    }
                    _addressTypeID = value;
                }
            }
        }
        private int _addressTypeID;
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
        public virtual Address Address
        {
            get { return _address; }
            set
            {
                if (!ReferenceEquals(_address, value))
                {
                    var previousValue = _address;
                    _address = value;
                    FixupAddress(previousValue);
                }
            }
        }
        private Address _address;
        
    
        [DataMember]
        public virtual AddressType AddressType
        {
            get { return _addressType; }
            set
            {
                if (!ReferenceEquals(_addressType, value))
                {
                    var previousValue = _addressType;
                    _addressType = value;
                    FixupAddressType(previousValue);
                }
            }
        }
        private AddressType _addressType;
        
    
        [DataMember]
        public virtual BusinessEntity BusinessEntity
        {
            get { return _businessEntity; }
            set
            {
                if (!ReferenceEquals(_businessEntity, value))
                {
                    var previousValue = _businessEntity;
                    _businessEntity = value;
                    FixupBusinessEntity(previousValue);
                }
            }
        }
        private BusinessEntity _businessEntity;

        #endregion
        #region Association Fixup
    
        private void FixupAddress(Address previousValue)
        {
            if (previousValue != null && previousValue.BusinessEntityAddresses.Contains(this))
            {
                previousValue.BusinessEntityAddresses.Remove(this);
            }
    
            if (Address != null)
            {
                if (!Address.BusinessEntityAddresses.Contains(this))
                {
                    Address.BusinessEntityAddresses.Add(this);
                }
                if (AddressID != Address.AddressID)
                {
                    AddressID = Address.AddressID;
                }
            }
        }
    
        private void FixupAddressType(AddressType previousValue)
        {
            if (previousValue != null && previousValue.BusinessEntityAddresses.Contains(this))
            {
                previousValue.BusinessEntityAddresses.Remove(this);
            }
    
            if (AddressType != null)
            {
                if (!AddressType.BusinessEntityAddresses.Contains(this))
                {
                    AddressType.BusinessEntityAddresses.Add(this);
                }
                if (AddressTypeID != AddressType.AddressTypeID)
                {
                    AddressTypeID = AddressType.AddressTypeID;
                }
            }
        }
    
        private void FixupBusinessEntity(BusinessEntity previousValue)
        {
            if (previousValue != null && previousValue.BusinessEntityAddresses.Contains(this))
            {
                previousValue.BusinessEntityAddresses.Remove(this);
            }
    
            if (BusinessEntity != null)
            {
                if (!BusinessEntity.BusinessEntityAddresses.Contains(this))
                {
                    BusinessEntity.BusinessEntityAddresses.Add(this);
                }
                if (BusinessEntityID != BusinessEntity.BusinessEntityID)
                {
                    BusinessEntityID = BusinessEntity.BusinessEntityID;
                }
            }
        }

        #endregion
    }
}
