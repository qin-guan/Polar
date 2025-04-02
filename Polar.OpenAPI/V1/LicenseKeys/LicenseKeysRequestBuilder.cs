// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Models;
using ApiSdk.V1.LicenseKeys.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace ApiSdk.V1.LicenseKeys
{
    /// <summary>
    /// Builds and executes requests for operations under \v1\license-keys
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class LicenseKeysRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the ApiSdk.v1.licenseKeys.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="global::ApiSdk.V1.LicenseKeys.Item.LicenseKeysItemRequestBuilder"/></returns>
        public global::ApiSdk.V1.LicenseKeys.Item.LicenseKeysItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new global::ApiSdk.V1.LicenseKeys.Item.LicenseKeysItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.V1.LicenseKeys.LicenseKeysRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public LicenseKeysRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/license-keys{?benefit_id*,limit*,organization_id*,page*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.V1.LicenseKeys.LicenseKeysRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public LicenseKeysRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/license-keys{?benefit_id*,limit*,organization_id*,page*}", rawUrl)
        {
        }
        /// <summary>
        /// Get license keys connected to the given organization &amp; filters.**Scopes**: `license_keys:read` `license_keys:write`
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.ListResource_LicenseKeyRead_"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::ApiSdk.Models.Unauthorized">When receiving a 401 status code</exception>
        /// <exception cref="global::ApiSdk.Models.ResourceNotFound">When receiving a 404 status code</exception>
        /// <exception cref="global::ApiSdk.Models.HTTPValidationError">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::ApiSdk.Models.ListResource_LicenseKeyRead_?> GetAsync(Action<RequestConfiguration<global::ApiSdk.V1.LicenseKeys.LicenseKeysRequestBuilder.LicenseKeysRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::ApiSdk.Models.ListResource_LicenseKeyRead_> GetAsync(Action<RequestConfiguration<global::ApiSdk.V1.LicenseKeys.LicenseKeysRequestBuilder.LicenseKeysRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", global::ApiSdk.Models.Unauthorized.CreateFromDiscriminatorValue },
                { "404", global::ApiSdk.Models.ResourceNotFound.CreateFromDiscriminatorValue },
                { "422", global::ApiSdk.Models.HTTPValidationError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::ApiSdk.Models.ListResource_LicenseKeyRead_>(requestInfo, global::ApiSdk.Models.ListResource_LicenseKeyRead_.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get license keys connected to the given organization &amp; filters.**Scopes**: `license_keys:read` `license_keys:write`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.V1.LicenseKeys.LicenseKeysRequestBuilder.LicenseKeysRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.V1.LicenseKeys.LicenseKeysRequestBuilder.LicenseKeysRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.V1.LicenseKeys.LicenseKeysRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::ApiSdk.V1.LicenseKeys.LicenseKeysRequestBuilder WithUrl(string rawUrl)
        {
            return new global::ApiSdk.V1.LicenseKeys.LicenseKeysRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get license keys connected to the given organization &amp; filters.**Scopes**: `license_keys:read` `license_keys:write`
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class LicenseKeysRequestBuilderGetQueryParameters 
        {
            /// <summary>Filter by benefit ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("benefit_id")]
            public string? BenefitId { get; set; }
#nullable restore
#else
            [QueryParameter("benefit_id")]
            public string BenefitId { get; set; }
#endif
            /// <summary>Size of a page, defaults to 10. Maximum is 100.</summary>
            [QueryParameter("limit")]
            public int? Limit { get; set; }
            /// <summary>Filter by organization ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("organization_id")]
            public string? OrganizationId { get; set; }
#nullable restore
#else
            [QueryParameter("organization_id")]
            public string OrganizationId { get; set; }
#endif
            /// <summary>Page number, defaults to 1.</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class LicenseKeysRequestBuilderGetRequestConfiguration : RequestConfiguration<global::ApiSdk.V1.LicenseKeys.LicenseKeysRequestBuilder.LicenseKeysRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
