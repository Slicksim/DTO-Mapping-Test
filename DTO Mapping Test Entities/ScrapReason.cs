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
    [KnownType(typeof(WorkOrder))]
    public partial class ScrapReason
    {
        #region Primitive Properties
        [DataMember]
        public virtual short ScrapReasonID
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
        public virtual System.DateTime ModifiedDate
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
        
    
        [DataMember]
        public virtual ICollection<WorkOrder> WorkOrders
        {
            get
            {
                if (_workOrders == null)
                {
                    var newCollection = new FixupCollection<WorkOrder>();
                    newCollection.CollectionChanged += FixupWorkOrders;
                    _workOrders = newCollection;
                }
                return _workOrders;
            }
            set
            {
                if (!ReferenceEquals(_workOrders, value))
                {
                    var previousValue = _workOrders as FixupCollection<WorkOrder>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupWorkOrders;
                    }
                    _workOrders = value;
                    var newValue = value as FixupCollection<WorkOrder>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupWorkOrders;
                    }
                }
            }
        }
        private ICollection<WorkOrder> _workOrders;

        #endregion
        #region Association Fixup
    
        private void FixupWorkOrders(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (WorkOrder item in e.NewItems)
                {
                    item.ScrapReason = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (WorkOrder item in e.OldItems)
                {
                    if (ReferenceEquals(item.ScrapReason, this))
                    {
                        item.ScrapReason = null;
                    }
                }
            }
        }

        #endregion
    }
}
