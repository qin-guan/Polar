// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Polar.OpenAPI.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class OAuth2ClientPublic : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The client_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientId { get; set; }
#nullable restore
#else
        public string ClientId { get; set; }
#endif
        /// <summary>The client_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_client_name? ClientName { get; set; }
#nullable restore
#else
        public global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_client_name ClientName { get; set; }
#endif
        /// <summary>The client_uri property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_client_uri? ClientUri { get; set; }
#nullable restore
#else
        public global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_client_uri ClientUri { get; set; }
#endif
        /// <summary>Creation timestamp of the object.</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The logo_uri property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_logo_uri? LogoUri { get; set; }
#nullable restore
#else
        public global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_logo_uri LogoUri { get; set; }
#endif
        /// <summary>Last modification timestamp of the object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_modified_at? ModifiedAt { get; set; }
#nullable restore
#else
        public global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_modified_at ModifiedAt { get; set; }
#endif
        /// <summary>The policy_uri property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_policy_uri? PolicyUri { get; set; }
#nullable restore
#else
        public global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_policy_uri PolicyUri { get; set; }
#endif
        /// <summary>The tos_uri property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_tos_uri? TosUri { get; set; }
#nullable restore
#else
        public global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_tos_uri TosUri { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Polar.OpenAPI.Models.OAuth2ClientPublic"/> and sets the default values.
        /// </summary>
        public OAuth2ClientPublic()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Polar.OpenAPI.Models.OAuth2ClientPublic"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Polar.OpenAPI.Models.OAuth2ClientPublic CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Polar.OpenAPI.Models.OAuth2ClientPublic();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "client_id", n => { ClientId = n.GetStringValue(); } },
                { "client_name", n => { ClientName = n.GetObjectValue<global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_client_name>(global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_client_name.CreateFromDiscriminatorValue); } },
                { "client_uri", n => { ClientUri = n.GetObjectValue<global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_client_uri>(global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_client_uri.CreateFromDiscriminatorValue); } },
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "logo_uri", n => { LogoUri = n.GetObjectValue<global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_logo_uri>(global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_logo_uri.CreateFromDiscriminatorValue); } },
                { "modified_at", n => { ModifiedAt = n.GetObjectValue<global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_modified_at>(global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_modified_at.CreateFromDiscriminatorValue); } },
                { "policy_uri", n => { PolicyUri = n.GetObjectValue<global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_policy_uri>(global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_policy_uri.CreateFromDiscriminatorValue); } },
                { "tos_uri", n => { TosUri = n.GetObjectValue<global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_tos_uri>(global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_tos_uri.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("client_id", ClientId);
            writer.WriteObjectValue<global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_client_name>("client_name", ClientName);
            writer.WriteObjectValue<global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_client_uri>("client_uri", ClientUri);
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteObjectValue<global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_logo_uri>("logo_uri", LogoUri);
            writer.WriteObjectValue<global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_modified_at>("modified_at", ModifiedAt);
            writer.WriteObjectValue<global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_policy_uri>("policy_uri", PolicyUri);
            writer.WriteObjectValue<global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_tos_uri>("tos_uri", TosUri);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::Polar.OpenAPI.Models.OAuth2ClientPublic_client_nameMember1"/>, <see cref="string"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class OAuth2ClientPublic_client_name : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::Polar.OpenAPI.Models.OAuth2ClientPublic_client_nameMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Polar.OpenAPI.Models.OAuth2ClientPublic_client_nameMember1? OAuth2ClientPublicClientNameMember1 { get; set; }
#nullable restore
#else
            public global::Polar.OpenAPI.Models.OAuth2ClientPublic_client_nameMember1 OAuth2ClientPublicClientNameMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="string"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? String { get; set; }
#nullable restore
#else
            public string String { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_client_name"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_client_name CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_client_name();
                if(parseNode.GetStringValue() is string stringValue)
                {
                    result.String = stringValue;
                }
                else {
                    result.OAuth2ClientPublicClientNameMember1 = new global::Polar.OpenAPI.Models.OAuth2ClientPublic_client_nameMember1();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(OAuth2ClientPublicClientNameMember1 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(OAuth2ClientPublicClientNameMember1);
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
                if(String != null)
                {
                    writer.WriteStringValue(null, String);
                }
                else {
                    writer.WriteObjectValue<global::Polar.OpenAPI.Models.OAuth2ClientPublic_client_nameMember1>(null, OAuth2ClientPublicClientNameMember1);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::Polar.OpenAPI.Models.OAuth2ClientPublic_client_uriMember1"/>, <see cref="string"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class OAuth2ClientPublic_client_uri : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::Polar.OpenAPI.Models.OAuth2ClientPublic_client_uriMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Polar.OpenAPI.Models.OAuth2ClientPublic_client_uriMember1? OAuth2ClientPublicClientUriMember1 { get; set; }
#nullable restore
#else
            public global::Polar.OpenAPI.Models.OAuth2ClientPublic_client_uriMember1 OAuth2ClientPublicClientUriMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="string"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? String { get; set; }
#nullable restore
#else
            public string String { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_client_uri"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_client_uri CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_client_uri();
                if(parseNode.GetStringValue() is string stringValue)
                {
                    result.String = stringValue;
                }
                else {
                    result.OAuth2ClientPublicClientUriMember1 = new global::Polar.OpenAPI.Models.OAuth2ClientPublic_client_uriMember1();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(OAuth2ClientPublicClientUriMember1 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(OAuth2ClientPublicClientUriMember1);
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
                if(String != null)
                {
                    writer.WriteStringValue(null, String);
                }
                else {
                    writer.WriteObjectValue<global::Polar.OpenAPI.Models.OAuth2ClientPublic_client_uriMember1>(null, OAuth2ClientPublicClientUriMember1);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::Polar.OpenAPI.Models.OAuth2ClientPublic_logo_uriMember1"/>, <see cref="string"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class OAuth2ClientPublic_logo_uri : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::Polar.OpenAPI.Models.OAuth2ClientPublic_logo_uriMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Polar.OpenAPI.Models.OAuth2ClientPublic_logo_uriMember1? OAuth2ClientPublicLogoUriMember1 { get; set; }
#nullable restore
#else
            public global::Polar.OpenAPI.Models.OAuth2ClientPublic_logo_uriMember1 OAuth2ClientPublicLogoUriMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="string"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? String { get; set; }
#nullable restore
#else
            public string String { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_logo_uri"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_logo_uri CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_logo_uri();
                if(parseNode.GetStringValue() is string stringValue)
                {
                    result.String = stringValue;
                }
                else {
                    result.OAuth2ClientPublicLogoUriMember1 = new global::Polar.OpenAPI.Models.OAuth2ClientPublic_logo_uriMember1();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(OAuth2ClientPublicLogoUriMember1 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(OAuth2ClientPublicLogoUriMember1);
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
                if(String != null)
                {
                    writer.WriteStringValue(null, String);
                }
                else {
                    writer.WriteObjectValue<global::Polar.OpenAPI.Models.OAuth2ClientPublic_logo_uriMember1>(null, OAuth2ClientPublicLogoUriMember1);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="DateTimeOffset"/>, <see cref="global::Polar.OpenAPI.Models.OAuth2ClientPublic_modified_atMember1"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class OAuth2ClientPublic_modified_at : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="DateTimeOffset"/></summary>
            public DateTimeOffset? DateTimeOffset { get; set; }
            /// <summary>Composed type representation for type <see cref="global::Polar.OpenAPI.Models.OAuth2ClientPublic_modified_atMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Polar.OpenAPI.Models.OAuth2ClientPublic_modified_atMember1? OAuth2ClientPublicModifiedAtMember1 { get; set; }
#nullable restore
#else
            public global::Polar.OpenAPI.Models.OAuth2ClientPublic_modified_atMember1 OAuth2ClientPublicModifiedAtMember1 { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_modified_at"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_modified_at CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_modified_at();
                if(parseNode.GetDateTimeOffsetValue() is DateTimeOffset dateTimeOffsetValue)
                {
                    result.DateTimeOffset = dateTimeOffsetValue;
                }
                else {
                    result.OAuth2ClientPublicModifiedAtMember1 = new global::Polar.OpenAPI.Models.OAuth2ClientPublic_modified_atMember1();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(OAuth2ClientPublicModifiedAtMember1 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(OAuth2ClientPublicModifiedAtMember1);
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
                if(DateTimeOffset != null)
                {
                    writer.WriteDateTimeOffsetValue(null, DateTimeOffset);
                }
                else {
                    writer.WriteObjectValue<global::Polar.OpenAPI.Models.OAuth2ClientPublic_modified_atMember1>(null, OAuth2ClientPublicModifiedAtMember1);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::Polar.OpenAPI.Models.OAuth2ClientPublic_policy_uriMember1"/>, <see cref="string"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class OAuth2ClientPublic_policy_uri : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::Polar.OpenAPI.Models.OAuth2ClientPublic_policy_uriMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Polar.OpenAPI.Models.OAuth2ClientPublic_policy_uriMember1? OAuth2ClientPublicPolicyUriMember1 { get; set; }
#nullable restore
#else
            public global::Polar.OpenAPI.Models.OAuth2ClientPublic_policy_uriMember1 OAuth2ClientPublicPolicyUriMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="string"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? String { get; set; }
#nullable restore
#else
            public string String { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_policy_uri"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_policy_uri CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_policy_uri();
                if(parseNode.GetStringValue() is string stringValue)
                {
                    result.String = stringValue;
                }
                else {
                    result.OAuth2ClientPublicPolicyUriMember1 = new global::Polar.OpenAPI.Models.OAuth2ClientPublic_policy_uriMember1();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(OAuth2ClientPublicPolicyUriMember1 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(OAuth2ClientPublicPolicyUriMember1);
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
                if(String != null)
                {
                    writer.WriteStringValue(null, String);
                }
                else {
                    writer.WriteObjectValue<global::Polar.OpenAPI.Models.OAuth2ClientPublic_policy_uriMember1>(null, OAuth2ClientPublicPolicyUriMember1);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::Polar.OpenAPI.Models.OAuth2ClientPublic_tos_uriMember1"/>, <see cref="string"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class OAuth2ClientPublic_tos_uri : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::Polar.OpenAPI.Models.OAuth2ClientPublic_tos_uriMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Polar.OpenAPI.Models.OAuth2ClientPublic_tos_uriMember1? OAuth2ClientPublicTosUriMember1 { get; set; }
#nullable restore
#else
            public global::Polar.OpenAPI.Models.OAuth2ClientPublic_tos_uriMember1 OAuth2ClientPublicTosUriMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="string"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? String { get; set; }
#nullable restore
#else
            public string String { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_tos_uri"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_tos_uri CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::Polar.OpenAPI.Models.OAuth2ClientPublic.OAuth2ClientPublic_tos_uri();
                if(parseNode.GetStringValue() is string stringValue)
                {
                    result.String = stringValue;
                }
                else {
                    result.OAuth2ClientPublicTosUriMember1 = new global::Polar.OpenAPI.Models.OAuth2ClientPublic_tos_uriMember1();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(OAuth2ClientPublicTosUriMember1 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(OAuth2ClientPublicTosUriMember1);
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
                if(String != null)
                {
                    writer.WriteStringValue(null, String);
                }
                else {
                    writer.WriteObjectValue<global::Polar.OpenAPI.Models.OAuth2ClientPublic_tos_uriMember1>(null, OAuth2ClientPublicTosUriMember1);
                }
            }
        }
    }
}
#pragma warning restore CS0618
