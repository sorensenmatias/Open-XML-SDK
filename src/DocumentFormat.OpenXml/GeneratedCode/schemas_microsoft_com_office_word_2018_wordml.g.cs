﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2021.Word.ExtensionList
{
    /// <summary>
    /// <para>Defines the Extension Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w16cur:ext.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(126, "ext")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Extension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Extension class.
        /// </summary>
        public Extension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Extension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Extension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Extension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Extension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Extension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Extension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>uri, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: w16cur:uri</para>
        /// </summary>
        /// <remark>
        /// xmlns:w16cur=http://schemas.microsoft.com/office/word/2018/wordml
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(126, "uri")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Uri
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(126, "ext");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddElement<Extension>()
.AddAttribute(126, "uri", a => a.Uri, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2021));
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(1, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Extension>(deep);
    }
}