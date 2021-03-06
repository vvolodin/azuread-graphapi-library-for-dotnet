﻿// Copyright Â© Microsoft Open Technologies, Inc.
//
// All Rights Reserved
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// THIS CODE IS PROVIDED *AS IS* BASIS, WITHOUT WARRANTIES OR CONDITIONS
// OF ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION
// ANY IMPLIED WARRANTIES OR CONDITIONS OF TITLE, FITNESS FOR A
// PARTICULAR PURPOSE, MERCHANTABILITY OR NON-INFRINGEMENT.
//
// See the Apache License, Version 2.0 for the specific language
// governing permissions and limitations under the License.

namespace Microsoft.Azure.ActiveDirectory.GraphClient
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Web;

    /// <summary>
    /// Simple trace based logger.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Log errors and exceptions.
        /// </summary>
        /// <param name="message">Formatted message.</param>
        /// <param name="args">Message arguments.</param>
        void Error(string message, params object[] args);

        /// <summary>
        /// Log warnings.
        /// </summary>
        /// <param name="message">Formatted message.</param>
        /// <param name="args">Message arguments.</param>
        void Warning(string message, params object[] args);

        /// <summary>
        /// Log information.
        /// </summary>
        /// <param name="message">Formatted message.</param>
        /// <param name="args">Message arguments.</param>
        void Info(string message, params object[] args);
    }
}