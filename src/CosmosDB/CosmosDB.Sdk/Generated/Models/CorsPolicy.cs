// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The CORS policy for the Cosmos DB database account.
    /// </summary>
    public partial class CorsPolicy
    {
        /// <summary>
        /// Initializes a new instance of the CorsPolicy class.
        /// </summary>
        public CorsPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CorsPolicy class.
        /// </summary>
        /// <param name="allowedOrigins">The origin domains that are permitted
        /// to make a request against the service via CORS.</param>
        /// <param name="allowedMethods">The methods (HTTP request verbs) that
        /// the origin domain may use for a CORS request.</param>
        /// <param name="allowedHeaders">The request headers that the origin
        /// domain may specify on the CORS request.</param>
        /// <param name="exposedHeaders">The response headers that may be sent
        /// in the response to the CORS request and exposed by the browser to
        /// the request issuer.</param>
        /// <param name="maxAgeInSeconds">The maximum amount time that a
        /// browser should cache the preflight OPTIONS request.</param>
        public CorsPolicy(string allowedOrigins, string allowedMethods = default(string), string allowedHeaders = default(string), string exposedHeaders = default(string), long? maxAgeInSeconds = default(long?))
        {
            AllowedOrigins = allowedOrigins;
            AllowedMethods = allowedMethods;
            AllowedHeaders = allowedHeaders;
            ExposedHeaders = exposedHeaders;
            MaxAgeInSeconds = maxAgeInSeconds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the origin domains that are permitted to make a
        /// request against the service via CORS.
        /// </summary>
        [JsonProperty(PropertyName = "allowedOrigins")]
        public string AllowedOrigins { get; set; }

        /// <summary>
        /// Gets or sets the methods (HTTP request verbs) that the origin
        /// domain may use for a CORS request.
        /// </summary>
        [JsonProperty(PropertyName = "allowedMethods")]
        public string AllowedMethods { get; set; }

        /// <summary>
        /// Gets or sets the request headers that the origin domain may specify
        /// on the CORS request.
        /// </summary>
        [JsonProperty(PropertyName = "allowedHeaders")]
        public string AllowedHeaders { get; set; }

        /// <summary>
        /// Gets or sets the response headers that may be sent in the response
        /// to the CORS request and exposed by the browser to the request
        /// issuer.
        /// </summary>
        [JsonProperty(PropertyName = "exposedHeaders")]
        public string ExposedHeaders { get; set; }

        /// <summary>
        /// Gets or sets the maximum amount time that a browser should cache
        /// the preflight OPTIONS request.
        /// </summary>
        [JsonProperty(PropertyName = "maxAgeInSeconds")]
        public long? MaxAgeInSeconds { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AllowedOrigins == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AllowedOrigins");
            }
            if (MaxAgeInSeconds != null)
            {
                if (MaxAgeInSeconds > 2147483647)
                {
                    throw new ValidationException(ValidationRules.InclusiveMaximum, "MaxAgeInSeconds", 2147483647);
                }
                if (MaxAgeInSeconds < 1)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "MaxAgeInSeconds", 1);
                }
            }
        }
    }
}
