// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Models;
using ApiSdk.V1.Oauth2.Authorize;
using ApiSdk.V1.Oauth2.Introspect;
using ApiSdk.V1.Oauth2.Register;
using ApiSdk.V1.Oauth2.Revoke;
using ApiSdk.V1.Oauth2.Token;
using ApiSdk.V1.Oauth2.Userinfo;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace ApiSdk.V1.Oauth2
{
    /// <summary>
    /// Builds and executes requests for operations under \v1\oauth2
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Oauth2RequestBuilder : BaseRequestBuilder
    {
        /// <summary>The authorize property</summary>
        public global::ApiSdk.V1.Oauth2.Authorize.AuthorizeRequestBuilder Authorize
        {
            get => new global::ApiSdk.V1.Oauth2.Authorize.AuthorizeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The introspect property</summary>
        public global::ApiSdk.V1.Oauth2.Introspect.IntrospectRequestBuilder Introspect
        {
            get => new global::ApiSdk.V1.Oauth2.Introspect.IntrospectRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The register property</summary>
        public global::ApiSdk.V1.Oauth2.Register.RegisterRequestBuilder Register
        {
            get => new global::ApiSdk.V1.Oauth2.Register.RegisterRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The revoke property</summary>
        public global::ApiSdk.V1.Oauth2.Revoke.RevokeRequestBuilder Revoke
        {
            get => new global::ApiSdk.V1.Oauth2.Revoke.RevokeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The token property</summary>
        public global::ApiSdk.V1.Oauth2.Token.TokenRequestBuilder Token
        {
            get => new global::ApiSdk.V1.Oauth2.Token.TokenRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The userinfo property</summary>
        public global::ApiSdk.V1.Oauth2.Userinfo.UserinfoRequestBuilder Userinfo
        {
            get => new global::ApiSdk.V1.Oauth2.Userinfo.UserinfoRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.V1.Oauth2.Oauth2RequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Oauth2RequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/oauth2", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.V1.Oauth2.Oauth2RequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Oauth2RequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/oauth2", rawUrl)
        {
        }
        /// <summary>
        /// List OAuth2 clients.
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.ListResource_OAuth2Client_"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::ApiSdk.Models.HTTPValidationError">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::ApiSdk.Models.ListResource_OAuth2Client_?> GetAsync(Action<RequestConfiguration<global::ApiSdk.V1.Oauth2.Oauth2RequestBuilder.Oauth2RequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::ApiSdk.Models.ListResource_OAuth2Client_> GetAsync(Action<RequestConfiguration<global::ApiSdk.V1.Oauth2.Oauth2RequestBuilder.Oauth2RequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "422", global::ApiSdk.Models.HTTPValidationError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::ApiSdk.Models.ListResource_OAuth2Client_>(requestInfo, global::ApiSdk.Models.ListResource_OAuth2Client_.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List OAuth2 clients.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.V1.Oauth2.Oauth2RequestBuilder.Oauth2RequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ApiSdk.V1.Oauth2.Oauth2RequestBuilder.Oauth2RequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::ApiSdk.V1.Oauth2.Oauth2RequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::ApiSdk.V1.Oauth2.Oauth2RequestBuilder WithUrl(string rawUrl)
        {
            return new global::ApiSdk.V1.Oauth2.Oauth2RequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// List OAuth2 clients.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Oauth2RequestBuilderGetQueryParameters 
        {
            /// <summary>Size of a page, defaults to 10. Maximum is 100.</summary>
            [QueryParameter("limit")]
            public int? Limit { get; set; }
            /// <summary>Page number, defaults to 1.</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Oauth2RequestBuilderGetRequestConfiguration : RequestConfiguration<global::ApiSdk.V1.Oauth2.Oauth2RequestBuilder.Oauth2RequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
