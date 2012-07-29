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
    [KnownType(typeof(Person))]
    public partial class EmailAddress
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
                    if (Person != null && Person.BusinessEntityID != value)
                    {
                        Person = null;
                    }
                    _businessEntityID = value;
                }
            }
        }
        private int _businessEntityID;
        [DataMember]
        public virtual int EmailAddressID
        {
            get;
            set;
        }
        [DataMember]
        public virtual string EmailAddress1
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
    
        private void FixupPerson(Person previousValue)
        {
            if (previousValue != null && previousValue.EmailAddresses.Contains(this))
            {
                previousValue.EmailAddresses.Remove(this);
            }
    
            if (Person != null)
            {
                if (!Person.EmailAddresses.Contains(this))
                {
                    Person.EmailAddresses.Add(this);
                }
                if (BusinessEntityID != Person.BusinessEntityID)
                {
                    BusinessEntityID = Person.BusinessEntityID;
                }
            }
        }

        #endregion
    }
}
