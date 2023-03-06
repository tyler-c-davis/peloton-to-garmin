#region Copyright
/////////////////////////////////////////////////////////////////////////////////////////////
// Copyright 2023 Garmin International, Inc.
// Licensed under the Flexible and Interoperable Data Transfer (FIT) Protocol License; you
// may not use this file except in compliance with the Flexible and Interoperable Data
// Transfer (FIT) Protocol License.
/////////////////////////////////////////////////////////////////////////////////////////////
// ****WARNING****  This file is auto-generated!  Do NOT edit this file.
// Profile Version = 21.105Release
// Tag = production/release/21.105.00-0-gdc65d24
/////////////////////////////////////////////////////////////////////////////////////////////

#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.IO;
using System.Linq;

namespace Dynastream.Fit
{
    /// <summary>
    /// Implements the WeatherAlert profile message.
    /// </summary>
    public class WeatherAlertMesg : Mesg
    {
        #region Fields
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="WeatherAlertMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte Timestamp = 253;
            public const byte ReportId = 0;
            public const byte IssueTime = 1;
            public const byte ExpireTime = 2;
            public const byte Severity = 3;
            public const byte Type = 4;
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public WeatherAlertMesg() : base(Profile.GetMesg(MesgNum.WeatherAlert))
        {
        }

        public WeatherAlertMesg(Mesg mesg) : base(mesg)
        {
        }
        #endregion // Constructors

        #region Methods
        ///<summary>
        /// Retrieves the Timestamp field</summary>
        /// <returns>Returns DateTime representing the Timestamp field</returns>
        public DateTime GetTimestamp()
        {
            Object val = GetFieldValue(253, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return TimestampToDateTime(Convert.ToUInt32(val));
            
        }

        /// <summary>
        /// Set Timestamp field</summary>
        /// <param name="timestamp_">Nullable field value to be set</param>
        public void SetTimestamp(DateTime timestamp_)
        {
            SetFieldValue(253, 0, timestamp_.GetTimeStamp(), Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the ReportId field
        /// Comment: Unique identifier from GCS report ID string, length is 12</summary>
        /// <returns>Returns byte[] representing the ReportId field</returns>
        public byte[] GetReportId()
        {
            byte[] data = (byte[])GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
            return data.Take(data.Length - 1).ToArray();
        }

        ///<summary>
        /// Retrieves the ReportId field
        /// Comment: Unique identifier from GCS report ID string, length is 12</summary>
        /// <returns>Returns String representing the ReportId field</returns>
        public String GetReportIdAsString()
        {
            byte[] data = (byte[])GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
            return data != null ? Encoding.UTF8.GetString(data, 0, data.Length - 1) : null;
        }

        ///<summary>
        /// Set ReportId field
        /// Comment: Unique identifier from GCS report ID string, length is 12</summary>
        /// <param name="reportId_"> field value to be set</param>
        public void SetReportId(String reportId_)
        {
            byte[] data = Encoding.UTF8.GetBytes(reportId_);
            byte[] zdata = new byte[data.Length + 1];
            data.CopyTo(zdata, 0);
            SetFieldValue(0, 0, zdata, Fit.SubfieldIndexMainField);
        }

        
        /// <summary>
        /// Set ReportId field
        /// Comment: Unique identifier from GCS report ID string, length is 12</summary>
        /// <param name="reportId_">field value to be set</param>
        public void SetReportId(byte[] reportId_)
        {
            SetFieldValue(0, 0, reportId_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the IssueTime field
        /// Comment: Time alert was issued</summary>
        /// <returns>Returns DateTime representing the IssueTime field</returns>
        public DateTime GetIssueTime()
        {
            Object val = GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return TimestampToDateTime(Convert.ToUInt32(val));
            
        }

        /// <summary>
        /// Set IssueTime field
        /// Comment: Time alert was issued</summary>
        /// <param name="issueTime_">Nullable field value to be set</param>
        public void SetIssueTime(DateTime issueTime_)
        {
            SetFieldValue(1, 0, issueTime_.GetTimeStamp(), Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the ExpireTime field
        /// Comment: Time alert expires</summary>
        /// <returns>Returns DateTime representing the ExpireTime field</returns>
        public DateTime GetExpireTime()
        {
            Object val = GetFieldValue(2, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return TimestampToDateTime(Convert.ToUInt32(val));
            
        }

        /// <summary>
        /// Set ExpireTime field
        /// Comment: Time alert expires</summary>
        /// <param name="expireTime_">Nullable field value to be set</param>
        public void SetExpireTime(DateTime expireTime_)
        {
            SetFieldValue(2, 0, expireTime_.GetTimeStamp(), Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Severity field
        /// Comment: Warning, Watch, Advisory, Statement</summary>
        /// <returns>Returns nullable WeatherSeverity enum representing the Severity field</returns>
        public WeatherSeverity? GetSeverity()
        {
            object obj = GetFieldValue(3, 0, Fit.SubfieldIndexMainField);
            WeatherSeverity? value = obj == null ? (WeatherSeverity?)null : (WeatherSeverity)obj;
            return value;
        }

        /// <summary>
        /// Set Severity field
        /// Comment: Warning, Watch, Advisory, Statement</summary>
        /// <param name="severity_">Nullable field value to be set</param>
        public void SetSeverity(WeatherSeverity? severity_)
        {
            SetFieldValue(3, 0, severity_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Type field
        /// Comment: Tornado, Severe Thunderstorm, etc.</summary>
        /// <returns>Returns nullable WeatherSevereType enum representing the Type field</returns>
        new public WeatherSevereType? GetType()
        {
            object obj = GetFieldValue(4, 0, Fit.SubfieldIndexMainField);
            WeatherSevereType? value = obj == null ? (WeatherSevereType?)null : (WeatherSevereType)obj;
            return value;
        }

        /// <summary>
        /// Set Type field
        /// Comment: Tornado, Severe Thunderstorm, etc.</summary>
        /// <param name="type_">Nullable field value to be set</param>
        public void SetType(WeatherSevereType? type_)
        {
            SetFieldValue(4, 0, type_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace
