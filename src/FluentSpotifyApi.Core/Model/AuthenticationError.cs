﻿using Newtonsoft.Json;

namespace FluentSpotifyApi.Core.Model
{
    /// <summary>
    /// The authentication error.
    /// </summary>
    public class AuthenticationError
    {
        /// <summary>
        /// Gets or sets the error.
        /// </summary>
        /// <value>
        /// The error.
        /// </value>
        [JsonProperty(PropertyName = "error", Required = Required.AllowNull)]
        public string Error { get; set; }

        /// <summary>
        /// Gets or sets the error description.
        /// </summary>
        /// <value>
        /// The error description.
        /// </value>
        [JsonProperty(PropertyName = "error_description", Required = Required.AllowNull)]
        public string ErrorDescription { get; set; }
    }
}
