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
    public partial class ListResource_FileRead_ : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The items property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ListResource_FileRead_.ListResource_FileRead__items>? Items { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ListResource_FileRead_.ListResource_FileRead__items> Items { get; set; }
#endif
        /// <summary>The pagination property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Pagination? Pagination { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Pagination Pagination { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.ListResource_FileRead_"/> and sets the default values.
        /// </summary>
        public ListResource_FileRead_()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.ListResource_FileRead_"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.ListResource_FileRead_ CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.ListResource_FileRead_();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "items", n => { Items = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ListResource_FileRead_.ListResource_FileRead__items>(global::ApiSdk.Models.ListResource_FileRead_.ListResource_FileRead__items.CreateFromDiscriminatorValue)?.AsList(); } },
                { "pagination", n => { Pagination = n.GetObjectValue<global::ApiSdk.Models.Pagination>(global::ApiSdk.Models.Pagination.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ListResource_FileRead_.ListResource_FileRead__items>("items", Items);
            writer.WriteObjectValue<global::ApiSdk.Models.Pagination>("pagination", Pagination);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::ApiSdk.Models.DownloadableFileRead"/>, <see cref="global::ApiSdk.Models.OrganizationAvatarFileRead"/>, <see cref="global::ApiSdk.Models.ProductMediaFileRead"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ListResource_FileRead__items : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.DownloadableFileRead"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.DownloadableFileRead? DownloadableFileRead { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.DownloadableFileRead DownloadableFileRead { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.OrganizationAvatarFileRead"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.OrganizationAvatarFileRead? OrganizationAvatarFileRead { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.OrganizationAvatarFileRead OrganizationAvatarFileRead { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.ProductMediaFileRead"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.ProductMediaFileRead? ProductMediaFileRead { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.ProductMediaFileRead ProductMediaFileRead { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::ApiSdk.Models.ListResource_FileRead_.ListResource_FileRead__items"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::ApiSdk.Models.ListResource_FileRead_.ListResource_FileRead__items CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("service")?.GetStringValue();
                var result = new global::ApiSdk.Models.ListResource_FileRead_.ListResource_FileRead__items();
                if("downloadable".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.DownloadableFileRead = new global::ApiSdk.Models.DownloadableFileRead();
                }
                else if("organization_avatar".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.OrganizationAvatarFileRead = new global::ApiSdk.Models.OrganizationAvatarFileRead();
                }
                else if("product_media".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.ProductMediaFileRead = new global::ApiSdk.Models.ProductMediaFileRead();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(DownloadableFileRead != null)
                {
                    return DownloadableFileRead.GetFieldDeserializers();
                }
                else if(OrganizationAvatarFileRead != null)
                {
                    return OrganizationAvatarFileRead.GetFieldDeserializers();
                }
                else if(ProductMediaFileRead != null)
                {
                    return ProductMediaFileRead.GetFieldDeserializers();
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
                if(DownloadableFileRead != null)
                {
                    writer.WriteObjectValue<global::ApiSdk.Models.DownloadableFileRead>(null, DownloadableFileRead);
                }
                else if(OrganizationAvatarFileRead != null)
                {
                    writer.WriteObjectValue<global::ApiSdk.Models.OrganizationAvatarFileRead>(null, OrganizationAvatarFileRead);
                }
                else if(ProductMediaFileRead != null)
                {
                    writer.WriteObjectValue<global::ApiSdk.Models.ProductMediaFileRead>(null, ProductMediaFileRead);
                }
            }
        }
    }
}
#pragma warning restore CS0618
