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
    [KnownType(typeof(PurchaseOrderHeader))]
    public partial class PurchaseOrderDetail
    {
        #region Primitive Properties
        [DataMember]
        public virtual int PurchaseOrderID
        {
            get { return _purchaseOrderID; }
            set
            {
                if (_purchaseOrderID != value)
                {
                    if (PurchaseOrderHeader != null && PurchaseOrderHeader.PurchaseOrderID != value)
                    {
                        PurchaseOrderHeader = null;
                    }
                    _purchaseOrderID = value;
                }
            }
        }
        private int _purchaseOrderID;
        [DataMember]
        public virtual int PurchaseOrderDetailID
        {
            get;
            set;
        }
        [DataMember]
        public virtual System.DateTime DueDate
        {
            get;
            set;
        }
        [DataMember]
        public virtual short OrderQty
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
        public virtual decimal UnitPrice
        {
            get;
            set;
        }
        [DataMember]
        public virtual decimal LineTotal
        {
            get;
            set;
        }
        [DataMember]
        public virtual decimal ReceivedQty
        {
            get;
            set;
        }
        [DataMember]
        public virtual decimal RejectedQty
        {
            get;
            set;
        }
        [DataMember]
        public virtual decimal StockedQty
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
        
    
        [DataMember]
        public virtual PurchaseOrderHeader PurchaseOrderHeader
        {
            get { return _purchaseOrderHeader; }
            set
            {
                if (!ReferenceEquals(_purchaseOrderHeader, value))
                {
                    var previousValue = _purchaseOrderHeader;
                    _purchaseOrderHeader = value;
                    FixupPurchaseOrderHeader(previousValue);
                }
            }
        }
        private PurchaseOrderHeader _purchaseOrderHeader;

        #endregion
        #region Association Fixup
    
        private void FixupProduct(Product previousValue)
        {
            if (previousValue != null && previousValue.PurchaseOrderDetails.Contains(this))
            {
                previousValue.PurchaseOrderDetails.Remove(this);
            }
    
            if (Product != null)
            {
                if (!Product.PurchaseOrderDetails.Contains(this))
                {
                    Product.PurchaseOrderDetails.Add(this);
                }
                if (ProductID != Product.ProductID)
                {
                    ProductID = Product.ProductID;
                }
            }
        }
    
        private void FixupPurchaseOrderHeader(PurchaseOrderHeader previousValue)
        {
            if (previousValue != null && previousValue.PurchaseOrderDetails.Contains(this))
            {
                previousValue.PurchaseOrderDetails.Remove(this);
            }
    
            if (PurchaseOrderHeader != null)
            {
                if (!PurchaseOrderHeader.PurchaseOrderDetails.Contains(this))
                {
                    PurchaseOrderHeader.PurchaseOrderDetails.Add(this);
                }
                if (PurchaseOrderID != PurchaseOrderHeader.PurchaseOrderID)
                {
                    PurchaseOrderID = PurchaseOrderHeader.PurchaseOrderID;
                }
            }
        }

        #endregion
    }
}
