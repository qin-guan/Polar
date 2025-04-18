// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Polar.OpenAPI.Models;
using Polar.OpenAPI.V1.Events.Ingest;
using Polar.OpenAPI.V1.Events.Item;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Polar.OpenAPI.V1.Events
{
    /// <summary>
    /// Builds and executes requests for operations under \v1\events
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class EventsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The ingest property</summary>
        public global::Polar.OpenAPI.V1.Events.Ingest.IngestRequestBuilder Ingest
        {
            get => new global::Polar.OpenAPI.V1.Events.Ingest.IngestRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Polar.OpenAPI.v1.events.item collection</summary>
        /// <param name="position">The event ID.</param>
        /// <returns>A <see cref="global::Polar.OpenAPI.V1.Events.Item.EventsItemRequestBuilder"/></returns>
        public global::Polar.OpenAPI.V1.Events.Item.EventsItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new global::Polar.OpenAPI.V1.Events.Item.EventsItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Polar.OpenAPI.V1.Events.EventsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EventsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/events", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Polar.OpenAPI.V1.Events.EventsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EventsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/events", rawUrl)
        {
        }
        /// <summary>
        /// List events.**Scopes**: `events:read` `events:write`
        /// </summary>
        /// <returns>A <see cref="global::Polar.OpenAPI.Models.ListResource_Event_"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Polar.OpenAPI.Models.HTTPValidationError">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Polar.OpenAPI.Models.ListResource_Event_?> GetAsync(Action<RequestConfiguration<global::Polar.OpenAPI.V1.Events.EventsRequestBuilder.EventsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Polar.OpenAPI.Models.ListResource_Event_> GetAsync(Action<RequestConfiguration<global::Polar.OpenAPI.V1.Events.EventsRequestBuilder.EventsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "422", global::Polar.OpenAPI.Models.HTTPValidationError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Polar.OpenAPI.Models.ListResource_Event_>(requestInfo, global::Polar.OpenAPI.Models.ListResource_Event_.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List events.**Scopes**: `events:read` `events:write`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Polar.OpenAPI.V1.Events.EventsRequestBuilder.EventsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Polar.OpenAPI.V1.Events.EventsRequestBuilder.EventsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Polar.OpenAPI.V1.Events.EventsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Polar.OpenAPI.V1.Events.EventsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Polar.OpenAPI.V1.Events.EventsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// List events.**Scopes**: `events:read` `events:write`
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class EventsRequestBuilderGetQueryParameters 
        {
            /// <summary>Filter by customer ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("customer_id")]
            public string? CustomerId { get; set; }
#nullable restore
#else
            [QueryParameter("customer_id")]
            public string CustomerId { get; set; }
#endif
            /// <summary>Filter events before this timestamp.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("end_timestamp")]
            public string? EndTimestamp { get; set; }
#nullable restore
#else
            [QueryParameter("end_timestamp")]
            public string EndTimestamp { get; set; }
#endif
            /// <summary>Filter by external customer ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("external_customer_id")]
            public string? ExternalCustomerId { get; set; }
#nullable restore
#else
            [QueryParameter("external_customer_id")]
            public string ExternalCustomerId { get; set; }
#endif
            /// <summary>Size of a page, defaults to 10. Maximum is 100.</summary>
            [QueryParameter("limit")]
            public int? Limit { get; set; }
            /// <summary>Filter by metadata key-value pairs. It uses the `deepObject` style, e.g. `?metadata[key]=value`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("metadata")]
            public string? Metadata { get; set; }
#nullable restore
#else
            [QueryParameter("metadata")]
            public string Metadata { get; set; }
#endif
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
            /// <summary>Sorting criterion. Several criteria can be used simultaneously and will be applied in order. Add a minus sign `-` before the criteria name to sort by descending order.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sorting")]
            public string? Sorting { get; set; }
#nullable restore
#else
            [QueryParameter("sorting")]
            public string Sorting { get; set; }
#endif
            /// <summary>Filter by event source.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("source")]
            public string? Source { get; set; }
#nullable restore
#else
            [QueryParameter("source")]
            public string Source { get; set; }
#endif
            /// <summary>Filter events after this timestamp.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("start_timestamp")]
            public string? StartTimestamp { get; set; }
#nullable restore
#else
            [QueryParameter("start_timestamp")]
            public string StartTimestamp { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class EventsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Polar.OpenAPI.V1.Events.EventsRequestBuilder.EventsRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
