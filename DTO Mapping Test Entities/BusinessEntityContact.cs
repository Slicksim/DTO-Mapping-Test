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
    [KnownType(typeof(BusinessEntity))]
    [KnownType(typeof(ContactType))]
    [KnownType(typeof(Person))]
    public partial class BusinessEntityContact
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
        public virtual int PersonID
        {
            get { return _personID; }
            set
            {
                if (_personID != value)
                {
                    if (Person != null && Person.BusinessEntityID != value)
                    {
                        Person = null;
                    }
                    _personID = value;
                }
            }
        }
        private int _personID;
        [DataMember]
        public virtual int ContactTypeID
        {
            get { return _contactTypeID; }
            set
            {
                if (_contactTypeID != value)
                {
                    if (ContactType != null && ContactType.ContactTypeID != value)
                    {
                        ContactType = null;
                    }
                    _contactTypeID = value;
                }
            }
        }
        private int _contactTypeID;
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
        
    
        [DataMember]
        public virtual ContactType ContactType
        {
            get { return _contactType; }
            set
            {
                if (!ReferenceEquals(_contactType, value))
                {
                    var previousValue = _contactType;
                    _contactType = value;
                    FixupContactType(previousValue);
                }
            }
        }
        private ContactType _contactType;
        
    
        [DataMember]
        public virtual Person Person
        {
            get { return _person; }
            set
            {
                if (!ReferenceEquals(_person, value))
                {
                    var previousValue = _person;
                    _person = value;
                    FixupPerson(previousValue);
                }
            }
        }
        private Person _person;

        #endregion
        #region Association Fixup
    
        private void FixupBusinessEntity(BusinessEntity previousValue)
        {
            if (previousValue != null && previousValue.BusinessEntityContacts.Contains(this))
            {
                previousValue.BusinessEntityContacts.Remove(this);
            }
    
            if (BusinessEntity != null)
            {
                if (!BusinessEntity.BusinessEntityContacts.Contains(this))
                {
                    BusinessEntity.BusinessEntityContacts.Add(this);
                }
                if (BusinessEntityID != BusinessEntity.BusinessEntityID)
                {
                    BusinessEntityID = BusinessEntity.BusinessEntityID;
                }
            }
        }
    
        private void FixupContactType(ContactType previousValue)
        {
            if (previousValue != null && previousValue.BusinessEntityContacts.Contains(this))
            {
                previousValue.BusinessEntityContacts.Remove(this);
            }
    
            if (ContactType != null)
            {
                if (!ContactType.BusinessEntityContacts.Contains(this))
                {
                    ContactType.BusinessEntityContacts.Add(this);
                }
                if (ContactTypeID != ContactType.ContactTypeID)
                {
                    ContactTypeID = ContactType.ContactTypeID;
                }
            }
        }
    
        private void FixupPerson(Person previousValue)
        {
            if (previousValue != null && previousValue.BusinessEntityContacts.Contains(this))
            {
                previousValue.BusinessEntityContacts.Remove(this);
            }
    
            if (Person != null)
            {
                if (!Person.BusinessEntityContacts.Contains(this))
                {
                    Person.BusinessEntityContacts.Add(this);
                }
                if (PersonID != Person.BusinessEntityID)
                {
                    PersonID = Person.BusinessEntityID;
                }
            }
        }

        #endregion
    }
}