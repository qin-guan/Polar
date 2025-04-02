// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class OrganizationCreate : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The avatar_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.OrganizationCreate.OrganizationCreate_avatar_url? AvatarUrl { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.OrganizationCreate.OrganizationCreate_avatar_url AvatarUrl { get; set; }
#endif
        /// <summary>Additional, private, business details Polar needs about active organizations for compliance (KYC).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.OrganizationDetails? Details { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.OrganizationDetails Details { get; set; }
#endif
        /// <summary>Public support email.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.OrganizationCreate.OrganizationCreate_email? Email { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.OrganizationCreate.OrganizationCreate_email Email { get; set; }
#endif
        /// <summary>The feature_settings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.OrganizationFeatureSettings? FeatureSettings { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.OrganizationFeatureSettings FeatureSettings { get; set; }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The slug property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Slug { get; set; }
#nullable restore
#else
        public string Slug { get; set; }
#endif
        /// <summary>Link to social profiles.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.OrganizationSocialLink>? Socials { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.OrganizationSocialLink> Socials { get; set; }
#endif
        /// <summary>The subscription_settings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.OrganizationSubscriptionSettings? SubscriptionSettings { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.OrganizationSubscriptionSettings SubscriptionSettings { get; set; }
#endif
        /// <summary>Official website of the organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.OrganizationCreate.OrganizationCreate_website? Website { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.OrganizationCreate.OrganizationCreate_website Website { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.OrganizationCreate"/> and sets the default values.
        /// </summary>
        public OrganizationCreate()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.OrganizationCreate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.OrganizationCreate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.OrganizationCreate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "avatar_url", n => { AvatarUrl = n.GetObjectValue<global::ApiSdk.Models.OrganizationCreate.OrganizationCreate_avatar_url>(global::ApiSdk.Models.OrganizationCreate.OrganizationCreate_avatar_url.CreateFromDiscriminatorValue); } },
                { "details", n => { Details = n.GetObjectValue<global::ApiSdk.Models.OrganizationDetails>(global::ApiSdk.Models.OrganizationDetails.CreateFromDiscriminatorValue); } },
                { "email", n => { Email = n.GetObjectValue<global::ApiSdk.Models.OrganizationCreate.OrganizationCreate_email>(global::ApiSdk.Models.OrganizationCreate.OrganizationCreate_email.CreateFromDiscriminatorValue); } },
                { "feature_settings", n => { FeatureSettings = n.GetObjectValue<global::ApiSdk.Models.OrganizationFeatureSettings>(global::ApiSdk.Models.OrganizationFeatureSettings.CreateFromDiscriminatorValue); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "slug", n => { Slug = n.GetStringValue(); } },
                { "socials", n => { Socials = n.GetCollectionOfObjectValues<global::ApiSdk.Models.OrganizationSocialLink>(global::ApiSdk.Models.OrganizationSocialLink.CreateFromDiscriminatorValue)?.AsList(); } },
                { "subscription_settings", n => { SubscriptionSettings = n.GetObjectValue<global::ApiSdk.Models.OrganizationSubscriptionSettings>(global::ApiSdk.Models.OrganizationSubscriptionSettings.CreateFromDiscriminatorValue); } },
                { "website", n => { Website = n.GetObjectValue<global::ApiSdk.Models.OrganizationCreate.OrganizationCreate_website>(global::ApiSdk.Models.OrganizationCreate.OrganizationCreate_website.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::ApiSdk.Models.OrganizationCreate.OrganizationCreate_avatar_url>("avatar_url", AvatarUrl);
            writer.WriteObjectValue<global::ApiSdk.Models.OrganizationDetails>("details", Details);
            writer.WriteObjectValue<global::ApiSdk.Models.OrganizationCreate.OrganizationCreate_email>("email", Email);
            writer.WriteObjectValue<global::ApiSdk.Models.OrganizationFeatureSettings>("feature_settings", FeatureSettings);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("slug", Slug);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.OrganizationSocialLink>("socials", Socials);
            writer.WriteObjectValue<global::ApiSdk.Models.OrganizationSubscriptionSettings>("subscription_settings", SubscriptionSettings);
            writer.WriteObjectValue<global::ApiSdk.Models.OrganizationCreate.OrganizationCreate_website>("website", Website);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::ApiSdk.Models.OrganizationCreate_avatar_urlMember1"/>, <see cref="string"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class OrganizationCreate_avatar_url : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.OrganizationCreate_avatar_urlMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.OrganizationCreate_avatar_urlMember1? OrganizationCreateAvatarUrlMember1 { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.OrganizationCreate_avatar_urlMember1 OrganizationCreateAvatarUrlMember1 { get; set; }
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
            /// <returns>A <see cref="global::ApiSdk.Models.OrganizationCreate.OrganizationCreate_avatar_url"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::ApiSdk.Models.OrganizationCreate.OrganizationCreate_avatar_url CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::ApiSdk.Models.OrganizationCreate.OrganizationCreate_avatar_url();
                if(parseNode.GetStringValue() is string stringValue)
                {
                    result.String = stringValue;
                }
                else {
                    result.OrganizationCreateAvatarUrlMember1 = new global::ApiSdk.Models.OrganizationCreate_avatar_urlMember1();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(OrganizationCreateAvatarUrlMember1 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(OrganizationCreateAvatarUrlMember1);
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
                    writer.WriteObjectValue<global::ApiSdk.Models.OrganizationCreate_avatar_urlMember1>(null, OrganizationCreateAvatarUrlMember1);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::ApiSdk.Models.OrganizationCreate_emailMember1"/>, <see cref="string"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class OrganizationCreate_email : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.OrganizationCreate_emailMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.OrganizationCreate_emailMember1? OrganizationCreateEmailMember1 { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.OrganizationCreate_emailMember1 OrganizationCreateEmailMember1 { get; set; }
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
            /// <returns>A <see cref="global::ApiSdk.Models.OrganizationCreate.OrganizationCreate_email"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::ApiSdk.Models.OrganizationCreate.OrganizationCreate_email CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::ApiSdk.Models.OrganizationCreate.OrganizationCreate_email();
                if(parseNode.GetStringValue() is string stringValue)
                {
                    result.String = stringValue;
                }
                else {
                    result.OrganizationCreateEmailMember1 = new global::ApiSdk.Models.OrganizationCreate_emailMember1();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(OrganizationCreateEmailMember1 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(OrganizationCreateEmailMember1);
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
                    writer.WriteObjectValue<global::ApiSdk.Models.OrganizationCreate_emailMember1>(null, OrganizationCreateEmailMember1);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::ApiSdk.Models.OrganizationCreate_websiteMember1"/>, <see cref="string"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class OrganizationCreate_website : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.OrganizationCreate_websiteMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.OrganizationCreate_websiteMember1? OrganizationCreateWebsiteMember1 { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.OrganizationCreate_websiteMember1 OrganizationCreateWebsiteMember1 { get; set; }
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
            /// <returns>A <see cref="global::ApiSdk.Models.OrganizationCreate.OrganizationCreate_website"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::ApiSdk.Models.OrganizationCreate.OrganizationCreate_website CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::ApiSdk.Models.OrganizationCreate.OrganizationCreate_website();
                if(parseNode.GetStringValue() is string stringValue)
                {
                    result.String = stringValue;
                }
                else {
                    result.OrganizationCreateWebsiteMember1 = new global::ApiSdk.Models.OrganizationCreate_websiteMember1();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(OrganizationCreateWebsiteMember1 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(OrganizationCreateWebsiteMember1);
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
                    writer.WriteObjectValue<global::ApiSdk.Models.OrganizationCreate_websiteMember1>(null, OrganizationCreateWebsiteMember1);
                }
            }
        }
    }
}
#pragma warning restore CS0618
