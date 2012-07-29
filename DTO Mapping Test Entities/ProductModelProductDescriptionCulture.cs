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
    [KnownType(typeof(Culture))]
    [KnownType(typeof(ProductDescription))]
    [KnownType(typeof(ProductModel))]
    public partial class ProductModelProductDescriptionCulture
    {
        #region Primitive Properties
        [DataMember]
        public virtual int ProductModelID
        {
            get { return _productModelID; }
            set
            {
                if (_productModelID != value)
                {
                    if (ProductModel != null && ProductModel.ProductModelID != value)
                    {
                        ProductModel = null;
                    }
                    _productModelID = value;
                }
            }
        }
        private int _productModelID;
        [DataMember]
        public virtual int ProductDescriptionID
        {
            get { return _productDescriptionID; }
            set
            {
                if (_productDescriptionID != value)
                {
                    if (ProductDescription != null && ProductDescription.ProductDescriptionID != value)
                    {
                        ProductDescription = null;
                    }
                    _productDescriptionID = value;
                }
            }
        }
        private int _productDescriptionID;
        [DataMember]
        public virtual string CultureID
        {
            get { return _cultureID; }
            set
            {
                if (_cultureID != value)
                {
                    if (Culture != null && Culture.CultureID != value)
                    {
                        Culture = null;
                    }
                    _cultureID = value;
                }
            }
        }
        private string _cultureID;
        [DataMember]
        public virtual System.DateTime ModifiedDate
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
        
    
        [DataMember]
        public virtual Culture Culture
        {
            get { return _culture; }
            set
            {
                if (!ReferenceEquals(_culture, value))
                {
                    var previousValue = _culture;
                    _culture = value;
                    FixupCulture(previousValue);
                }
            }
        }
        private Culture _culture;
        
    
        [DataMember]
        public virtual ProductDescription ProductDescription
        {
            get { return _productDescription; }
            set
            {
                if (!ReferenceEquals(_productDescription, value))
                {
                    var previousValue = _productDescription;
                    _productDescription = value;
                    FixupProductDescription(previousValue);
                }
            }
        }
        private ProductDescription _productDescription;
        
    
        [DataMember]
        public virtual ProductModel ProductModel
        {
            get { return _productModel; }
            set
            {
                if (!ReferenceEquals(_productModel, value))
                {
                    var previousValue = _productModel;
                    _productModel = value;
                    FixupProductModel(previousValue);
                }
            }
        }
        private ProductModel _productModel;

        #endregion
        #region Association Fixup
    
        private void FixupCulture(Culture previousValue)
        {
            if (previousValue != null && previousValue.ProductModelProductDescriptionCultures.Contains(this))
            {
                previousValue.ProductModelProductDescriptionCultures.Remove(this);
            }
    
            if (Culture != null)
            {
                if (!Culture.ProductModelProductDescriptionCultures.Contains(this))
                {
                    Culture.ProductModelProductDescriptionCultures.Add(this);
                }
                if (CultureID != Culture.CultureID)
                {
                    CultureID = Culture.CultureID;
                }
            }
        }
    
        private void FixupProductDescription(ProductDescription previousValue)
        {
            if (previousValue != null && previousValue.ProductModelProductDescriptionCultures.Contains(this))
            {
                previousValue.ProductModelProductDescriptionCultures.Remove(this);
            }
    
            if (ProductDescription != null)
            {
                if (!ProductDescription.ProductModelProductDescriptionCultures.Contains(this))
                {
                    ProductDescription.ProductModelProductDescriptionCultures.Add(this);
                }
                if (ProductDescriptionID != ProductDescription.ProductDescriptionID)
                {
                    ProductDescriptionID = ProductDescription.ProductDescriptionID;
                }
            }
        }
    
        private void FixupProductModel(ProductModel previousValue)
        {
            if (previousValue != null && previousValue.ProductModelProductDescriptionCultures.Contains(this))
            {
                previousValue.ProductModelProductDescriptionCultures.Remove(this);
            }
    
            if (ProductModel != null)
            {
                if (!ProductModel.ProductModelProductDescriptionCultures.Contains(this))
                {
                    ProductModel.ProductModelProductDescriptionCultures.Add(this);
                }
                if (ProductModelID != ProductModel.ProductModelID)
                {
                    ProductModelID = ProductModel.ProductModelID;
                }
            }
        }

        #endregion
    }
}