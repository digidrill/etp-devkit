﻿//----------------------------------------------------------------------- 
// ETP DevKit, 1.1
//
// Copyright 2016 Energistics
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//-----------------------------------------------------------------------

using Energistics.Properties;

namespace Energistics.Common
{
    /// <summary>
    /// Defines static fields for the ETP settings.
    /// </summary>
    public static class EtpSettings
    {
        /// <summary>
        /// The default ETP sub protocol name
        /// </summary>
        public static string EtpSubProtocolName = Settings.Default.EtpSubProtocolName;

        /// <summary>
        /// The default ETP encoding header
        /// </summary>
        public static string EtpEncodingHeader = Settings.Default.EtpEncodingHeader;

        /// <summary>
        /// The default ETP version
        /// </summary>
        public static string EtpVersion = Settings.Default.EtpVersion;
    }
}
