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
    /// Schema for a custom field of type select.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CustomFieldSelect : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Creation timestamp of the object.</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The ID of the object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The metadata property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.CustomFieldSelect_metadata? Metadata { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.CustomFieldSelect_metadata Metadata { get; set; }
#endif
        /// <summary>Last modification timestamp of the object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.CustomFieldSelect.CustomFieldSelect_modified_at? ModifiedAt { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.CustomFieldSelect.CustomFieldSelect_modified_at ModifiedAt { get; set; }
#endif
        /// <summary>Name of the custom field.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The ID of the organization owning the custom field.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrganizationId { get; set; }
#nullable restore
#else
        public string OrganizationId { get; set; }
#endif
        /// <summary>The properties property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.CustomFieldSelectProperties? Properties { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.CustomFieldSelectProperties Properties { get; set; }
#endif
        /// <summary>Identifier of the custom field. It&apos;ll be used as key when storing the value.</summary>
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
        /// Instantiates a new <see cref="global::ApiSdk.Models.CustomFieldSelect"/> and sets the default values.
        /// </summary>
        public CustomFieldSelect()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.CustomFieldSelect"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.CustomFieldSelect CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.CustomFieldSelect();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "metadata", n => { Metadata = n.GetObjectValue<global::ApiSdk.Models.CustomFieldSelect_metadata>(global::ApiSdk.Models.CustomFieldSelect_metadata.CreateFromDiscriminatorValue); } },
                { "modified_at", n => { ModifiedAt = n.GetObjectValue<global::ApiSdk.Models.CustomFieldSelect.CustomFieldSelect_modified_at>(global::ApiSdk.Models.CustomFieldSelect.CustomFieldSelect_modified_at.CreateFromDiscriminatorValue); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "organization_id", n => { OrganizationId = n.GetStringValue(); } },
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
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteStringValue("id", Id);
            writer.WriteObjectValue<global::ApiSdk.Models.CustomFieldSelect_metadata>("metadata", Metadata);
            writer.WriteObjectValue<global::ApiSdk.Models.CustomFieldSelect.CustomFieldSelect_modified_at>("modified_at", ModifiedAt);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("organization_id", OrganizationId);
            writer.WriteObjectValue<global::ApiSdk.Models.CustomFieldSelectProperties>("properties", Properties);
            writer.WriteStringValue("slug", Slug);
            writer.WriteStringValue("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="DateTimeOffset"/>, <see cref="global::ApiSdk.Models.CustomFieldSelect_modified_atMember1"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CustomFieldSelect_modified_at : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.CustomFieldSelect_modified_atMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.CustomFieldSelect_modified_atMember1? CustomFieldSelectModifiedAtMember1 { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.CustomFieldSelect_modified_atMember1 CustomFieldSelectModifiedAtMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="DateTimeOffset"/></summary>
            public DateTimeOffset? DateTimeOffset { get; set; }
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::ApiSdk.Models.CustomFieldSelect.CustomFieldSelect_modified_at"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::ApiSdk.Models.CustomFieldSelect.CustomFieldSelect_modified_at CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::ApiSdk.Models.CustomFieldSelect.CustomFieldSelect_modified_at();
                if(parseNode.GetDateTimeOffsetValue() is DateTimeOffset dateTimeOffsetValue)
                {
                    result.DateTimeOffset = dateTimeOffsetValue;
                }
                else {
                    result.CustomFieldSelectModifiedAtMember1 = new global::ApiSdk.Models.CustomFieldSelect_modified_atMember1();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(CustomFieldSelectModifiedAtMember1 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(CustomFieldSelectModifiedAtMember1);
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
                    writer.WriteObjectValue<global::ApiSdk.Models.CustomFieldSelect_modified_atMember1>(null, CustomFieldSelectModifiedAtMember1);
                }
            }
        }
    }
}
#pragma warning restore CS0618
