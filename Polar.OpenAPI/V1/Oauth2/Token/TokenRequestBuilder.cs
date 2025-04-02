// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace ApiSdk.V1.Oauth2.Token
{
    /// <summary>
    /// Builds and executes requests for operations under \v1\oauth2\token
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class TokenRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.V1.Oauth2.Token.TokenRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TokenRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/oauth2/token", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.V1.Oauth2.Token.TokenRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TokenRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/oauth2/token", rawUrl)
        {
        }
        /// <summary>
        /// Request an access token using a valid grant.
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.TokenResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::ApiSdk.Models.TokenResponse?> PostAsync(global::ApiSdk.V1.Oauth2.Token.TokenRequestBuilder.TokenPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::ApiSdk.Models.TokenResponse> PostAsync(global::ApiSdk.V1.Oauth2.Token.TokenRequestBuilder.TokenPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::ApiSdk.Models.TokenResponse>(requestInfo, global::ApiSdk.Models.TokenResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Request an access token using a valid grant.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::ApiSdk.V1.Oauth2.Token.TokenRequestBuilder.TokenPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::ApiSdk.V1.Oauth2.Token.TokenRequestBuilder.TokenPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/x-www-form-urlencoded", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.V1.Oauth2.Token.TokenRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::ApiSdk.V1.Oauth2.Token.TokenRequestBuilder WithUrl(string rawUrl)
        {
            return new global::ApiSdk.V1.Oauth2.Token.TokenRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::ApiSdk.Models.AuthorizationCodeTokenRequest"/>, <see cref="global::ApiSdk.Models.RefreshTokenRequest"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class TokenPostRequestBody : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.AuthorizationCodeTokenRequest"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.AuthorizationCodeTokenRequest? AuthorizationCodeTokenRequest { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.AuthorizationCodeTokenRequest AuthorizationCodeTokenRequest { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.RefreshTokenRequest"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.RefreshTokenRequest? RefreshTokenRequest { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.RefreshTokenRequest RefreshTokenRequest { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::ApiSdk.V1.Oauth2.Token.TokenRequestBuilder.TokenPostRequestBody"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::ApiSdk.V1.Oauth2.Token.TokenRequestBuilder.TokenPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new global::ApiSdk.V1.Oauth2.Token.TokenRequestBuilder.TokenPostRequestBody();
                if("AuthorizationCodeTokenRequest".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.AuthorizationCodeTokenRequest = new global::ApiSdk.Models.AuthorizationCodeTokenRequest();
                }
                else if("RefreshTokenRequest".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.RefreshTokenRequest = new global::ApiSdk.Models.RefreshTokenRequest();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(AuthorizationCodeTokenRequest != null)
                {
                    return AuthorizationCodeTokenRequest.GetFieldDeserializers();
                }
                else if(RefreshTokenRequest != null)
                {
                    return RefreshTokenRequest.GetFieldDeserializers();
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer)
            {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(AuthorizationCodeTokenRequest != null)
                {
                    writer.WriteObjectValue<global::ApiSdk.Models.AuthorizationCodeTokenRequest>(null, AuthorizationCodeTokenRequest);
                }
                else if(RefreshTokenRequest != null)
                {
                    writer.WriteObjectValue<global::ApiSdk.Models.RefreshTokenRequest>(null, RefreshTokenRequest);
                }
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class TokenRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
