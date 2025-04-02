// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// Schema to create a custom field of type select.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CustomFieldCreateSelect : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Key-value object allowing you to store additional information.The key must be a string with a maximum length of **40 characters**.The value must be either:* A string with a maximum length of **500 characters*** An integer* A booleanYou can store up to **50 key-value pairs**.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.CustomFieldCreateSelect_metadata? Metadata { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.CustomFieldCreateSelect_metadata Metadata { get; set; }
#endif
        /// <summary>Name of the custom field.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The ID of the organization owning the custom field. **Required unless you use an organization token.**</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.CustomFieldCreateSelect.CustomFieldCreateSelect_organization_id? OrganizationId { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.CustomFieldCreateSelect.CustomFieldCreateSelect_organization_id OrganizationId { get; set; }
#endif
        /// <summary>The properties property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.CustomFieldSelectProperties? Properties { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.CustomFieldSelectProperties Properties { get; set; }
#endif
        /// <summary>Identifier of the custom field. It&apos;ll be used as key when storing the value. Must be unique across the organization.It can only contain ASCII letters, numbers and hyphens.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Slug { get; set; }
#nullable restore
#else
        public string Slug { get; set; }
#endif
        /// <summary>The type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.CustomFieldCreateSelect"/> and sets the default values.
        /// </summary>
        public CustomFieldCreateSelect()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.CustomFieldCreateSelect"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.CustomFieldCreateSelect CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.CustomFieldCreateSelect();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "metadata", n => { Metadata = n.GetObjectValue<global::ApiSdk.Models.CustomFieldCreateSelect_metadata>(global::ApiSdk.Models.CustomFieldCreateSelect_metadata.CreateFromDiscriminatorValue); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "organization_id", n => { OrganizationId = n.GetObjectValue<global::ApiSdk.Models.CustomFieldCreateSelect.CustomFieldCreateSelect_organization_id>(global::ApiSdk.Models.CustomFieldCreateSelect.CustomFieldCreateSelect_organization_id.CreateFromDiscriminatorValue); } },
                { "properties", n => { Properties = n.GetObjectValue<global::ApiSdk.Models.CustomFieldSelectProperties>(global::ApiSdk.Models.CustomFieldSelectProperties.CreateFromDiscriminatorValue); } },
                { "slug", n => { Slug = n.GetStringValue(); } },
                { "type", n => { Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::ApiSdk.Models.CustomFieldCreateSelect_metadata>("metadata", Metadata);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<global::ApiSdk.Models.CustomFieldCreateSelect.CustomFieldCreateSelect_organization_id>("organization_id", OrganizationId);
            writer.WriteObjectValue<global::ApiSdk.Models.CustomFieldSelectProperties>("properties", Properties);
            writer.WriteStringValue("slug", Slug);
            writer.WriteStringValue("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::ApiSdk.Models.CustomFieldCreateSelect_organization_idMember1"/>, <see cref="string"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CustomFieldCreateSelect_organization_id : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.CustomFieldCreateSelect_organization_idMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.CustomFieldCreateSelect_organization_idMember1? CustomFieldCreateSelectOrganizationIdMember1 { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.CustomFieldCreateSelect_organization_idMember1 CustomFieldCreateSelectOrganizationIdMember1 { get; set; }
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
            /// <returns>A <see cref="global::ApiSdk.Models.CustomFieldCreateSelect.CustomFieldCreateSelect_organization_id"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::ApiSdk.Models.CustomFieldCreateSelect.CustomFieldCreateSelect_organization_id CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::ApiSdk.Models.CustomFieldCreateSelect.CustomFieldCreateSelect_organization_id();
                if(parseNode.GetStringValue() is string stringValue)
                {
                    result.String = stringValue;
                }
                else {
                    result.CustomFieldCreateSelectOrganizationIdMember1 = new global::ApiSdk.Models.CustomFieldCreateSelect_organization_idMember1();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(CustomFieldCreateSelectOrganizationIdMember1 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(CustomFieldCreateSelectOrganizationIdMember1);
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
                    writer.WriteObjectValue<global::ApiSdk.Models.CustomFieldCreateSelect_organization_idMember1>(null, CustomFieldCreateSelectOrganizationIdMember1);
                }
            }
        }
    }
}
#pragma warning restore CS0618
