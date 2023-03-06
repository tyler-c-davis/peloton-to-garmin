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

namespace Dynastream.Fit
{
    /// <summary>
    /// Implements the profile AutoActivityDetect type as a class
    /// </summary>
    public static class AutoActivityDetect 
    {
        public const uint None = 0x00000000;
        public const uint Running = 0x00000001;
        public const uint Cycling = 0x00000002;
        public const uint Swimming = 0x00000004;
        public const uint Walking = 0x00000008;
        public const uint Elliptical = 0x00000020;
        public const uint Sedentary = 0x00000400;
        public const uint Invalid = (uint)0xFFFFFFFF;


    }
}

