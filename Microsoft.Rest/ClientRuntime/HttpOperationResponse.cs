﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Net.Http;

namespace Microsoft.Rest
{
    /// <summary>
    /// Represents the base return type of all ServiceClient REST operations.
    /// </summary>
    public class HttpOperationResponse<T>
    {
        /// <summary>
        /// Gets information about the associated HTTP request.
        /// </summary>
        public HttpRequestMessage Request { get; set; }

        /// <summary>
        /// Gets information about the associated HTTP response.
        /// </summary>
        public HttpResponseMessage Response { get; set; }

        /// <summary>
        /// Gets or sets the response object.
        /// </summary>
        public T Body { get; set; }
    }
}