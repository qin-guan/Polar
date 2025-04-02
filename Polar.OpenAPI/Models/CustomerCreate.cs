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
    public partial class CustomerCreate : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The billing_address property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Address? BillingAddress { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Address BillingAddress { get; set; }
#endif
        /// <summary>The email address of the customer. This must be unique within the organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email { get; set; }
#nullable restore
#else
        public string Email { get; set; }
#endif
        /// <summary>The ID of the customer in your system. This must be unique within the organization. Once set, it can&apos;t be updated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.CustomerCreate.CustomerCreate_external_id? ExternalId { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.CustomerCreate.CustomerCreate_external_id ExternalId { get; set; }
#endif
        /// <summary>Key-value object allowing you to store additional information.The key must be a string with a maximum length of **40 characters**.The value must be either:* A string with a maximum length of **500 characters*** An integer* A booleanYou can store up to **50 key-value pairs**.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.CustomerCreate_metadata? Metadata { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.CustomerCreate_metadata Metadata { get; set; }
#endif
        /// <summary>The name of the customer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.CustomerCreate.CustomerCreate_name? Name { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.CustomerCreate.CustomerCreate_name Name { get; set; }
#endif
        /// <summary>The ID of the organization owning the customer. **Required unless you use an organization token.**</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.CustomerCreate.CustomerCreate_organization_id? OrganizationId { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.CustomerCreate.CustomerCreate_organization_id OrganizationId { get; set; }
#endif
        /// <summary>The tax_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.CustomerCreate.CustomerCreate_tax_id? TaxId { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.CustomerCreate.CustomerCreate_tax_id TaxId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.CustomerCreate"/> and sets the default values.
        /// </summary>
        public CustomerCreate()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.CustomerCreate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.CustomerCreate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.CustomerCreate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "billing_address", n => { BillingAddress = n.GetObjectValue<global::ApiSdk.Models.Address>(global::ApiSdk.Models.Address.CreateFromDiscriminatorValue); } },
                { "email", n => { Email = n.GetStringValue(); } },
                { "external_id", n => { ExternalId = n.GetObjectValue<global::ApiSdk.Models.CustomerCreate.CustomerCreate_external_id>(global::ApiSdk.Models.CustomerCreate.CustomerCreate_external_id.CreateFromDiscriminatorValue); } },
                { "metadata", n => { Metadata = n.GetObjectValue<global::ApiSdk.Models.CustomerCreate_metadata>(global::ApiSdk.Models.CustomerCreate_metadata.CreateFromDiscriminatorValue); } },
                { "name", n => { Name = n.GetObjectValue<global::ApiSdk.Models.CustomerCreate.CustomerCreate_name>(global::ApiSdk.Models.CustomerCreate.CustomerCreate_name.CreateFromDiscriminatorValue); } },
                { "organization_id", n => { OrganizationId = n.GetObjectValue<global::ApiSdk.Models.CustomerCreate.CustomerCreate_organization_id>(global::ApiSdk.Models.CustomerCreate.CustomerCreate_organization_id.CreateFromDiscriminatorValue); } },
                { "tax_id", n => { TaxId = n.GetObjectValue<global::ApiSdk.Models.CustomerCreate.CustomerCreate_tax_id>(global::ApiSdk.Models.CustomerCreate.CustomerCreate_tax_id.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::ApiSdk.Models.Address>("billing_address", BillingAddress);
            writer.WriteStringValue("email", Email);
            writer.WriteObjectValue<global::ApiSdk.Models.CustomerCreate.CustomerCreate_external_id>("external_id", ExternalId);
            writer.WriteObjectValue<global::ApiSdk.Models.CustomerCreate_metadata>("metadata", Metadata);
            writer.WriteObjectValue<global::ApiSdk.Models.CustomerCreate.CustomerCreate_name>("name", Name);
            writer.WriteObjectValue<global::ApiSdk.Models.CustomerCreate.CustomerCreate_organization_id>("organization_id", OrganizationId);
            writer.WriteObjectValue<global::ApiSdk.Models.CustomerCreate.CustomerCreate_tax_id>("tax_id", TaxId);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::ApiSdk.Models.CustomerCreate_external_idMember1"/>, <see cref="string"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CustomerCreate_external_id : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.CustomerCreate_external_idMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.CustomerCreate_external_idMember1? CustomerCreateExternalIdMember1 { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.CustomerCreate_external_idMember1 CustomerCreateExternalIdMember1 { get; set; }
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
            /// <returns>A <see cref="global::ApiSdk.Models.CustomerCreate.CustomerCreate_external_id"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::ApiSdk.Models.CustomerCreate.CustomerCreate_external_id CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::ApiSdk.Models.CustomerCreate.CustomerCreate_external_id();
                if(parseNode.GetStringValue() is string stringValue)
                {
                    result.String = stringValue;
                }
                else {
                    result.CustomerCreateExternalIdMember1 = new global::ApiSdk.Models.CustomerCreate_external_idMember1();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(CustomerCreateExternalIdMember1 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(CustomerCreateExternalIdMember1);
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
                    writer.WriteObjectValue<global::ApiSdk.Models.CustomerCreate_external_idMember1>(null, CustomerCreateExternalIdMember1);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::ApiSdk.Models.CustomerCreate_nameMember1"/>, <see cref="string"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CustomerCreate_name : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.CustomerCreate_nameMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.CustomerCreate_nameMember1? CustomerCreateNameMember1 { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.CustomerCreate_nameMember1 CustomerCreateNameMember1 { get; set; }
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
            /// <returns>A <see cref="global::ApiSdk.Models.CustomerCreate.CustomerCreate_name"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::ApiSdk.Models.CustomerCreate.CustomerCreate_name CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::ApiSdk.Models.CustomerCreate.CustomerCreate_name();
                if(parseNode.GetStringValue() is string stringValue)
                {
                    result.String = stringValue;
                }
                else {
                    result.CustomerCreateNameMember1 = new global::ApiSdk.Models.CustomerCreate_nameMember1();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(CustomerCreateNameMember1 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(CustomerCreateNameMember1);
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
                    writer.WriteObjectValue<global::ApiSdk.Models.CustomerCreate_nameMember1>(null, CustomerCreateNameMember1);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::ApiSdk.Models.CustomerCreate_organization_idMember1"/>, <see cref="string"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CustomerCreate_organization_id : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.CustomerCreate_organization_idMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.CustomerCreate_organization_idMember1? CustomerCreateOrganizationIdMember1 { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.CustomerCreate_organization_idMember1 CustomerCreateOrganizationIdMember1 { get; set; }
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
            /// <returns>A <see cref="global::ApiSdk.Models.CustomerCreate.CustomerCreate_organization_id"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::ApiSdk.Models.CustomerCreate.CustomerCreate_organization_id CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::ApiSdk.Models.CustomerCreate.CustomerCreate_organization_id();
                if(parseNode.GetStringValue() is string stringValue)
                {
                    result.String = stringValue;
                }
                else {
                    result.CustomerCreateOrganizationIdMember1 = new global::ApiSdk.Models.CustomerCreate_organization_idMember1();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(CustomerCreateOrganizationIdMember1 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(CustomerCreateOrganizationIdMember1);
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
                    writer.WriteObjectValue<global::ApiSdk.Models.CustomerCreate_organization_idMember1>(null, CustomerCreateOrganizationIdMember1);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::ApiSdk.Models.CustomerCreate_tax_idMember1"/>, <see cref="global::ApiSdk.Models.CustomerCreate_tax_idMember2"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CustomerCreate_tax_id : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.CustomerCreate_tax_idMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.CustomerCreate_tax_idMember1? CustomerCreateTaxIdMember1 { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.CustomerCreate_tax_idMember1 CustomerCreateTaxIdMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.CustomerCreate_tax_idMember2"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.CustomerCreate_tax_idMember2? CustomerCreateTaxIdMember2 { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.CustomerCreate_tax_idMember2 CustomerCreateTaxIdMember2 { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::ApiSdk.Models.CustomerCreate.CustomerCreate_tax_id"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::ApiSdk.Models.CustomerCreate.CustomerCreate_tax_id CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::ApiSdk.Models.CustomerCreate.CustomerCreate_tax_id();
                result.CustomerCreateTaxIdMember1 = new global::ApiSdk.Models.CustomerCreate_tax_idMember1();
                result.CustomerCreateTaxIdMember2 = new global::ApiSdk.Models.CustomerCreate_tax_idMember2();
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(CustomerCreateTaxIdMember1 != null || CustomerCreateTaxIdMember2 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(CustomerCreateTaxIdMember1, CustomerCreateTaxIdMember2);
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
                writer.WriteObjectValue<global::ApiSdk.Models.CustomerCreate_tax_idMember1>(null, CustomerCreateTaxIdMember1, CustomerCreateTaxIdMember2);
            }
        }
    }
}
#pragma warning restore CS0618
