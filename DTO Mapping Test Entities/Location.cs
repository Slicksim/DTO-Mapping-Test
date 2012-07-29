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
    [KnownType(typeof(ProductInventory))]
    [KnownType(typeof(WorkOrderRouting))]
    public partial class Location
    {
        #region Primitive Properties
        [DataMember]
        public virtual short LocationID
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
        public virtual decimal CostRate
        {
            get;
            set;
        }
        [DataMember]
        public virtual decimal Availability
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
        public virtual ICollection<ProductInventory> ProductInventories
        {
            get
            {
                if (_productInventories == null)
                {
                    var newCollection = new FixupCollection<ProductInventory>();
                    newCollection.CollectionChanged += FixupProductInventories;
                    _productInventories = newCollection;
                }
                return _productInventories;
            }
            set
            {
                if (!ReferenceEquals(_productInventories, value))
                {
                    var previousValue = _productInventories as FixupCollection<ProductInventory>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupProductInventories;
                    }
                    _productInventories = value;
                    var newValue = value as FixupCollection<ProductInventory>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupProductInventories;
                    }
                }
            }
        }
        private ICollection<ProductInventory> _productInventories;
        
    
        [DataMember]
        public virtual ICollection<WorkOrderRouting> WorkOrderRoutings
        {
            get
            {
                if (_workOrderRoutings == null)
                {
                    var newCollection = new FixupCollection<WorkOrderRouting>();
                    newCollection.CollectionChanged += FixupWorkOrderRoutings;
                    _workOrderRoutings = newCollection;
                }
                return _workOrderRoutings;
            }
            set
            {
                if (!ReferenceEquals(_workOrderRoutings, value))
                {
                    var previousValue = _workOrderRoutings as FixupCollection<WorkOrderRouting>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupWorkOrderRoutings;
                    }
                    _workOrderRoutings = value;
                    var newValue = value as FixupCollection<WorkOrderRouting>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupWorkOrderRoutings;
                    }
                }
            }
        }
        private ICollection<WorkOrderRouting> _workOrderRoutings;

        #endregion
        #region Association Fixup
    
        private void FixupProductInventories(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (ProductInventory item in e.NewItems)
                {
                    item.Location = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (ProductInventory item in e.OldItems)
                {
                    if (ReferenceEquals(item.Location, this))
                    {
                        item.Location = null;
                    }
                }
            }
        }
    
        private void FixupWorkOrderRoutings(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (WorkOrderRouting item in e.NewItems)
                {
                    item.Location = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (WorkOrderRouting item in e.OldItems)
                {
                    if (ReferenceEquals(item.Location, this))
                    {
                        item.Location = null;
                    }
                }
            }
        }

        #endregion
    }
}