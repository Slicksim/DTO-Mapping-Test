using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace DTO_Mapping_Test_Entities.DTOs
{
    [DataContract(IsReference = true)]
    public class Person
    {
        [DataMember]
        public virtual string PersonType
        {
            get;
            set;
        }
        [DataMember]
        public virtual bool NameStyle
        {
            get;
            set;
        }
        [DataMember]
        public virtual string Title
        {
            get;
            set;
        }
        [DataMember]
        public virtual string FirstName
        {
            get;
            set;
        }
        [DataMember]
        public virtual string MiddleName
        {
            get;
            set;
        }
        [DataMember]
        public virtual string LastName
        {
            get;
            set;
        }

        [DataMember]
        public virtual Employee Employee { get; set; }

        [DataMember]
        public virtual IList<BusinessEntityContact> BusinessEntityContacts { get; set; }
    }
}
