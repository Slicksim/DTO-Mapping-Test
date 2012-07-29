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
    [KnownType(typeof(Product))]
    public partial class ProductCostHistory
    {
        #region Primitive Properties
        [DataMember]
        public virtual int ProductID
        {
            get { return _productID; }
            set
            {
                if (_productID != value)
                {
                    if (Product != null && Product.ProductID != value)
                    {
                        Product = null;
                    }
                    _productID = value;
                }
            }
        }
        private int _productID;
        [DataMember]
        public virtual System.DateTime StartDate
        {
            get;
            set;
        }
        [DataMember]
        public virtual Nullable<System.DateTime> EndDate
        {
            get;
            set;
        }
        [DataMember]
        public virtual decimal StandardCost
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
        public virtual Product Product
        {
            get { return _product; }
            set
            {
                if (!ReferenceEquals(_product, value))
                {
                    var previousValue = _product;
                    _product = value;
                    FixupProduct(previousValue);
                }
            }
        }
        private Product _product;

        #endregion
        #region Association Fixup
    
        private void FixupProduct(Product previousValue)
        {
            if (previousValue != null && previousValue.ProductCostHistories.Contains(this))
            {
                previousValue.ProductCostHistories.Remove(this);
            }
    
            if (Product != null)
            {
                if (!Product.ProductCostHistories.Contains(this))
                {
                    Product.ProductCostHistories.Add(this);
                }
                if (ProductID != Product.ProductID)
                {
                    ProductID = Product.ProductID;
                }
            }
        }

        #endregion
    }
}
