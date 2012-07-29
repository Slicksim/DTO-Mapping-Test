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
    [KnownType(typeof(SalesReason))]
    public partial class SalesOrderHeaderSalesReason
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
        public virtual int SalesReasonID
        {
            get { return _salesReasonID; }
            set
            {
                if (_salesReasonID != value)
                {
                    if (SalesReason != null && SalesReason.SalesReasonID != value)
                    {
                        SalesReason = null;
                    }
                    _salesReasonID = value;
                }
            }
        }
        private int _salesReasonID;
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
        public virtual SalesReason SalesReason
        {
            get { return _salesReason; }
            set
            {
                if (!ReferenceEquals(_salesReason, value))
                {
                    var previousValue = _salesReason;
                    _salesReason = value;
                    FixupSalesReason(previousValue);
                }
            }
        }
        private SalesReason _salesReason;

        #endregion
        #region Association Fixup
    
        private void FixupSalesOrderHeader(SalesOrderHeader previousValue)
        {
            if (previousValue != null && previousValue.SalesOrderHeaderSalesReasons.Contains(this))
            {
                previousValue.SalesOrderHeaderSalesReasons.Remove(this);
            }
    
            if (SalesOrderHeader != null)
            {
                if (!SalesOrderHeader.SalesOrderHeaderSalesReasons.Contains(this))
                {
                    SalesOrderHeader.SalesOrderHeaderSalesReasons.Add(this);
                }
                if (SalesOrderID != SalesOrderHeader.SalesOrderID)
                {
                    SalesOrderID = SalesOrderHeader.SalesOrderID;
                }
            }
        }
    
        private void FixupSalesReason(SalesReason previousValue)
        {
            if (previousValue != null && previousValue.SalesOrderHeaderSalesReasons.Contains(this))
            {
                previousValue.SalesOrderHeaderSalesReasons.Remove(this);
            }
    
            if (SalesReason != null)
            {
                if (!SalesReason.SalesOrderHeaderSalesReasons.Contains(this))
                {
                    SalesReason.SalesOrderHeaderSalesReasons.Add(this);
                }
                if (SalesReasonID != SalesReason.SalesReasonID)
                {
                    SalesReasonID = SalesReason.SalesReasonID;
                }
            }
        }

        #endregion
    }
}
