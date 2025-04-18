// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Polar.OpenAPI.Models
{
    /// <summary>
    /// Composed type wrapper for classes <see cref="global::Polar.OpenAPI.Models.DownloadableFileCreate"/>, <see cref="global::Polar.OpenAPI.Models.OrganizationAvatarFileCreate"/>, <see cref="global::Polar.OpenAPI.Models.ProductMediaFileCreate"/>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class FileCreate : IComposedTypeWrapper, IParsable
    {
        /// <summary>Composed type representation for type <see cref="global::Polar.OpenAPI.Models.DownloadableFileCreate"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Polar.OpenAPI.Models.DownloadableFileCreate? DownloadableFileCreate { get; set; }
#nullable restore
#else
        public global::Polar.OpenAPI.Models.DownloadableFileCreate DownloadableFileCreate { get; set; }
#endif
        /// <summary>Composed type representation for type <see cref="global::Polar.OpenAPI.Models.OrganizationAvatarFileCreate"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Polar.OpenAPI.Models.OrganizationAvatarFileCreate? OrganizationAvatarFileCreate { get; set; }
#nullable restore
#else
        public global::Polar.OpenAPI.Models.OrganizationAvatarFileCreate OrganizationAvatarFileCreate { get; set; }
#endif
        /// <summary>Composed type representation for type <see cref="global::Polar.OpenAPI.Models.ProductMediaFileCreate"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Polar.OpenAPI.Models.ProductMediaFileCreate? ProductMediaFileCreate { get; set; }
#nullable restore
#else
        public global::Polar.OpenAPI.Models.ProductMediaFileCreate ProductMediaFileCreate { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Polar.OpenAPI.Models.FileCreate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Polar.OpenAPI.Models.FileCreate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("service")?.GetStringValue();
            var result = new global::Polar.OpenAPI.Models.FileCreate();
            if("downloadable".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
            {
                result.DownloadableFileCreate = new global::Polar.OpenAPI.Models.DownloadableFileCreate();
            }
            else if("organization_avatar".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
            {
                result.OrganizationAvatarFileCreate = new global::Polar.OpenAPI.Models.OrganizationAvatarFileCreate();
            }
            else if("product_media".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
            {
                result.ProductMediaFileCreate = new global::Polar.OpenAPI.Models.ProductMediaFileCreate();
            }
            return result;
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            if(DownloadableFileCreate != null)
            {
                return DownloadableFileCreate.GetFieldDeserializers();
            }
            else if(OrganizationAvatarFileCreate != null)
            {
                return OrganizationAvatarFileCreate.GetFieldDeserializers();
            }
            else if(ProductMediaFileCreate != null)
            {
                return ProductMediaFileCreate.GetFieldDeserializers();
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
            if(DownloadableFileCreate != null)
            {
                writer.WriteObjectValue<global::Polar.OpenAPI.Models.DownloadableFileCreate>(null, DownloadableFileCreate);
            }
            else if(OrganizationAvatarFileCreate != null)
            {
                writer.WriteObjectValue<global::Polar.OpenAPI.Models.OrganizationAvatarFileCreate>(null, OrganizationAvatarFileCreate);
            }
            else if(ProductMediaFileCreate != null)
            {
                writer.WriteObjectValue<global::Polar.OpenAPI.Models.ProductMediaFileCreate>(null, ProductMediaFileCreate);
            }
        }
    }
}
#pragma warning restore CS0618
