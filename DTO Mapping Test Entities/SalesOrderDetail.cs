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
    [KnownType(typeof(SalesOrderHeader))]
    [KnownType(typeof(SpecialOfferProduct))]
    public partial class SalesOrderDetail
    {
        #region Primitive Properties
        [DataMember]
        public virtual int SalesOrderID
        {
            get { return _salesOrderID; }
            set
            {
                if (_salesOrderID != value)
                {
                    if (SalesOrderHeader != null && SalesOrderHeader.SalesOrderID != value)
                    {
                        SalesOrderHeader = null;
                    }
                    _salesOrderID = value;
                }
            }
        }
        private int _salesOrderID;
        [DataMember]
        public virtual int SalesOrderDetailID
        {
            get;
            set;
        }
        [DataMember]
        public virtual string CarrierTrackingNumber
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
                    if (SpecialOfferProduct != null && SpecialOfferProduct.ProductID != value)
                    {
                        SpecialOfferProduct = null;
                    }
                    _productID = value;
                }
            }
        }
        private int _productID;
        [DataMember]
        public virtual int SpecialOfferID
        {
            get { return _specialOfferID; }
            set
            {
                if (_specialOfferID != value)
                {
                    if (SpecialOfferProduct != null && SpecialOfferProduct.SpecialOfferID != value)
                    {
                        SpecialOfferProduct = null;
                    }
                    _specialOfferID = value;
                }
            }
        }
        private int _specialOfferID;
        [DataMember]
        public virtual decimal UnitPrice
        {
            get;
            set;
        }
        [DataMember]
        public virtual decimal UnitPriceDiscount
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
        public virtual SalesOrderHeader SalesOrderHeader
        {
            get { return _salesOrderHeader; }
            set
            {
                if (!ReferenceEquals(_salesOrderHeader, value))
                {
                    var previousValue = _salesOrderHeader;
                    _salesOrderHeader = value;
                    FixupSalesOrderHeader(previousValue);
                }
            }
        }
        private SalesOrderHeader _salesOrderHeader;
        
    
        [DataMember]
        public virtual SpecialOfferProduct SpecialOfferProduct
        {
            get { return _specialOfferProduct; }
            set
            {
                if (!ReferenceEquals(_specialOfferProduct, value))
                {
                    var previousValue = _specialOfferProduct;
                    _specialOfferProduct = value;
                    FixupSpecialOfferProduct(previousValue);
                }
            }
        }
        private SpecialOfferProduct _specialOfferProduct;

        #endregion
        #region Association Fixup
    
        private void FixupSalesOrderHeader(SalesOrderHeader previousValue)
        {
            if (previousValue != null && previousValue.SalesOrderDetails.Contains(this))
            {
                previousValue.SalesOrderDetails.Remove(this);
            }
    
            if (SalesOrderHeader != null)
            {
                if (!SalesOrderHeader.SalesOrderDetails.Contains(this))
                {
                    SalesOrderHeader.SalesOrderDetails.Add(this);
                }
                if (SalesOrderID != SalesOrderHeader.SalesOrderID)
                {
                    SalesOrderID = SalesOrderHeader.SalesOrderID;
                }
            }
        }
    
        private void FixupSpecialOfferProduct(SpecialOfferProduct previousValue)
        {
            if (previousValue != null && previousValue.SalesOrderDetails.Contains(this))
            {
                previousValue.SalesOrderDetails.Remove(this);
            }
    
            if (SpecialOfferProduct != null)
            {
                if (!SpecialOfferProduct.SalesOrderDetails.Contains(this))
                {
                    SpecialOfferProduct.SalesOrderDetails.Add(this);
                }
                if (SpecialOfferID != SpecialOfferProduct.SpecialOfferID)
                {
                    SpecialOfferID = SpecialOfferProduct.SpecialOfferID;
                }
                if (ProductID != SpecialOfferProduct.ProductID)
                {
                    ProductID = SpecialOfferProduct.ProductID;
                }
            }
        }

        #endregion
    }
}
