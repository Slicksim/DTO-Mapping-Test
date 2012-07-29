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
    [KnownType(typeof(EmployeeDepartmentHistory))]
    public partial class Department
    {
        #region Primitive Properties
        [DataMember]
        public virtual short DepartmentID
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
        public virtual string GroupName
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
        public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories
        {
            get
            {
                if (_employeeDepartmentHistories == null)
                {
                    var newCollection = new FixupCollection<EmployeeDepartmentHistory>();
                    newCollection.CollectionChanged += FixupEmployeeDepartmentHistories;
                    _employeeDepartmentHistories = newCollection;
                }
                return _employeeDepartmentHistories;
            }
            set
            {
                if (!ReferenceEquals(_employeeDepartmentHistories, value))
                {
                    var previousValue = _employeeDepartmentHistories as FixupCollection<EmployeeDepartmentHistory>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupEmployeeDepartmentHistories;
                    }
                    _employeeDepartmentHistories = value;
                    var newValue = value as FixupCollection<EmployeeDepartmentHistory>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupEmployeeDepartmentHistories;
                    }
                }
            }
        }
        private ICollection<EmployeeDepartmentHistory> _employeeDepartmentHistories;

        #endregion
        #region Association Fixup
    
        private void FixupEmployeeDepartmentHistories(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (EmployeeDepartmentHistory item in e.NewItems)
                {
                    item.Department = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (EmployeeDepartmentHistory item in e.OldItems)
                {
                    if (ReferenceEquals(item.Department, this))
                    {
                        item.Department = null;
                    }
                }
            }
        }

        #endregion
    }
}
