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
namespace ApiSdk.V1.Oauth2.Userinfo
{
    /// <summary>
    /// Builds and executes requests for operations under \v1\oauth2\userinfo
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class UserinfoRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.V1.Oauth2.Userinfo.UserinfoRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UserinfoRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/oauth2/userinfo", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.V1.Oauth2.Userinfo.UserinfoRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UserinfoRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/oauth2/userinfo", rawUrl)
        {
        }
        /// <summary>
        /// Get information about the authenticated user.
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.V1.Oauth2.Userinfo.UserinfoRequestBuilder.UserinfoGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::ApiSdk.V1.Oauth2.Userinfo.UserinfoRequestBuilder.UserinfoGetResponse?> GetAsUserinfoGetResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::ApiSdk.V1.Oauth2.Userinfo.UserinfoRequestBuilder.UserinfoGetResponse> GetAsUserinfoGetResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::ApiSdk.V1.Oauth2.Userinfo.UserinfoRequestBuilder.UserinfoGetResponse>(requestInfo, global::ApiSdk.V1.Oauth2.Userinfo.UserinfoRequestBuilder.UserinfoGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get information about the authenticated user.
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.V1.Oauth2.Userinfo.UserinfoRequestBuilder.UserinfoResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use GetAsUserinfoGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::ApiSdk.V1.Oauth2.Userinfo.UserinfoRequestBuilder.UserinfoResponse?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::ApiSdk.V1.Oauth2.Userinfo.UserinfoRequestBuilder.UserinfoResponse> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::ApiSdk.V1.Oauth2.Userinfo.UserinfoRequestBuilder.UserinfoResponse>(requestInfo, global::ApiSdk.V1.Oauth2.Userinfo.UserinfoRequestBuilder.UserinfoResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get information about the authenticated user.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::ApiSdk.V1.Oauth2.Userinfo.UserinfoRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::ApiSdk.V1.Oauth2.Userinfo.UserinfoRequestBuilder WithUrl(string rawUrl)
        {
            return new global::ApiSdk.V1.Oauth2.Userinfo.UserinfoRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::ApiSdk.Models.UserInfoOrganization"/>, <see cref="global::ApiSdk.Models.UserInfoUser"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class UserinfoGetResponse : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.UserInfoOrganization"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.UserInfoOrganization? UserInfoOrganization { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.UserInfoOrganization UserInfoOrganization { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.UserInfoUser"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.UserInfoUser? UserInfoUser { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.UserInfoUser UserInfoUser { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::ApiSdk.V1.Oauth2.Userinfo.UserinfoRequestBuilder.UserinfoGetResponse"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::ApiSdk.V1.Oauth2.Userinfo.UserinfoRequestBuilder.UserinfoGetResponse CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::ApiSdk.V1.Oauth2.Userinfo.UserinfoRequestBuilder.UserinfoGetResponse();
                result.UserInfoOrganization = new global::ApiSdk.Models.UserInfoOrganization();
                result.UserInfoUser = new global::ApiSdk.Models.UserInfoUser();
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(UserInfoOrganization != null || UserInfoUser != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(UserInfoOrganization, UserInfoUser);
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
                writer.WriteObjectValue<global::ApiSdk.Models.UserInfoOrganization>(null, UserInfoOrganization, UserInfoUser);
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class UserinfoRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::ApiSdk.Models.UserInfoOrganization"/>, <see cref="global::ApiSdk.Models.UserInfoUser"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class UserinfoResponse : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.UserInfoOrganization"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.UserInfoOrganization? UserInfoOrganization { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.UserInfoOrganization UserInfoOrganization { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.UserInfoUser"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.UserInfoUser? UserInfoUser { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.UserInfoUser UserInfoUser { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::ApiSdk.V1.Oauth2.Userinfo.UserinfoRequestBuilder.UserinfoResponse"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::ApiSdk.V1.Oauth2.Userinfo.UserinfoRequestBuilder.UserinfoResponse CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::ApiSdk.V1.Oauth2.Userinfo.UserinfoRequestBuilder.UserinfoResponse();
                result.UserInfoOrganization = new global::ApiSdk.Models.UserInfoOrganization();
                result.UserInfoUser = new global::ApiSdk.Models.UserInfoUser();
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(UserInfoOrganization != null || UserInfoUser != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(UserInfoOrganization, UserInfoUser);
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
                writer.WriteObjectValue<global::ApiSdk.Models.UserInfoOrganization>(null, UserInfoOrganization, UserInfoUser);
            }
        }
    }
}
#pragma warning restore CS0618
