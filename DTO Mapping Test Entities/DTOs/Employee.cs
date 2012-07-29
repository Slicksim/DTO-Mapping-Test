using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace DTO_Mapping_Test_Entities.DTOs
{
    [DataContract]
    public class Employee
    {
        [DataMember]
        public virtual string LoginID
        {
            get;
            set;
        }
        [DataMember]
        public virtual Nullable<short> OrganizationLevel
        {
            get;
            set;
        }
        [DataMember]
        public virtual string JobTitle
        {
            get;
            set;
        }
        [DataMember]
        public virtual System.DateTime BirthDate
        {
            get;
            set;
        }

        [DataMember]
        public virtual Person Person { get; set; }
    }
}
