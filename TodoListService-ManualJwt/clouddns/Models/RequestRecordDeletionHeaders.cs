﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace TodoListService-ManualJwt.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// Defines headers for requestRecordDeletion operation.
    /// </summary>
    public partial class RequestRecordDeletionHeaders
    {
        /// <summary>
        /// Initializes a new instance of the RequestRecordDeletionHeaders
        /// class.
        /// </summary>
        public RequestRecordDeletionHeaders() { }

        /// <summary>
        /// Initializes a new instance of the RequestRecordDeletionHeaders
        /// class.
        /// </summary>
        public RequestRecordDeletionHeaders(string filter = default(string), string expires = default(string), string lastModified = default(string))
        {
            Filter = filter;
            Expires = expires;
            LastModified = lastModified;
        }

        /// <summary>
        /// filter
        /// </summary>
        [JsonProperty(PropertyName = "filter")]
        public string Filter { get; set; }

        /// <summary>
        /// Expires
        /// </summary>
        [JsonProperty(PropertyName = "Expires")]
        public string Expires { get; set; }

        /// <summary>
        /// Last-Modified
        /// </summary>
        [JsonProperty(PropertyName = "Last-Modified")]
        public string LastModified { get; set; }

    }
}
