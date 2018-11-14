// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type SynchronizationTemplatesCollectionRequestBuilder.
    /// </summary>
    public partial class SynchronizationTemplatesCollectionRequestBuilder : BaseRequestBuilder, ISynchronizationTemplatesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new SynchronizationTemplatesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public SynchronizationTemplatesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ISynchronizationTemplatesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ISynchronizationTemplatesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new SynchronizationTemplatesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ISynchronizationTemplateRequestBuilder"/> for the specified SynchronizationSynchronizationTemplate.
        /// </summary>
        /// <param name="id">The ID for the SynchronizationSynchronizationTemplate.</param>
        /// <returns>The <see cref="ISynchronizationTemplateRequestBuilder"/>.</returns>
        public ISynchronizationTemplateRequestBuilder this[string id]
        {
            get
            {
                return new SynchronizationTemplateRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}