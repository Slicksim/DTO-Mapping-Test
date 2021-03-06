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
    public partial class ShoppingCartItem
    {
        #region Primitive Properties
        [DataMember]
        public virtual int ShoppingCartItemID
        {
            get;
            set;
        }
        [DataMember]
        public virtual string ShoppingCartID
        {
            get;
            set;
        }
        [DataMember]
        public virtual int Quantity
        {
            get;
            set;
        }
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
        public virtual System.DateTime DateCreated
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
            if (previousValue != null && previousValue.ShoppingCartItems.Contains(this))
            {
                previousValue.ShoppingCartItems.Remove(this);
            }
    
            if (Product != null)
            {
                if (!Product.ShoppingCartItems.Contains(this))
                {
                    Product.ShoppingCartItems.Add(this);
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
