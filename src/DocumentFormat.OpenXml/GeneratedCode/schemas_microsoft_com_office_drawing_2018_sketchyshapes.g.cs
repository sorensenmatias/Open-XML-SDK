﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes
{
    /// <summary>
    /// <para>Defines the LineSketchNoneEmpty Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ask:lineSketchNone.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(120, "lineSketchNone")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class LineSketchNoneEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the LineSketchNoneEmpty class.
        /// </summary>
        public LineSketchNoneEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(120, "lineSketchNone");
            builder.Availability = FileFormatVersions.Office2021;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LineSketchNoneEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the LineSketchCurvedEmpty Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ask:lineSketchCurved.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(120, "lineSketchCurved")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class LineSketchCurvedEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the LineSketchCurvedEmpty class.
        /// </summary>
        public LineSketchCurvedEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(120, "lineSketchCurved");
            builder.Availability = FileFormatVersions.Office2021;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LineSketchCurvedEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the LineSketchFreehandEmpty Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ask:lineSketchFreehand.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(120, "lineSketchFreehand")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class LineSketchFreehandEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the LineSketchFreehandEmpty class.
        /// </summary>
        public LineSketchFreehandEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(120, "lineSketchFreehand");
            builder.Availability = FileFormatVersions.Office2021;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LineSketchFreehandEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the LineSketchScribbleEmpty Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ask:lineSketchScribble.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(120, "lineSketchScribble")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class LineSketchScribbleEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the LineSketchScribbleEmpty class.
        /// </summary>
        public LineSketchScribbleEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(120, "lineSketchScribble");
            builder.Availability = FileFormatVersions.Office2021;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LineSketchScribbleEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the OpenXmlEmptyElement Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class OpenXmlEmptyElement : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the OpenXmlEmptyElement class.
        /// </summary>
        protected OpenXmlEmptyElement() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
        }
    }

    /// <summary>
    /// <para>Defines the LineSketchStyleProperties Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ask:lineSketchStyleProps.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.CustomGeometry &lt;a:custGeom></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PresetGeometry &lt;a:prstGeom></description></item>
    ///   <item><description>LineSketchTypeProperties &lt;ask:type></description></item>
    ///   <item><description>LineSketchSeed &lt;ask:seed></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;ask:extLst></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(120, "lineSketchStyleProps")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class LineSketchStyleProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the LineSketchStyleProperties class.
        /// </summary>
        public LineSketchStyleProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineSketchStyleProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LineSketchStyleProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineSketchStyleProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LineSketchStyleProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineSketchStyleProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LineSketchStyleProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>sd, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: sd</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "sd")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Sd
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(120, "lineSketchStyleProps");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.CustomGeometry>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PresetGeometry>();
            builder.AddChild<LineSketchTypeProperties>();
            builder.AddChild<LineSketchSeed>();
            builder.AddChild<OfficeArtExtensionList>();
            builder.AddElement<LineSketchStyleProperties>()
.AddAttribute(0, "sd", a => a.Sd);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.CustomGeometry), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetGeometry), 1, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchTypeProperties), 0, 1, version: FileFormatVersions.Office2021),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchSeed), 0, 1, version: FileFormatVersions.Office2021),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2021)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LineSketchStyleProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the LineSketchTypeProperties Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ask:type.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>LineSketchNoneEmpty &lt;ask:lineSketchNone></description></item>
    ///   <item><description>LineSketchCurvedEmpty &lt;ask:lineSketchCurved></description></item>
    ///   <item><description>LineSketchFreehandEmpty &lt;ask:lineSketchFreehand></description></item>
    ///   <item><description>LineSketchScribbleEmpty &lt;ask:lineSketchScribble></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(120, "type")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class LineSketchTypeProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the LineSketchTypeProperties class.
        /// </summary>
        public LineSketchTypeProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineSketchTypeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LineSketchTypeProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineSketchTypeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LineSketchTypeProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineSketchTypeProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LineSketchTypeProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(120, "type");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild<LineSketchNoneEmpty>();
            builder.AddChild<LineSketchCurvedEmpty>();
            builder.AddChild<LineSketchFreehandEmpty>();
            builder.AddChild<LineSketchScribbleEmpty>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 1, version: FileFormatVersions.Office2021)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchNoneEmpty), 1, 1, version: FileFormatVersions.Office2021),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchCurvedEmpty), 1, 1, version: FileFormatVersions.Office2021),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchFreehandEmpty), 1, 1, version: FileFormatVersions.Office2021),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchScribbleEmpty), 1, 1, version: FileFormatVersions.Office2021)
                    }
                }
            };
        }

        /// <summary>
        /// <para>LineSketchNoneEmpty.</para>
        /// <para>Represents the following element tag in the schema: ask:lineSketchNone.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ask = http://schemas.microsoft.com/office/drawing/2018/sketchyshapes
        /// </remark>
        public LineSketchNoneEmpty? LineSketchNoneEmpty
        {
            get => GetElement<LineSketchNoneEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>LineSketchCurvedEmpty.</para>
        /// <para>Represents the following element tag in the schema: ask:lineSketchCurved.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ask = http://schemas.microsoft.com/office/drawing/2018/sketchyshapes
        /// </remark>
        public LineSketchCurvedEmpty? LineSketchCurvedEmpty
        {
            get => GetElement<LineSketchCurvedEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>LineSketchFreehandEmpty.</para>
        /// <para>Represents the following element tag in the schema: ask:lineSketchFreehand.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ask = http://schemas.microsoft.com/office/drawing/2018/sketchyshapes
        /// </remark>
        public LineSketchFreehandEmpty? LineSketchFreehandEmpty
        {
            get => GetElement<LineSketchFreehandEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>LineSketchScribbleEmpty.</para>
        /// <para>Represents the following element tag in the schema: ask:lineSketchScribble.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ask = http://schemas.microsoft.com/office/drawing/2018/sketchyshapes
        /// </remark>
        public LineSketchScribbleEmpty? LineSketchScribbleEmpty
        {
            get => GetElement<LineSketchScribbleEmpty>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LineSketchTypeProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the LineSketchSeed Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ask:seed.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(120, "seed")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class LineSketchSeed : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the LineSketchSeed class.
        /// </summary>
        public LineSketchSeed() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineSketchSeed class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public LineSketchSeed(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new UInt32Value { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<UInt32Value>(NumberValidator.Instance);
            builder.SetSchema(120, "seed");
            builder.Availability = FileFormatVersions.Office2021;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LineSketchSeed>(deep);
    }

    /// <summary>
    /// <para>Defines the OfficeArtExtensionList Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ask:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Extension &lt;a:ext></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(120, "extLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class OfficeArtExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OfficeArtExtensionList class.
        /// </summary>
        public OfficeArtExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfficeArtExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OfficeArtExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfficeArtExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OfficeArtExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfficeArtExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public OfficeArtExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(120, "extLst");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Extension>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Extension), 0, 0)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OfficeArtExtensionList>(deep);
    }
}