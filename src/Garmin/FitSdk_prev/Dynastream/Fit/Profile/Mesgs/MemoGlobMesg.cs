#region Copyright
/////////////////////////////////////////////////////////////////////////////////////////////
// Copyright 2023 Garmin International, Inc.
// Licensed under the Flexible and Interoperable Data Transfer (FIT) Protocol License; you
// may not use this file except in compliance with the Flexible and Interoperable Data
// Transfer (FIT) Protocol License.
/////////////////////////////////////////////////////////////////////////////////////////////
// ****WARNING****  This file is auto-generated!  Do NOT edit this file.
// Profile Version = 21.101Release
// Tag = production/release/21.101.00-0-gceb92d5
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
    /// Implements the MemoGlob profile message.
    /// </summary>
    public class MemoGlobMesg : Mesg
    {
        #region Fields
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="MemoGlobMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte PartIndex = 250;
            public const byte Memo = 0;
            public const byte MesgNum = 1;
            public const byte ParentIndex = 2;
            public const byte FieldNum = 3;
            public const byte Data = 4;
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public MemoGlobMesg() : base(Profile.GetMesg(MesgNum.MemoGlob))
        {
        }

        public MemoGlobMesg(Mesg mesg) : base(mesg)
        {
        }
        #endregion // Constructors

        #region Methods
        ///<summary>
        /// Retrieves the PartIndex field
        /// Comment: Sequence number of memo blocks</summary>
        /// <returns>Returns nullable uint representing the PartIndex field</returns>
        public uint? GetPartIndex()
        {
            Object val = GetFieldValue(250, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt32(val));
            
        }

        /// <summary>
        /// Set PartIndex field
        /// Comment: Sequence number of memo blocks</summary>
        /// <param name="partIndex_">Nullable field value to be set</param>
        public void SetPartIndex(uint? partIndex_)
        {
            SetFieldValue(250, 0, partIndex_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field Memo</returns>
        public int GetNumMemo()
        {
            return GetNumFieldValues(0, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the Memo field
        /// Comment: Deprecated. Use data field.</summary>
        /// <param name="index">0 based index of Memo element to retrieve</param>
        /// <returns>Returns nullable byte representing the Memo field</returns>
        public byte? GetMemo(int index)
        {
            Object val = GetFieldValue(0, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set Memo field
        /// Comment: Deprecated. Use data field.</summary>
        /// <param name="index">0 based index of memo</param>
        /// <param name="memo_">Nullable field value to be set</param>
        public void SetMemo(int index, byte? memo_)
        {
            SetFieldValue(0, index, memo_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the MesgNum field
        /// Comment: Message Number of the parent message</summary>
        /// <returns>Returns nullable ushort representing the MesgNum field</returns>
        public ushort? GetMesgNum()
        {
            Object val = GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set MesgNum field
        /// Comment: Message Number of the parent message</summary>
        /// <param name="mesgNum_">Nullable field value to be set</param>
        public void SetMesgNum(ushort? mesgNum_)
        {
            SetFieldValue(1, 0, mesgNum_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the ParentIndex field
        /// Comment: Index of mesg that this glob is associated with.</summary>
        /// <returns>Returns nullable ushort representing the ParentIndex field</returns>
        public ushort? GetParentIndex()
        {
            Object val = GetFieldValue(2, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set ParentIndex field
        /// Comment: Index of mesg that this glob is associated with.</summary>
        /// <param name="parentIndex_">Nullable field value to be set</param>
        public void SetParentIndex(ushort? parentIndex_)
        {
            SetFieldValue(2, 0, parentIndex_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the FieldNum field
        /// Comment: Field within the parent that this glob is associated with</summary>
        /// <returns>Returns nullable byte representing the FieldNum field</returns>
        public byte? GetFieldNum()
        {
            Object val = GetFieldValue(3, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set FieldNum field
        /// Comment: Field within the parent that this glob is associated with</summary>
        /// <param name="fieldNum_">Nullable field value to be set</param>
        public void SetFieldNum(byte? fieldNum_)
        {
            SetFieldValue(3, 0, fieldNum_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field Data</returns>
        public int GetNumData()
        {
            return GetNumFieldValues(4, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the Data field
        /// Comment: Block of utf8 bytes. Note, mutltibyte characters may be split across adjoining memo_glob messages.</summary>
        /// <param name="index">0 based index of Data element to retrieve</param>
        /// <returns>Returns nullable byte representing the Data field</returns>
        public byte? GetData(int index)
        {
            Object val = GetFieldValue(4, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set Data field
        /// Comment: Block of utf8 bytes. Note, mutltibyte characters may be split across adjoining memo_glob messages.</summary>
        /// <param name="index">0 based index of data</param>
        /// <param name="data_">Nullable field value to be set</param>
        public void SetData(int index, byte? data_)
        {
            SetFieldValue(4, index, data_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace
