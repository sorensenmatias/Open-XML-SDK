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

namespace DocumentFormat.OpenXml.Office2016.Drawing.Command
{
    /// <summary>
    /// <para>Defines the ShapeMoniker Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:spMk.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "spMk")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ShapeMoniker : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ShapeMoniker class.
        /// </summary>
        public ShapeMoniker() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Id
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>creationId, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: creationId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "creationId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? CreationId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "spMk");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<ShapeMoniker>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "creationId", a => a.CreationId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeMoniker>(deep);
    }

    /// <summary>
    /// <para>Defines the GroupShapeMoniker Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:grpSpMk.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "grpSpMk")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class GroupShapeMoniker : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the GroupShapeMoniker class.
        /// </summary>
        public GroupShapeMoniker() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Id
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>creationId, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: creationId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "creationId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? CreationId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "grpSpMk");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<GroupShapeMoniker>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "creationId", a => a.CreationId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GroupShapeMoniker>(deep);
    }

    /// <summary>
    /// <para>Defines the GraphicFrameMoniker Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:graphicFrameMk.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "graphicFrameMk")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class GraphicFrameMoniker : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the GraphicFrameMoniker class.
        /// </summary>
        public GraphicFrameMoniker() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Id
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>creationId, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: creationId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "creationId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? CreationId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "graphicFrameMk");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<GraphicFrameMoniker>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "creationId", a => a.CreationId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GraphicFrameMoniker>(deep);
    }

    /// <summary>
    /// <para>Defines the ConnectorMoniker Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:cxnSpMk.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "cxnSpMk")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ConnectorMoniker : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ConnectorMoniker class.
        /// </summary>
        public ConnectorMoniker() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Id
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>creationId, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: creationId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "creationId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? CreationId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "cxnSpMk");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<ConnectorMoniker>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "creationId", a => a.CreationId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ConnectorMoniker>(deep);
    }

    /// <summary>
    /// <para>Defines the PictureMoniker Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:picMk.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "picMk")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class PictureMoniker : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the PictureMoniker class.
        /// </summary>
        public PictureMoniker() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Id
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>creationId, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: creationId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "creationId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? CreationId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "picMk");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<PictureMoniker>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "creationId", a => a.CreationId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PictureMoniker>(deep);
    }

    /// <summary>
    /// <para>Defines the InkMoniker Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:inkMk.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "inkMk")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class InkMoniker : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the InkMoniker class.
        /// </summary>
        public InkMoniker() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Id
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>creationId, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: creationId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "creationId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? CreationId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "inkMk");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<InkMoniker>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "creationId", a => a.CreationId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<InkMoniker>(deep);
    }

    /// <summary>
    /// <para>Defines the DrawingMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:dgMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "dgMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class DrawingMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DrawingMonikerList class.
        /// </summary>
        public DrawingMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DrawingMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DrawingMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DrawingMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DrawingMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DrawingMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DrawingMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "dgMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DrawingMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the Transform2D Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:xfrm.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Offset &lt;a:off></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Extents &lt;a:ext></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "xfrm")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Transform2D : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Transform2D class.
        /// </summary>
        public Transform2D() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Transform2D class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Transform2D(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Transform2D class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Transform2D(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Transform2D class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Transform2D(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Rotation</para>
        /// <para>Represents the following attribute in the schema: rot</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "rot")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Rotation
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Flip</para>
        /// <para>Represents the following attribute in the schema: flipH</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "flipH")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? HorizontalFlip
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Vertical Flip</para>
        /// <para>Represents the following attribute in the schema: flipV</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "flipV")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? VerticalFlip
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "xfrm");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Offset>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Extents>();
            builder.AddElement<Transform2D>()
.AddAttribute(0, "rot", a => a.Rotation)
.AddAttribute(0, "flipH", a => a.HorizontalFlip)
.AddAttribute(0, "flipV", a => a.VerticalFlip);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Offset), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Extents), 0, 1)
            };
        }

        /// <summary>
        /// <para>Offset.</para>
        /// <para>Represents the following element tag in the schema: a:off.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Offset? Offset
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Offset>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Extents.</para>
        /// <para>Represents the following element tag in the schema: a:ext.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Extents? Extents
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Extents>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Transform2D>(deep);
    }

    /// <summary>
    /// <para>Defines the GroupShapeMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:grpSpMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "grpSpMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class GroupShapeMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the GroupShapeMonikerList class.
        /// </summary>
        public GroupShapeMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShapeMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupShapeMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShapeMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupShapeMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShapeMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public GroupShapeMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "grpSpMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GroupShapeMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the DrawingElementPackage Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:dePkg.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "dePkg")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class DrawingElementPackage : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the DrawingElementPackage class.
        /// </summary>
        public DrawingElementPackage() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "dePkg");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DrawingElementPackage>(deep);
    }

    /// <summary>
    /// <para>Defines the DeMkLstDrawingElementMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:deMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "deMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class DeMkLstDrawingElementMonikerList : OpenXmlDrawingElementMonikerListElement
    {
        /// <summary>
        /// Initializes a new instance of the DeMkLstDrawingElementMonikerList class.
        /// </summary>
        public DeMkLstDrawingElementMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DeMkLstDrawingElementMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DeMkLstDrawingElementMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DeMkLstDrawingElementMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DeMkLstDrawingElementMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DeMkLstDrawingElementMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DeMkLstDrawingElementMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "deMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DeMkLstDrawingElementMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the DeMasterMkLstDrawingElementMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:deMasterMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "deMasterMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class DeMasterMkLstDrawingElementMonikerList : OpenXmlDrawingElementMonikerListElement
    {
        /// <summary>
        /// Initializes a new instance of the DeMasterMkLstDrawingElementMonikerList class.
        /// </summary>
        public DeMasterMkLstDrawingElementMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DeMasterMkLstDrawingElementMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DeMasterMkLstDrawingElementMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DeMasterMkLstDrawingElementMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DeMasterMkLstDrawingElementMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DeMasterMkLstDrawingElementMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DeMasterMkLstDrawingElementMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "deMasterMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DeMasterMkLstDrawingElementMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the DeSrcMkLstDrawingElementMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:deSrcMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "deSrcMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class DeSrcMkLstDrawingElementMonikerList : OpenXmlDrawingElementMonikerListElement
    {
        /// <summary>
        /// Initializes a new instance of the DeSrcMkLstDrawingElementMonikerList class.
        /// </summary>
        public DeSrcMkLstDrawingElementMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DeSrcMkLstDrawingElementMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DeSrcMkLstDrawingElementMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DeSrcMkLstDrawingElementMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DeSrcMkLstDrawingElementMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DeSrcMkLstDrawingElementMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DeSrcMkLstDrawingElementMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "deSrcMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DeSrcMkLstDrawingElementMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the DeTgtMkLstDrawingElementMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:deTgtMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "deTgtMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class DeTgtMkLstDrawingElementMonikerList : OpenXmlDrawingElementMonikerListElement
    {
        /// <summary>
        /// Initializes a new instance of the DeTgtMkLstDrawingElementMonikerList class.
        /// </summary>
        public DeTgtMkLstDrawingElementMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DeTgtMkLstDrawingElementMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DeTgtMkLstDrawingElementMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DeTgtMkLstDrawingElementMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DeTgtMkLstDrawingElementMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DeTgtMkLstDrawingElementMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DeTgtMkLstDrawingElementMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "deTgtMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DeTgtMkLstDrawingElementMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the OpenXmlDrawingElementMonikerListElement Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class OpenXmlDrawingElementMonikerListElement : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OpenXmlDrawingElementMonikerListElement class.
        /// </summary>
        protected OpenXmlDrawingElementMonikerListElement() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlDrawingElementMonikerListElement class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected OpenXmlDrawingElementMonikerListElement(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlDrawingElementMonikerListElement class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected OpenXmlDrawingElementMonikerListElement(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlDrawingElementMonikerListElement class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected OpenXmlDrawingElementMonikerListElement(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
        }
    }

    /// <summary>
    /// <para>Defines the ImgDataImgData Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:imgData.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "imgData")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ImgDataImgData : OpenXmlImgDataElement
    {
        /// <summary>
        /// Initializes a new instance of the ImgDataImgData class.
        /// </summary>
        public ImgDataImgData() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ImgDataImgData class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public ImgDataImgData(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Base64BinaryValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "imgData");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ImgDataImgData>(deep);
    }

    /// <summary>
    /// <para>Defines the OrigImgDataImgData Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:origImgData.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "origImgData")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class OrigImgDataImgData : OpenXmlImgDataElement
    {
        /// <summary>
        /// Initializes a new instance of the OrigImgDataImgData class.
        /// </summary>
        public OrigImgDataImgData() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OrigImgDataImgData class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public OrigImgDataImgData(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Base64BinaryValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "origImgData");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OrigImgDataImgData>(deep);
    }

    /// <summary>
    /// <para>Defines the SndDataImgData Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:sndData.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "sndData")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SndDataImgData : OpenXmlImgDataElement
    {
        /// <summary>
        /// Initializes a new instance of the SndDataImgData class.
        /// </summary>
        public SndDataImgData() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SndDataImgData class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public SndDataImgData(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Base64BinaryValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "sndData");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SndDataImgData>(deep);
    }

    /// <summary>
    /// <para>Defines the OpenXmlImgDataElement Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class OpenXmlImgDataElement : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the OpenXmlImgDataElement class.
        /// </summary>
        protected OpenXmlImgDataElement() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlImgDataElement class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        protected OpenXmlImgDataElement(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Base64BinaryValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
        }
    }

    /// <summary>
    /// <para>Defines the ResourceUrl Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:imgUrl.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "imgUrl")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ResourceUrl : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ResourceUrl class.
        /// </summary>
        public ResourceUrl() : base()
        {
        }

        /// <summary>
        /// <para>src, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: src</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "src")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Src
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>linkage, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: linkage</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "linkage")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.Command.ResourceLinkage>? Linkage
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.Command.ResourceLinkage>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "imgUrl");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<ResourceUrl>()
.AddAttribute(0, "src", a => a.Src, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
})
.AddAttribute(0, "linkage", a => a.Linkage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ResourceUrl>(deep);
    }

    /// <summary>
    /// <para>Defines the TextBodyPackage Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:txBodyPkg.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "txBodyPkg")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class TextBodyPackage : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TextBodyPackage class.
        /// </summary>
        public TextBodyPackage() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "txBodyPkg");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextBodyPackage>(deep);
    }

    /// <summary>
    /// <para>Defines the GroupCommand Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:grpCmd.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DrawingMonikerList &lt;oac:dgMkLst></description></item>
    ///   <item><description>ShapeMoniker &lt;oac:spMk></description></item>
    ///   <item><description>GroupShapeMoniker &lt;oac:grpSpMk></description></item>
    ///   <item><description>GraphicFrameMoniker &lt;oac:graphicFrameMk></description></item>
    ///   <item><description>ConnectorMoniker &lt;oac:cxnSpMk></description></item>
    ///   <item><description>PictureMoniker &lt;oac:picMk></description></item>
    ///   <item><description>InkMoniker &lt;oac:inkMk></description></item>
    ///   <item><description>GroupShapeProperties &lt;oac:grpSpPr></description></item>
    ///   <item><description>NonVisualDrawingProps &lt;oac:cNvPr></description></item>
    ///   <item><description>NonVisualGroupDrawingShapeProps &lt;oac:cNvGrpSpPr></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "grpCmd")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class GroupCommand : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the GroupCommand class.
        /// </summary>
        public GroupCommand() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupCommand class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupCommand(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupCommand class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupCommand(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupCommand class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public GroupCommand(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>verId, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: verId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "verId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? VerId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>preventRegroup, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: preventRegroup</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "preventRegroup")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? PreventRegroup
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>grpId, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: grpId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "grpId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? GrpId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "grpCmd");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DrawingMonikerList>();
            builder.AddChild<ShapeMoniker>();
            builder.AddChild<GroupShapeMoniker>();
            builder.AddChild<GraphicFrameMoniker>();
            builder.AddChild<ConnectorMoniker>();
            builder.AddChild<PictureMoniker>();
            builder.AddChild<InkMoniker>();
            builder.AddChild<GroupShapeProperties>();
            builder.AddChild<NonVisualDrawingProps>();
            builder.AddChild<NonVisualGroupDrawingShapeProps>();
            builder.AddElement<GroupCommand>()
.AddAttribute(0, "verId", a => a.VerId)
.AddAttribute(0, "preventRegroup", a => a.PreventRegroup)
.AddAttribute(0, "grpId", a => a.GrpId);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.DrawingMonikerList), 1, 1, version: FileFormatVersions.Office2016),
                new CompositeParticle.Builder(ParticleType.Group, 0, 0, version: FileFormatVersions.Office2016)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.ShapeMoniker), 1, 1, version: FileFormatVersions.Office2016),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.GroupShapeMoniker), 1, 1, version: FileFormatVersions.Office2016),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.GraphicFrameMoniker), 1, 1, version: FileFormatVersions.Office2016),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.ConnectorMoniker), 1, 1, version: FileFormatVersions.Office2016),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.PictureMoniker), 1, 1, version: FileFormatVersions.Office2016),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.InkMoniker), 1, 1, version: FileFormatVersions.Office2016)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.GroupShapeProperties), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.NonVisualDrawingProps), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.NonVisualGroupDrawingShapeProps), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>DrawingMonikerList.</para>
        /// <para>Represents the following element tag in the schema: oac:dgMkLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public DrawingMonikerList? DrawingMonikerList
        {
            get => GetElement<DrawingMonikerList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GroupCommand>(deep);
    }

    /// <summary>
    /// <para>Defines the ImgLink Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:imgLink.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "imgLink")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ImgLink : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ImgLink class.
        /// </summary>
        public ImgLink() : base()
        {
        }

        /// <summary>
        /// <para>tgt, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: tgt</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "tgt")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Tgt
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "imgLink");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<ImgLink>()
.AddAttribute(0, "tgt", a => a.Tgt, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ImgLink>(deep);
    }

    /// <summary>
    /// <para>Defines the DocumentContextMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:dcMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "dcMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class DocumentContextMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DocumentContextMonikerList class.
        /// </summary>
        public DocumentContextMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DocumentContextMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DocumentContextMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DocumentContextMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DocumentContextMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DocumentContextMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DocumentContextMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "dcMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DocumentContextMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the GraphicParentMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:graphicParentMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "graphicParentMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class GraphicParentMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the GraphicParentMonikerList class.
        /// </summary>
        public GraphicParentMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GraphicParentMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GraphicParentMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GraphicParentMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GraphicParentMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GraphicParentMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public GraphicParentMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "graphicParentMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GraphicParentMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the ShapeMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:spMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "spMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ShapeMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ShapeMonikerList class.
        /// </summary>
        public ShapeMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapeMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapeMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ShapeMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "spMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the GraphicFrameMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:graphicFrameMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "graphicFrameMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class GraphicFrameMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the GraphicFrameMonikerList class.
        /// </summary>
        public GraphicFrameMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GraphicFrameMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GraphicFrameMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GraphicFrameMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GraphicFrameMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GraphicFrameMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public GraphicFrameMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "graphicFrameMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GraphicFrameMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the ConnectorMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:cxnSpMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "cxnSpMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ConnectorMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ConnectorMonikerList class.
        /// </summary>
        public ConnectorMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ConnectorMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ConnectorMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ConnectorMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ConnectorMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ConnectorMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ConnectorMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "cxnSpMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ConnectorMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the PictureMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:picMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "picMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class PictureMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PictureMonikerList class.
        /// </summary>
        public PictureMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PictureMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PictureMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PictureMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PictureMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PictureMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PictureMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "picMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PictureMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the InkMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:inkMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "inkMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class InkMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the InkMonikerList class.
        /// </summary>
        public InkMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the InkMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public InkMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the InkMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public InkMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the InkMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public InkMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "inkMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<InkMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the TextBodyMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:txBodyMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "txBodyMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class TextBodyMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TextBodyMonikerList class.
        /// </summary>
        public TextBodyMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBodyMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextBodyMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBodyMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextBodyMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBodyMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TextBodyMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "txBodyMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextBodyMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the TextCharRangeMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:txMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "txMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class TextCharRangeMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TextCharRangeMonikerList class.
        /// </summary>
        public TextCharRangeMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextCharRangeMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextCharRangeMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextCharRangeMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextCharRangeMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextCharRangeMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TextCharRangeMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "txMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextCharRangeMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the HyperlinkMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:hlinkMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "hlinkMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class HyperlinkMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the HyperlinkMonikerList class.
        /// </summary>
        public HyperlinkMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the HyperlinkMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HyperlinkMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the HyperlinkMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HyperlinkMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the HyperlinkMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public HyperlinkMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "hlinkMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HyperlinkMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the Model3DMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:model3DMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "model3DMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Model3DMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Model3DMonikerList class.
        /// </summary>
        public Model3DMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model3DMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Model3DMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model3DMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Model3DMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model3DMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Model3DMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "model3DMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Model3DMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the ViewSelectionStgList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:viewSelLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "viewSelLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ViewSelectionStgList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ViewSelectionStgList class.
        /// </summary>
        public ViewSelectionStgList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ViewSelectionStgList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ViewSelectionStgList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ViewSelectionStgList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ViewSelectionStgList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ViewSelectionStgList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ViewSelectionStgList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "viewSelLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ViewSelectionStgList>(deep);
    }

    /// <summary>
    /// <para>Defines the EditorSelectionStgList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:editorSelLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "editorSelLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class EditorSelectionStgList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the EditorSelectionStgList class.
        /// </summary>
        public EditorSelectionStgList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EditorSelectionStgList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public EditorSelectionStgList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the EditorSelectionStgList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public EditorSelectionStgList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the EditorSelectionStgList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public EditorSelectionStgList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "editorSelLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EditorSelectionStgList>(deep);
    }

    /// <summary>
    /// <para>Defines the DrawingSelectionStgList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:drSelLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "drSelLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class DrawingSelectionStgList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DrawingSelectionStgList class.
        /// </summary>
        public DrawingSelectionStgList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DrawingSelectionStgList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DrawingSelectionStgList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DrawingSelectionStgList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DrawingSelectionStgList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DrawingSelectionStgList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DrawingSelectionStgList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "drSelLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DrawingSelectionStgList>(deep);
    }

    /// <summary>
    /// <para>Defines the TableMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:tblMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "tblMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class TableMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TableMonikerList class.
        /// </summary>
        public TableMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TableMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TableMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TableMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TableMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TableMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TableMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "tblMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TableMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the TableCellMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:tcMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "tcMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class TableCellMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TableCellMonikerList class.
        /// </summary>
        public TableCellMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TableCellMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TableCellMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TableCellMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TableCellMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TableCellMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TableCellMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "tcMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TableCellMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the TableRowMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:trMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "trMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class TableRowMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TableRowMonikerList class.
        /// </summary>
        public TableRowMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TableRowMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TableRowMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TableRowMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TableRowMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TableRowMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TableRowMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "trMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TableRowMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the TableColumnMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:gridColMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "gridColMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class TableColumnMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TableColumnMonikerList class.
        /// </summary>
        public TableColumnMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TableColumnMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TableColumnMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TableColumnMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TableColumnMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TableColumnMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TableColumnMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "gridColMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TableColumnMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the ModifyNonVisualDrawingProps Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:cNvPr.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "cNvPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ModifyNonVisualDrawingProps : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ModifyNonVisualDrawingProps class.
        /// </summary>
        public ModifyNonVisualDrawingProps() : base()
        {
        }

        /// <summary>
        /// <para>name, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "name")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>descr, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: descr</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "descr")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Descr
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>hidden, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: hidden</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "hidden")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? Hidden
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>title, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: title</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "title")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Title
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>decor, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: decor</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "decor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? Decor
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>scriptLink, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: scriptLink</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "scriptLink")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? ScriptLink
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "cNvPr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<ModifyNonVisualDrawingProps>()
.AddAttribute(0, "name", a => a.Name)
.AddAttribute(0, "descr", a => a.Descr)
.AddAttribute(0, "hidden", a => a.Hidden)
.AddAttribute(0, "title", a => a.Title)
.AddAttribute(0, "decor", a => a.Decor)
.AddAttribute(0, "scriptLink", a => a.ScriptLink);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ModifyNonVisualDrawingProps>(deep);
    }

    /// <summary>
    /// <para>Defines the ModifyTransformProps Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:xfrm.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "xfrm")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ModifyTransformProps : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ModifyTransformProps class.
        /// </summary>
        public ModifyTransformProps() : base()
        {
        }

        /// <summary>
        /// <para>x, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: x</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "x")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int64Value? X
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>y, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: y</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "y")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int64Value? Y
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>cx, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: cx</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "cx")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int64Value? Cx
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>cy, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: cy</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "cy")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int64Value? Cy
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>rot, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: rot</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "rot")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Rot
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>flipH, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: flipH</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "flipH")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? FlipH
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>flipV, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: flipV</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "flipV")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? FlipV
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "xfrm");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<ModifyTransformProps>()
.AddAttribute(0, "x", a => a.X, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
})
.AddAttribute(0, "y", a => a.Y, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
})
.AddAttribute(0, "cx", a => a.Cx, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (2147483647L) });
})
.AddAttribute(0, "cy", a => a.Cy, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (2147483647L) });
})
.AddAttribute(0, "rot", a => a.Rot)
.AddAttribute(0, "flipH", a => a.FlipH)
.AddAttribute(0, "flipV", a => a.FlipV);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ModifyTransformProps>(deep);
    }

    /// <summary>
    /// <para>Defines the Point2DType Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:off.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "off")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Point2DType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Point2DType class.
        /// </summary>
        public Point2DType() : base()
        {
        }

        /// <summary>
        /// <para>X-Axis Coordinate</para>
        /// <para>Represents the following attribute in the schema: x</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "x")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int64Value? X
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Y-Axis Coordinate</para>
        /// <para>Represents the following attribute in the schema: y</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "y")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int64Value? Y
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "off");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<Point2DType>()
.AddAttribute(0, "x", a => a.X, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
})
.AddAttribute(0, "y", a => a.Y, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Point2DType>(deep);
    }

    /// <summary>
    /// <para>Defines the TextParagraphPropertiesType Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:pPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.LineSpacing &lt;a:lnSpc></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SpaceBefore &lt;a:spcBef></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SpaceAfter &lt;a:spcAft></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.BulletColorText &lt;a:buClrTx></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.BulletColor &lt;a:buClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.BulletSizeText &lt;a:buSzTx></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.BulletSizePercentage &lt;a:buSzPct></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.BulletSizePoints &lt;a:buSzPts></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.BulletFontText &lt;a:buFontTx></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.BulletFont &lt;a:buFont></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.NoBullet &lt;a:buNone></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.AutoNumberedBullet &lt;a:buAutoNum></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.CharacterBullet &lt;a:buChar></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PictureBullet &lt;a:buBlip></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.TabStopList &lt;a:tabLst></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.DefaultRunProperties &lt;a:defRPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "pPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class TextParagraphPropertiesType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TextParagraphPropertiesType class.
        /// </summary>
        public TextParagraphPropertiesType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextParagraphPropertiesType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextParagraphPropertiesType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextParagraphPropertiesType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextParagraphPropertiesType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextParagraphPropertiesType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TextParagraphPropertiesType(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Left Margin</para>
        /// <para>Represents the following attribute in the schema: marL</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "marL")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? LeftMargin
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Right Margin</para>
        /// <para>Represents the following attribute in the schema: marR</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "marR")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? RightMargin
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Level</para>
        /// <para>Represents the following attribute in the schema: lvl</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "lvl")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Level
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Indent</para>
        /// <para>Represents the following attribute in the schema: indent</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "indent")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Indent
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Alignment</para>
        /// <para>Represents the following attribute in the schema: algn</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "algn")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.TextAlignmentTypeValues>? Alignment
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.TextAlignmentTypeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Default Tab Size</para>
        /// <para>Represents the following attribute in the schema: defTabSz</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "defTabSz")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? DefaultTabSize
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Right To Left</para>
        /// <para>Represents the following attribute in the schema: rtl</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "rtl")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? RightToLeft
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>East Asian Line Break</para>
        /// <para>Represents the following attribute in the schema: eaLnBrk</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "eaLnBrk")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? EastAsianLineBreak
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Font Alignment</para>
        /// <para>Represents the following attribute in the schema: fontAlgn</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "fontAlgn")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.TextFontAlignmentValues>? FontAlignment
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.TextFontAlignmentValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Latin Line Break</para>
        /// <para>Represents the following attribute in the schema: latinLnBrk</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "latinLnBrk")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? LatinLineBreak
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hanging Punctuation</para>
        /// <para>Represents the following attribute in the schema: hangingPunct</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "hangingPunct")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? Height
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "pPr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.LineSpacing>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SpaceBefore>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SpaceAfter>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BulletColorText>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BulletColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BulletSizeText>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BulletSizePercentage>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BulletSizePoints>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BulletFontText>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BulletFont>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NoBullet>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.AutoNumberedBullet>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.CharacterBullet>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PictureBullet>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.TabStopList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.DefaultRunProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            builder.AddElement<TextParagraphPropertiesType>()
.AddAttribute(0, "marL", a => a.LeftMargin, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (51206400L) });
})
.AddAttribute(0, "marR", a => a.RightMargin, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (51206400L) });
})
.AddAttribute(0, "lvl", a => a.Level, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (8L) });
})
.AddAttribute(0, "indent", a => a.Indent, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-51206400L), MaxInclusive = (51206400L) });
})
.AddAttribute(0, "algn", a => a.Alignment, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "defTabSz", a => a.DefaultTabSize)
.AddAttribute(0, "rtl", a => a.RightToLeft)
.AddAttribute(0, "eaLnBrk", a => a.EastAsianLineBreak)
.AddAttribute(0, "fontAlgn", a => a.FontAlignment, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "latinLnBrk", a => a.LatinLineBreak)
.AddAttribute(0, "hangingPunct", a => a.Height);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.LineSpacing), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SpaceBefore), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SpaceAfter), 0, 1),
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BulletColorText), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BulletColor), 1, 1)
                    }
                },
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BulletSizeText), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BulletSizePercentage), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BulletSizePoints), 1, 1)
                    }
                },
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BulletFontText), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BulletFont), 1, 1)
                    }
                },
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NoBullet), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.AutoNumberedBullet), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.CharacterBullet), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PictureBullet), 1, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.TabStopList), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.DefaultRunProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Line Spacing.</para>
        /// <para>Represents the following element tag in the schema: a:lnSpc.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.LineSpacing? LineSpacing
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.LineSpacing>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Space Before.</para>
        /// <para>Represents the following element tag in the schema: a:spcBef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.SpaceBefore? SpaceBefore
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.SpaceBefore>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Space After.</para>
        /// <para>Represents the following element tag in the schema: a:spcAft.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.SpaceAfter? SpaceAfter
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.SpaceAfter>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextParagraphPropertiesType>(deep);
    }

    /// <summary>
    /// <para>Defines the TextBodyProperties Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:bodyPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PresetTextWrap &lt;a:prstTxWarp></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.NoAutoFit &lt;a:noAutofit></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.NormalAutoFit &lt;a:normAutofit></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ShapeAutoFit &lt;a:spAutoFit></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Scene3DType &lt;a:scene3d></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Shape3DType &lt;a:sp3d></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.FlatText &lt;a:flatTx></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "bodyPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class TextBodyProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TextBodyProperties class.
        /// </summary>
        public TextBodyProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBodyProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextBodyProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBodyProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextBodyProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBodyProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TextBodyProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Rotation</para>
        /// <para>Represents the following attribute in the schema: rot</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "rot")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Rotation
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Paragraph Spacing</para>
        /// <para>Represents the following attribute in the schema: spcFirstLastPara</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "spcFirstLastPara")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? UseParagraphSpacing
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Vertical Overflow</para>
        /// <para>Represents the following attribute in the schema: vertOverflow</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "vertOverflow")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.TextVerticalOverflowValues>? VerticalOverflow
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.TextVerticalOverflowValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Horizontal Overflow</para>
        /// <para>Represents the following attribute in the schema: horzOverflow</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "horzOverflow")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.TextHorizontalOverflowValues>? HorizontalOverflow
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.TextHorizontalOverflowValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Vertical Text</para>
        /// <para>Represents the following attribute in the schema: vert</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "vert")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.TextVerticalValues>? Vertical
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.TextVerticalValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Wrapping Type</para>
        /// <para>Represents the following attribute in the schema: wrap</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "wrap")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.TextWrappingValues>? Wrap
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.TextWrappingValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Left Inset</para>
        /// <para>Represents the following attribute in the schema: lIns</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "lIns")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? LeftInset
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Top Inset</para>
        /// <para>Represents the following attribute in the schema: tIns</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "tIns")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? TopInset
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Right Inset</para>
        /// <para>Represents the following attribute in the schema: rIns</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "rIns")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? RightInset
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Bottom Inset</para>
        /// <para>Represents the following attribute in the schema: bIns</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "bIns")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? BottomInset
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Number of Columns</para>
        /// <para>Represents the following attribute in the schema: numCol</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "numCol")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? ColumnCount
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Space Between Columns</para>
        /// <para>Represents the following attribute in the schema: spcCol</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "spcCol")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? ColumnSpacing
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Columns Right-To-Left</para>
        /// <para>Represents the following attribute in the schema: rtlCol</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "rtlCol")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? RightToLeftColumns
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>From WordArt</para>
        /// <para>Represents the following attribute in the schema: fromWordArt</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "fromWordArt")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? FromWordArt
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Anchor</para>
        /// <para>Represents the following attribute in the schema: anchor</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "anchor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.TextAnchoringTypeValues>? Anchor
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.TextAnchoringTypeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Anchor Center</para>
        /// <para>Represents the following attribute in the schema: anchorCtr</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "anchorCtr")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? AnchorCenter
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Force Anti-Alias</para>
        /// <para>Represents the following attribute in the schema: forceAA</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "forceAA")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? ForceAntiAlias
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Upright</para>
        /// <para>Represents the following attribute in the schema: upright</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "upright")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? UpRight
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Compatible Line Spacing</para>
        /// <para>Represents the following attribute in the schema: compatLnSpc</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "compatLnSpc")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? CompatibleLineSpacing
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "bodyPr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PresetTextWrap>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NoAutoFit>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NormalAutoFit>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ShapeAutoFit>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Scene3DType>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Shape3DType>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.FlatText>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            builder.AddElement<TextBodyProperties>()
.AddAttribute(0, "rot", a => a.Rotation)
.AddAttribute(0, "spcFirstLastPara", a => a.UseParagraphSpacing)
.AddAttribute(0, "vertOverflow", a => a.VerticalOverflow, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "horzOverflow", a => a.HorizontalOverflow, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "vert", a => a.Vertical, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "wrap", a => a.Wrap, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "lIns", a => a.LeftInset)
.AddAttribute(0, "tIns", a => a.TopInset)
.AddAttribute(0, "rIns", a => a.RightInset)
.AddAttribute(0, "bIns", a => a.BottomInset)
.AddAttribute(0, "numCol", a => a.ColumnCount, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L), MaxInclusive = (16L) });
})
.AddAttribute(0, "spcCol", a => a.ColumnSpacing, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L) });
})
.AddAttribute(0, "rtlCol", a => a.RightToLeftColumns)
.AddAttribute(0, "fromWordArt", a => a.FromWordArt)
.AddAttribute(0, "anchor", a => a.Anchor, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "anchorCtr", a => a.AnchorCenter)
.AddAttribute(0, "forceAA", a => a.ForceAntiAlias)
.AddAttribute(0, "upright", a => a.UpRight)
.AddAttribute(0, "compatLnSpc", a => a.CompatibleLineSpacing);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetTextWrap), 0, 1),
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NoAutoFit), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NormalAutoFit), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ShapeAutoFit), 1, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Scene3DType), 0, 1),
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Shape3DType), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.FlatText), 1, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Preset Text Shape.</para>
        /// <para>Represents the following element tag in the schema: a:prstTxWarp.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.PresetTextWrap? PresetTextWrap
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.PresetTextWrap>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextBodyProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the ModifyNonVisualDrawingShapeProps Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:cNvSpPr.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "cNvSpPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ModifyNonVisualDrawingShapeProps : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ModifyNonVisualDrawingShapeProps class.
        /// </summary>
        public ModifyNonVisualDrawingShapeProps() : base()
        {
        }

        /// <summary>
        /// <para>noGrp, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noGrp</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noGrp")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoGrp
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noSelect, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noSelect</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noSelect")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoSelect
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noRot, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noRot</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noRot")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoRot
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noChangeAspect, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noChangeAspect</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noChangeAspect")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoChangeAspect
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noMove, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noMove</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noMove")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoMove
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noResize, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noResize</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noResize")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoResize
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noEditPoints, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noEditPoints</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noEditPoints")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoEditPoints
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noAdjustHandles, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noAdjustHandles</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noAdjustHandles")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoAdjustHandles
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noChangeArrowheads, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noChangeArrowheads</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noChangeArrowheads")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoChangeArrowheads
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noChangeShapeType, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noChangeShapeType</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noChangeShapeType")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoChangeShapeType
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noTextEdit, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noTextEdit</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noTextEdit")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoTextEdit
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>txBox, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: txBox</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "txBox")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? TxBox
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "cNvSpPr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<ModifyNonVisualDrawingShapeProps>()
.AddAttribute(0, "noGrp", a => a.NoGrp)
.AddAttribute(0, "noSelect", a => a.NoSelect)
.AddAttribute(0, "noRot", a => a.NoRot)
.AddAttribute(0, "noChangeAspect", a => a.NoChangeAspect)
.AddAttribute(0, "noMove", a => a.NoMove)
.AddAttribute(0, "noResize", a => a.NoResize)
.AddAttribute(0, "noEditPoints", a => a.NoEditPoints)
.AddAttribute(0, "noAdjustHandles", a => a.NoAdjustHandles)
.AddAttribute(0, "noChangeArrowheads", a => a.NoChangeArrowheads)
.AddAttribute(0, "noChangeShapeType", a => a.NoChangeShapeType)
.AddAttribute(0, "noTextEdit", a => a.NoTextEdit)
.AddAttribute(0, "txBox", a => a.TxBox);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ModifyNonVisualDrawingShapeProps>(deep);
    }

    /// <summary>
    /// <para>Defines the ShapePropsMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:spMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "spMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ShapePropsMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ShapePropsMonikerList class.
        /// </summary>
        public ShapePropsMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapePropsMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapePropsMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapePropsMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapePropsMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapePropsMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ShapePropsMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "spMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapePropsMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the ShapeProperties Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:spPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Transform2D &lt;a:xfrm></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.CustomGeometry &lt;a:custGeom></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PresetGeometry &lt;a:prstGeom></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.NoFill &lt;a:noFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SolidFill &lt;a:solidFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.GradientFill &lt;a:gradFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.BlipFill &lt;a:blipFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PatternFill &lt;a:pattFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.GroupFill &lt;a:grpFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Outline &lt;a:ln></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.EffectList &lt;a:effectLst></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.EffectDag &lt;a:effectDag></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Scene3DType &lt;a:scene3d></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Shape3DType &lt;a:sp3d></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "spPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ShapeProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ShapeProperties class.
        /// </summary>
        public ShapeProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapeProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ShapeProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Black and White Mode</para>
        /// <para>Represents the following attribute in the schema: bwMode</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "bwMode")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>? BlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "spPr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Transform2D>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.CustomGeometry>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PresetGeometry>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NoFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SolidFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GradientFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BlipFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PatternFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GroupFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Outline>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectDag>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Scene3DType>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Shape3DType>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList>();
            builder.AddElement<ShapeProperties>()
.AddAttribute(0, "bwMode", a => a.BlackWhiteMode, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Transform2D), 0, 1),
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.CustomGeometry), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetGeometry), 1, 1)
                    }
                },
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NoFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SolidFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GradientFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BlipFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PatternFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GroupFill), 1, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Outline), 0, 1),
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectList), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectDag), 1, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Scene3DType), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Shape3DType), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>2D Transform for Individual Objects.</para>
        /// <para>Represents the following element tag in the schema: a:xfrm.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Transform2D? Transform2D
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Transform2D>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the XfrmEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:xfrm.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "xfrm")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class XfrmEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the XfrmEmpty class.
        /// </summary>
        public XfrmEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "xfrm");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<XfrmEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the GeomEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:geom.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "geom")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class GeomEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the GeomEmpty class.
        /// </summary>
        public GeomEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "geom");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GeomEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the FillEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:fill.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "fill")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class FillEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the FillEmpty class.
        /// </summary>
        public FillEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "fill");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FillEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the LnEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:ln.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "ln")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class LnEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the LnEmpty class.
        /// </summary>
        public LnEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "ln");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LnEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the EffectEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:effect.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "effect")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class EffectEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the EffectEmpty class.
        /// </summary>
        public EffectEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "effect");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EffectEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the Scene3dEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:scene3d.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "scene3d")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Scene3dEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the Scene3dEmpty class.
        /// </summary>
        public Scene3dEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "scene3d");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Scene3dEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the Sp3dEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:sp3d.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "sp3d")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Sp3dEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the Sp3dEmpty class.
        /// </summary>
        public Sp3dEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "sp3d");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Sp3dEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the ExtLstEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:extLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "extLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ExtLstEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the ExtLstEmpty class.
        /// </summary>
        public ExtLstEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "extLst");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExtLstEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the BwModeEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:bwMode.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "bwMode")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class BwModeEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the BwModeEmpty class.
        /// </summary>
        public BwModeEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "bwMode");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BwModeEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the SrcRectEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:srcRect.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "srcRect")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SrcRectEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the SrcRectEmpty class.
        /// </summary>
        public SrcRectEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "srcRect");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SrcRectEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the FillModeEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:fillMode.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "fillMode")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class FillModeEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the FillModeEmpty class.
        /// </summary>
        public FillModeEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "fillMode");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FillModeEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the DpiEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:dpi.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "dpi")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class DpiEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the DpiEmpty class.
        /// </summary>
        public DpiEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "dpi");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DpiEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the RotWithShapeEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:rotWithShape.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "rotWithShape")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class RotWithShapeEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the RotWithShapeEmpty class.
        /// </summary>
        public RotWithShapeEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "rotWithShape");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RotWithShapeEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the StCxnEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:stCxn.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "stCxn")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class StCxnEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the StCxnEmpty class.
        /// </summary>
        public StCxnEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "stCxn");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StCxnEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the EndCxnEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:endCxn.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "endCxn")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class EndCxnEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the EndCxnEmpty class.
        /// </summary>
        public EndCxnEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "endCxn");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EndCxnEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the NoGrpEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:noGrp.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "noGrp")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class NoGrpEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the NoGrpEmpty class.
        /// </summary>
        public NoGrpEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "noGrp");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NoGrpEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the NoSelectEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:noSelect.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "noSelect")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class NoSelectEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the NoSelectEmpty class.
        /// </summary>
        public NoSelectEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "noSelect");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NoSelectEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the NoRotEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:noRot.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "noRot")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class NoRotEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the NoRotEmpty class.
        /// </summary>
        public NoRotEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "noRot");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NoRotEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the NoChangeAspectEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:noChangeAspect.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "noChangeAspect")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class NoChangeAspectEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the NoChangeAspectEmpty class.
        /// </summary>
        public NoChangeAspectEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "noChangeAspect");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NoChangeAspectEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the NoMoveEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:noMove.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "noMove")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class NoMoveEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the NoMoveEmpty class.
        /// </summary>
        public NoMoveEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "noMove");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NoMoveEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the NoResizeEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:noResize.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "noResize")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class NoResizeEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the NoResizeEmpty class.
        /// </summary>
        public NoResizeEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "noResize");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NoResizeEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the NoEditPointsEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:noEditPoints.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "noEditPoints")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class NoEditPointsEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the NoEditPointsEmpty class.
        /// </summary>
        public NoEditPointsEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "noEditPoints");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NoEditPointsEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the NoAdjustHandlesEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:noAdjustHandles.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "noAdjustHandles")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class NoAdjustHandlesEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the NoAdjustHandlesEmpty class.
        /// </summary>
        public NoAdjustHandlesEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "noAdjustHandles");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NoAdjustHandlesEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the NoChangeArrowheadsEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:noChangeArrowheads.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "noChangeArrowheads")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class NoChangeArrowheadsEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the NoChangeArrowheadsEmpty class.
        /// </summary>
        public NoChangeArrowheadsEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "noChangeArrowheads");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NoChangeArrowheadsEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the NoChangeShapeTypeEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:noChangeShapeType.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "noChangeShapeType")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class NoChangeShapeTypeEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the NoChangeShapeTypeEmpty class.
        /// </summary>
        public NoChangeShapeTypeEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "noChangeShapeType");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NoChangeShapeTypeEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the LfPrEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:lfPr.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "lfPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class LfPrEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the LfPrEmpty class.
        /// </summary>
        public LfPrEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "lfPr");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LfPrEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the HlinkClickEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:hlinkClick.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "hlinkClick")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class HlinkClickEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the HlinkClickEmpty class.
        /// </summary>
        public HlinkClickEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "hlinkClick");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HlinkClickEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the HlinkHoverEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:hlinkHover.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "hlinkHover")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class HlinkHoverEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the HlinkHoverEmpty class.
        /// </summary>
        public HlinkHoverEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "hlinkHover");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HlinkHoverEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the OpenXmlEmptyElement Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
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
    /// <para>Defines the ResetShapeProperties Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:spPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>XfrmEmpty &lt;oac:xfrm></description></item>
    ///   <item><description>GeomEmpty &lt;oac:geom></description></item>
    ///   <item><description>FillEmpty &lt;oac:fill></description></item>
    ///   <item><description>LnEmpty &lt;oac:ln></description></item>
    ///   <item><description>EffectEmpty &lt;oac:effect></description></item>
    ///   <item><description>Scene3dEmpty &lt;oac:scene3d></description></item>
    ///   <item><description>Sp3dEmpty &lt;oac:sp3d></description></item>
    ///   <item><description>ExtLstEmpty &lt;oac:extLst></description></item>
    ///   <item><description>BwModeEmpty &lt;oac:bwMode></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "spPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ResetShapeProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ResetShapeProperties class.
        /// </summary>
        public ResetShapeProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ResetShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ResetShapeProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ResetShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ResetShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ResetShapeProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ResetShapeProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "spPr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<XfrmEmpty>();
            builder.AddChild<GeomEmpty>();
            builder.AddChild<FillEmpty>();
            builder.AddChild<LnEmpty>();
            builder.AddChild<EffectEmpty>();
            builder.AddChild<Scene3dEmpty>();
            builder.AddChild<Sp3dEmpty>();
            builder.AddChild<ExtLstEmpty>();
            builder.AddChild<BwModeEmpty>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.XfrmEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.GeomEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.FillEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.LnEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.EffectEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.Scene3dEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.Sp3dEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.ExtLstEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.BwModeEmpty), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>XfrmEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:xfrm.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public XfrmEmpty? XfrmEmpty
        {
            get => GetElement<XfrmEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>GeomEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:geom.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public GeomEmpty? GeomEmpty
        {
            get => GetElement<GeomEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>FillEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:fill.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public FillEmpty? FillEmpty
        {
            get => GetElement<FillEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>LnEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:ln.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public LnEmpty? LnEmpty
        {
            get => GetElement<LnEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EffectEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:effect.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public EffectEmpty? EffectEmpty
        {
            get => GetElement<EffectEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Scene3dEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:scene3d.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public Scene3dEmpty? Scene3dEmpty
        {
            get => GetElement<Scene3dEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Sp3dEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:sp3d.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public Sp3dEmpty? Sp3dEmpty
        {
            get => GetElement<Sp3dEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtLstEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public ExtLstEmpty? ExtLstEmpty
        {
            get => GetElement<ExtLstEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>BwModeEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:bwMode.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public BwModeEmpty? BwModeEmpty
        {
            get => GetElement<BwModeEmpty>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ResetShapeProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the LnRefStyleMatrixReference Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:lnRef.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage &lt;a:scrgbClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelHex &lt;a:srgbClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.HslColor &lt;a:hslClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SystemColor &lt;a:sysClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SchemeColor &lt;a:schemeClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PresetColor &lt;a:prstClr></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "lnRef")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class LnRefStyleMatrixReference : StyleMatrixReferenceType
    {
        /// <summary>
        /// Initializes a new instance of the LnRefStyleMatrixReference class.
        /// </summary>
        public LnRefStyleMatrixReference() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LnRefStyleMatrixReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LnRefStyleMatrixReference(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LnRefStyleMatrixReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LnRefStyleMatrixReference(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LnRefStyleMatrixReference class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LnRefStyleMatrixReference(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "lnRef");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HslColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SystemColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetColor), 1, 1)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LnRefStyleMatrixReference>(deep);
    }

    /// <summary>
    /// <para>Defines the FillRefStyleMatrixReference Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:fillRef.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage &lt;a:scrgbClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelHex &lt;a:srgbClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.HslColor &lt;a:hslClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SystemColor &lt;a:sysClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SchemeColor &lt;a:schemeClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PresetColor &lt;a:prstClr></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "fillRef")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class FillRefStyleMatrixReference : StyleMatrixReferenceType
    {
        /// <summary>
        /// Initializes a new instance of the FillRefStyleMatrixReference class.
        /// </summary>
        public FillRefStyleMatrixReference() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FillRefStyleMatrixReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FillRefStyleMatrixReference(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FillRefStyleMatrixReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FillRefStyleMatrixReference(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FillRefStyleMatrixReference class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public FillRefStyleMatrixReference(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "fillRef");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HslColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SystemColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetColor), 1, 1)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FillRefStyleMatrixReference>(deep);
    }

    /// <summary>
    /// <para>Defines the EffectRefStyleMatrixReference Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:effectRef.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage &lt;a:scrgbClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelHex &lt;a:srgbClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.HslColor &lt;a:hslClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SystemColor &lt;a:sysClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SchemeColor &lt;a:schemeClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PresetColor &lt;a:prstClr></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "effectRef")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class EffectRefStyleMatrixReference : StyleMatrixReferenceType
    {
        /// <summary>
        /// Initializes a new instance of the EffectRefStyleMatrixReference class.
        /// </summary>
        public EffectRefStyleMatrixReference() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EffectRefStyleMatrixReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public EffectRefStyleMatrixReference(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the EffectRefStyleMatrixReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public EffectRefStyleMatrixReference(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the EffectRefStyleMatrixReference class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public EffectRefStyleMatrixReference(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "effectRef");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HslColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SystemColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetColor), 1, 1)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EffectRefStyleMatrixReference>(deep);
    }

    /// <summary>
    /// <para>Defines the StyleMatrixReferenceType Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage &lt;a:scrgbClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelHex &lt;a:srgbClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.HslColor &lt;a:hslClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SystemColor &lt;a:sysClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SchemeColor &lt;a:schemeClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PresetColor &lt;a:prstClr></description></item>
    /// </list>
    /// </remark>
    public abstract partial class StyleMatrixReferenceType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the StyleMatrixReferenceType class.
        /// </summary>
        protected StyleMatrixReferenceType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleMatrixReferenceType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected StyleMatrixReferenceType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleMatrixReferenceType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected StyleMatrixReferenceType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleMatrixReferenceType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected StyleMatrixReferenceType(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Style Matrix Index</para>
        /// <para>Represents the following attribute in the schema: idx</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "idx")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Index
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.HslColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SystemColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SchemeColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PresetColor>();
            builder.AddElement<StyleMatrixReferenceType>()
.AddAttribute(0, "idx", a => a.Index, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <summary>
        /// <para>RGB Color Model - Percentage Variant.</para>
        /// <para>Represents the following element tag in the schema: a:scrgbClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage? RgbColorModelPercentage
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>RGB Color Model - Hex Variant.</para>
        /// <para>Represents the following element tag in the schema: a:srgbClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.RgbColorModelHex? RgbColorModelHex
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Hue, Saturation, Luminance Color Model.</para>
        /// <para>Represents the following element tag in the schema: a:hslClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.HslColor? HslColor
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.HslColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>System Color.</para>
        /// <para>Represents the following element tag in the schema: a:sysClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.SystemColor? SystemColor
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.SystemColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Scheme Color.</para>
        /// <para>Represents the following element tag in the schema: a:schemeClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.SchemeColor? SchemeColor
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.SchemeColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Preset Color.</para>
        /// <para>Represents the following element tag in the schema: a:prstClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.PresetColor? PresetColor
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.PresetColor>();
            set => SetElement(value);
        }
    }

    /// <summary>
    /// <para>Defines the FontReference Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:fontRef.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage &lt;a:scrgbClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelHex &lt;a:srgbClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.HslColor &lt;a:hslClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SystemColor &lt;a:sysClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SchemeColor &lt;a:schemeClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PresetColor &lt;a:prstClr></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "fontRef")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class FontReference : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the FontReference class.
        /// </summary>
        public FontReference() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FontReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FontReference(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FontReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FontReference(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FontReference class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public FontReference(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Identifier</para>
        /// <para>Represents the following attribute in the schema: idx</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "idx")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.FontCollectionIndexValues>? Index
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.FontCollectionIndexValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "fontRef");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.HslColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SystemColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SchemeColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PresetColor>();
            builder.AddElement<FontReference>()
.AddAttribute(0, "idx", a => a.Index, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HslColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SystemColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetColor), 1, 1)
                    }
                }
            };
        }

        /// <summary>
        /// <para>RGB Color Model - Percentage Variant.</para>
        /// <para>Represents the following element tag in the schema: a:scrgbClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage? RgbColorModelPercentage
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>RGB Color Model - Hex Variant.</para>
        /// <para>Represents the following element tag in the schema: a:srgbClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.RgbColorModelHex? RgbColorModelHex
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Hue, Saturation, Luminance Color Model.</para>
        /// <para>Represents the following element tag in the schema: a:hslClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.HslColor? HslColor
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.HslColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>System Color.</para>
        /// <para>Represents the following element tag in the schema: a:sysClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.SystemColor? SystemColor
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.SystemColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Scheme Color.</para>
        /// <para>Represents the following element tag in the schema: a:schemeClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.SchemeColor? SchemeColor
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.SchemeColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Preset Color.</para>
        /// <para>Represents the following element tag in the schema: a:prstClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.PresetColor? PresetColor
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.PresetColor>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FontReference>(deep);
    }

    /// <summary>
    /// <para>Defines the ModifyShapeStyleProps Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:style.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>LnRefStyleMatrixReference &lt;oac:lnRef></description></item>
    ///   <item><description>FillRefStyleMatrixReference &lt;oac:fillRef></description></item>
    ///   <item><description>EffectRefStyleMatrixReference &lt;oac:effectRef></description></item>
    ///   <item><description>FontReference &lt;oac:fontRef></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "style")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ModifyShapeStyleProps : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ModifyShapeStyleProps class.
        /// </summary>
        public ModifyShapeStyleProps() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ModifyShapeStyleProps class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ModifyShapeStyleProps(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ModifyShapeStyleProps class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ModifyShapeStyleProps(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ModifyShapeStyleProps class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ModifyShapeStyleProps(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "style");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<LnRefStyleMatrixReference>();
            builder.AddChild<FillRefStyleMatrixReference>();
            builder.AddChild<EffectRefStyleMatrixReference>();
            builder.AddChild<FontReference>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.LnRefStyleMatrixReference), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.FillRefStyleMatrixReference), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.EffectRefStyleMatrixReference), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.FontReference), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>LnRefStyleMatrixReference.</para>
        /// <para>Represents the following element tag in the schema: oac:lnRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public LnRefStyleMatrixReference? LnRefStyleMatrixReference
        {
            get => GetElement<LnRefStyleMatrixReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>FillRefStyleMatrixReference.</para>
        /// <para>Represents the following element tag in the schema: oac:fillRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public FillRefStyleMatrixReference? FillRefStyleMatrixReference
        {
            get => GetElement<FillRefStyleMatrixReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EffectRefStyleMatrixReference.</para>
        /// <para>Represents the following element tag in the schema: oac:effectRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public EffectRefStyleMatrixReference? EffectRefStyleMatrixReference
        {
            get => GetElement<EffectRefStyleMatrixReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>FontReference.</para>
        /// <para>Represents the following element tag in the schema: oac:fontRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public FontReference? FontReference
        {
            get => GetElement<FontReference>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ModifyShapeStyleProps>(deep);
    }

    /// <summary>
    /// <para>Defines the ResetXsdboolean Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:reset.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "reset")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ResetXsdboolean : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the ResetXsdboolean class.
        /// </summary>
        public ResetXsdboolean() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ResetXsdboolean class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public ResetXsdboolean(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new BooleanValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<BooleanValue>(NumberValidator.Instance);
            builder.SetSchema(87, "reset");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ResetXsdboolean>(deep);
    }

    /// <summary>
    /// <para>Defines the UseBoundsXsdboolean Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:useBounds.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "useBounds")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class UseBoundsXsdboolean : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the UseBoundsXsdboolean class.
        /// </summary>
        public UseBoundsXsdboolean() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the UseBoundsXsdboolean class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public UseBoundsXsdboolean(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new BooleanValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<BooleanValue>(NumberValidator.Instance);
            builder.SetSchema(87, "useBounds");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<UseBoundsXsdboolean>(deep);
    }

    /// <summary>
    /// <para>Defines the BlipFillProperties Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:blipFill.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Blip &lt;a:blip></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SourceRectangle &lt;a:srcRect></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Tile &lt;a:tile></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Stretch &lt;a:stretch></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "blipFill")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class BlipFillProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BlipFillProperties class.
        /// </summary>
        public BlipFillProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BlipFillProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BlipFillProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BlipFillProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BlipFillProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BlipFillProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BlipFillProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>DPI Setting</para>
        /// <para>Represents the following attribute in the schema: dpi</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "dpi")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Dpi
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Rotate With Shape</para>
        /// <para>Represents the following attribute in the schema: rotWithShape</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "rotWithShape")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? RotateWithShape
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "blipFill");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Blip>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SourceRectangle>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Tile>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Stretch>();
            builder.AddElement<BlipFillProperties>()
.AddAttribute(0, "dpi", a => a.Dpi)
.AddAttribute(0, "rotWithShape", a => a.RotateWithShape);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Blip), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SourceRectangle), 0, 1),
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Tile), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Stretch), 1, 1)
                    }
                }
            };
        }

        /// <summary>
        /// <para>Blip.</para>
        /// <para>Represents the following element tag in the schema: a:blip.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Blip? Blip
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Blip>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Source Rectangle.</para>
        /// <para>Represents the following element tag in the schema: a:srcRect.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.SourceRectangle? SourceRectangle
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.SourceRectangle>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BlipFillProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the FillRectRelativeRectProps Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:fillRect.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "fillRect")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class FillRectRelativeRectProps : OpenXmlRelativeRectPropsElement
    {
        /// <summary>
        /// Initializes a new instance of the FillRectRelativeRectProps class.
        /// </summary>
        public FillRectRelativeRectProps() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "fillRect");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FillRectRelativeRectProps>(deep);
    }

    /// <summary>
    /// <para>Defines the SrcRectRelativeRectProps Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:srcRect.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "srcRect")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SrcRectRelativeRectProps : OpenXmlRelativeRectPropsElement
    {
        /// <summary>
        /// Initializes a new instance of the SrcRectRelativeRectProps class.
        /// </summary>
        public SrcRectRelativeRectProps() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "srcRect");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SrcRectRelativeRectProps>(deep);
    }

    /// <summary>
    /// <para>Defines the OpenXmlRelativeRectPropsElement Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class OpenXmlRelativeRectPropsElement : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the OpenXmlRelativeRectPropsElement class.
        /// </summary>
        protected OpenXmlRelativeRectPropsElement() : base()
        {
        }

        /// <summary>
        /// <para>l, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: l</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "l")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? L
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>t, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: t</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "t")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? T
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>r, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: r</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "r")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? R
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>b, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: b</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "b")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? B
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<OpenXmlRelativeRectPropsElement>()
                           .AddAttribute(0, "l", a => a.L)
                           .AddAttribute(0, "t", a => a.T)
                           .AddAttribute(0, "r", a => a.R)
                           .AddAttribute(0, "b", a => a.B);
        }
    }

    /// <summary>
    /// <para>Defines the ResetBlipFillProperties Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:blipFill.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SrcRectEmpty &lt;oac:srcRect></description></item>
    ///   <item><description>FillModeEmpty &lt;oac:fillMode></description></item>
    ///   <item><description>DpiEmpty &lt;oac:dpi></description></item>
    ///   <item><description>RotWithShapeEmpty &lt;oac:rotWithShape></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "blipFill")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ResetBlipFillProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ResetBlipFillProperties class.
        /// </summary>
        public ResetBlipFillProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ResetBlipFillProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ResetBlipFillProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ResetBlipFillProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ResetBlipFillProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ResetBlipFillProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ResetBlipFillProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "blipFill");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<SrcRectEmpty>();
            builder.AddChild<FillModeEmpty>();
            builder.AddChild<DpiEmpty>();
            builder.AddChild<RotWithShapeEmpty>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.SrcRectEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.FillModeEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.DpiEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.RotWithShapeEmpty), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>SrcRectEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:srcRect.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public SrcRectEmpty? SrcRectEmpty
        {
            get => GetElement<SrcRectEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>FillModeEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:fillMode.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public FillModeEmpty? FillModeEmpty
        {
            get => GetElement<FillModeEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DpiEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:dpi.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public DpiEmpty? DpiEmpty
        {
            get => GetElement<DpiEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>RotWithShapeEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:rotWithShape.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public RotWithShapeEmpty? RotWithShapeEmpty
        {
            get => GetElement<RotWithShapeEmpty>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ResetBlipFillProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the ModifyNonVisualGroupDrawingShapeProps Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:cNvGrpSpPr.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "cNvGrpSpPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ModifyNonVisualGroupDrawingShapeProps : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ModifyNonVisualGroupDrawingShapeProps class.
        /// </summary>
        public ModifyNonVisualGroupDrawingShapeProps() : base()
        {
        }

        /// <summary>
        /// <para>noGrp, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noGrp</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noGrp")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoGrp
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noUngrp, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noUngrp</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noUngrp")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoUngrp
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noSelect, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noSelect</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noSelect")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoSelect
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noRot, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noRot</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noRot")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoRot
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noChangeAspect, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noChangeAspect</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noChangeAspect")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoChangeAspect
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noMove, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noMove</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noMove")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoMove
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noResize, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noResize</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noResize")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoResize
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "cNvGrpSpPr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<ModifyNonVisualGroupDrawingShapeProps>()
.AddAttribute(0, "noGrp", a => a.NoGrp)
.AddAttribute(0, "noUngrp", a => a.NoUngrp)
.AddAttribute(0, "noSelect", a => a.NoSelect)
.AddAttribute(0, "noRot", a => a.NoRot)
.AddAttribute(0, "noChangeAspect", a => a.NoChangeAspect)
.AddAttribute(0, "noMove", a => a.NoMove)
.AddAttribute(0, "noResize", a => a.NoResize);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ModifyNonVisualGroupDrawingShapeProps>(deep);
    }

    /// <summary>
    /// <para>Defines the GroupShapeProperties Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:grpSpPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.TransformGroup &lt;a:xfrm></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.NoFill &lt;a:noFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SolidFill &lt;a:solidFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.GradientFill &lt;a:gradFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.BlipFill &lt;a:blipFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PatternFill &lt;a:pattFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.GroupFill &lt;a:grpFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.EffectList &lt;a:effectLst></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.EffectDag &lt;a:effectDag></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Scene3DType &lt;a:scene3d></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "grpSpPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class GroupShapeProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the GroupShapeProperties class.
        /// </summary>
        public GroupShapeProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupShapeProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShapeProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public GroupShapeProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Black and White Mode</para>
        /// <para>Represents the following attribute in the schema: bwMode</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "bwMode")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>? BlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "grpSpPr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.TransformGroup>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NoFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SolidFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GradientFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BlipFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PatternFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GroupFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectDag>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Scene3DType>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            builder.AddElement<GroupShapeProperties>()
.AddAttribute(0, "bwMode", a => a.BlackWhiteMode, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.TransformGroup), 0, 1),
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NoFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SolidFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GradientFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BlipFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PatternFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GroupFill), 1, 1)
                    }
                },
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectList), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectDag), 1, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Scene3DType), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>2D Transform for Grouped Objects.</para>
        /// <para>Represents the following element tag in the schema: a:xfrm.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.TransformGroup? TransformGroup
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.TransformGroup>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GroupShapeProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the ResetGroupShapeProperties Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:grpSpPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>XfrmEmpty &lt;oac:xfrm></description></item>
    ///   <item><description>FillEmpty &lt;oac:fill></description></item>
    ///   <item><description>EffectEmpty &lt;oac:effect></description></item>
    ///   <item><description>Scene3dEmpty &lt;oac:scene3d></description></item>
    ///   <item><description>ExtLstEmpty &lt;oac:extLst></description></item>
    ///   <item><description>BwModeEmpty &lt;oac:bwMode></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "grpSpPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ResetGroupShapeProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ResetGroupShapeProperties class.
        /// </summary>
        public ResetGroupShapeProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ResetGroupShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ResetGroupShapeProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ResetGroupShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ResetGroupShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ResetGroupShapeProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ResetGroupShapeProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "grpSpPr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<XfrmEmpty>();
            builder.AddChild<FillEmpty>();
            builder.AddChild<EffectEmpty>();
            builder.AddChild<Scene3dEmpty>();
            builder.AddChild<ExtLstEmpty>();
            builder.AddChild<BwModeEmpty>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.XfrmEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.FillEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.EffectEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.Scene3dEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.ExtLstEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.BwModeEmpty), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>XfrmEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:xfrm.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public XfrmEmpty? XfrmEmpty
        {
            get => GetElement<XfrmEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>FillEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:fill.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public FillEmpty? FillEmpty
        {
            get => GetElement<FillEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EffectEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:effect.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public EffectEmpty? EffectEmpty
        {
            get => GetElement<EffectEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Scene3dEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:scene3d.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public Scene3dEmpty? Scene3dEmpty
        {
            get => GetElement<Scene3dEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtLstEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public ExtLstEmpty? ExtLstEmpty
        {
            get => GetElement<ExtLstEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>BwModeEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:bwMode.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public BwModeEmpty? BwModeEmpty
        {
            get => GetElement<BwModeEmpty>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ResetGroupShapeProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the NonVisualDrawingProps Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:cNvPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.HyperlinkOnClick &lt;a:hlinkClick></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.HyperlinkOnHover &lt;a:hlinkHover></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "cNvPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class NonVisualDrawingProps : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualDrawingProps class.
        /// </summary>
        public NonVisualDrawingProps() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualDrawingProps class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualDrawingProps(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualDrawingProps class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualDrawingProps(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualDrawingProps class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualDrawingProps(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Application defined unique identifier.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Id
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Name compatible with Object Model (non-unique).</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "name")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Description of the drawing element.</para>
        /// <para>Represents the following attribute in the schema: descr</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "descr")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Flag determining to show or hide this element.</para>
        /// <para>Represents the following attribute in the schema: hidden</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "hidden")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? Hidden
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Title</para>
        /// <para>Represents the following attribute in the schema: title</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "title")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Title
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "cNvPr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnClick>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnHover>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList>();
            builder.AddElement<NonVisualDrawingProps>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "name", a => a.Name, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "descr", a => a.Description)
.AddAttribute(0, "hidden", a => a.Hidden)
.AddAttribute(0, "title", a => a.Title);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HyperlinkOnClick), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HyperlinkOnHover), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Hyperlink associated with clicking or selecting the element..</para>
        /// <para>Represents the following element tag in the schema: a:hlinkClick.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.HyperlinkOnClick? HyperlinkOnClick
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.HyperlinkOnClick>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Hyperlink associated with hovering over the element..</para>
        /// <para>Represents the following element tag in the schema: a:hlinkHover.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.HyperlinkOnHover? HyperlinkOnHover
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.HyperlinkOnHover>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Future extension.</para>
        /// <para>Represents the following element tag in the schema: a:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList? NonVisualDrawingPropertiesExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualDrawingProps>(deep);
    }

    /// <summary>
    /// <para>Defines the NonVisualGroupDrawingShapeProps Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:cNvGrpSpPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.GroupShapeLocks &lt;a:grpSpLocks></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "cNvGrpSpPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class NonVisualGroupDrawingShapeProps : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualGroupDrawingShapeProps class.
        /// </summary>
        public NonVisualGroupDrawingShapeProps() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGroupDrawingShapeProps class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualGroupDrawingShapeProps(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGroupDrawingShapeProps class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualGroupDrawingShapeProps(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGroupDrawingShapeProps class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualGroupDrawingShapeProps(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "cNvGrpSpPr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GroupShapeLocks>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GroupShapeLocks), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>GroupShapeLocks.</para>
        /// <para>Represents the following element tag in the schema: a:grpSpLocks.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.GroupShapeLocks? GroupShapeLocks
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.GroupShapeLocks>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NonVisualGroupDrawingShapePropsExtensionList.</para>
        /// <para>Represents the following element tag in the schema: a:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList? NonVisualGroupDrawingShapePropsExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualGroupDrawingShapeProps>(deep);
    }

    /// <summary>
    /// <para>Defines the ModifyNonVisualGraphicFrameProps Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:cNvGraphicFramePr.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "cNvGraphicFramePr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ModifyNonVisualGraphicFrameProps : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ModifyNonVisualGraphicFrameProps class.
        /// </summary>
        public ModifyNonVisualGraphicFrameProps() : base()
        {
        }

        /// <summary>
        /// <para>noGrp, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noGrp</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noGrp")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoGrp
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noDrilldown, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noDrilldown</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noDrilldown")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoDrilldown
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noSelect, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noSelect</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noSelect")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoSelect
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noChangeAspect, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noChangeAspect</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noChangeAspect")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoChangeAspect
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noMove, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noMove</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noMove")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoMove
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noResize, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noResize</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noResize")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoResize
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "cNvGraphicFramePr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<ModifyNonVisualGraphicFrameProps>()
.AddAttribute(0, "noGrp", a => a.NoGrp)
.AddAttribute(0, "noDrilldown", a => a.NoDrilldown)
.AddAttribute(0, "noSelect", a => a.NoSelect)
.AddAttribute(0, "noChangeAspect", a => a.NoChangeAspect)
.AddAttribute(0, "noMove", a => a.NoMove)
.AddAttribute(0, "noResize", a => a.NoResize);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ModifyNonVisualGraphicFrameProps>(deep);
    }

    /// <summary>
    /// <para>Defines the StCxnConnection Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:stCxn.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "stCxn")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class StCxnConnection : ConnectionType
    {
        /// <summary>
        /// Initializes a new instance of the StCxnConnection class.
        /// </summary>
        public StCxnConnection() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "stCxn");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StCxnConnection>(deep);
    }

    /// <summary>
    /// <para>Defines the EndCxnConnection Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:endCxn.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "endCxn")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class EndCxnConnection : ConnectionType
    {
        /// <summary>
        /// Initializes a new instance of the EndCxnConnection class.
        /// </summary>
        public EndCxnConnection() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "endCxn");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EndCxnConnection>(deep);
    }

    /// <summary>
    /// <para>Defines the ConnectionType Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class ConnectionType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ConnectionType class.
        /// </summary>
        protected ConnectionType() : base()
        {
        }

        /// <summary>
        /// <para>Identifier</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Id
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Index</para>
        /// <para>Represents the following attribute in the schema: idx</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "idx")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Index
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<ConnectionType>()
                           .AddAttribute(0, "id", a => a.Id, aBuilder =>
                           {
                               aBuilder.AddValidator(RequiredValidator.Instance);
                           })
                           .AddAttribute(0, "idx", a => a.Index, aBuilder =>
                           {
                               aBuilder.AddValidator(RequiredValidator.Instance);
                           });
        }
    }

    /// <summary>
    /// <para>Defines the ModifyNonVisualConnectorProps Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:cNvCxnSpPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>StCxnConnection &lt;oac:stCxn></description></item>
    ///   <item><description>EndCxnConnection &lt;oac:endCxn></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "cNvCxnSpPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ModifyNonVisualConnectorProps : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ModifyNonVisualConnectorProps class.
        /// </summary>
        public ModifyNonVisualConnectorProps() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ModifyNonVisualConnectorProps class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ModifyNonVisualConnectorProps(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ModifyNonVisualConnectorProps class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ModifyNonVisualConnectorProps(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ModifyNonVisualConnectorProps class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ModifyNonVisualConnectorProps(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>noGrp, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noGrp</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noGrp")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoGrp
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noSelect, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noSelect</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noSelect")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoSelect
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noRot, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noRot</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noRot")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoRot
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noChangeAspect, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noChangeAspect</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noChangeAspect")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoChangeAspect
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noMove, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noMove</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noMove")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoMove
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noResize, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noResize</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noResize")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoResize
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noEditPoints, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noEditPoints</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noEditPoints")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoEditPoints
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noAdjustHandles, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noAdjustHandles</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noAdjustHandles")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoAdjustHandles
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noChangeArrowheads, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noChangeArrowheads</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noChangeArrowheads")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoChangeArrowheads
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noChangeShapeType, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noChangeShapeType</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noChangeShapeType")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoChangeShapeType
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "cNvCxnSpPr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<StCxnConnection>();
            builder.AddChild<EndCxnConnection>();
            builder.AddElement<ModifyNonVisualConnectorProps>()
.AddAttribute(0, "noGrp", a => a.NoGrp)
.AddAttribute(0, "noSelect", a => a.NoSelect)
.AddAttribute(0, "noRot", a => a.NoRot)
.AddAttribute(0, "noChangeAspect", a => a.NoChangeAspect)
.AddAttribute(0, "noMove", a => a.NoMove)
.AddAttribute(0, "noResize", a => a.NoResize)
.AddAttribute(0, "noEditPoints", a => a.NoEditPoints)
.AddAttribute(0, "noAdjustHandles", a => a.NoAdjustHandles)
.AddAttribute(0, "noChangeArrowheads", a => a.NoChangeArrowheads)
.AddAttribute(0, "noChangeShapeType", a => a.NoChangeShapeType);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.StCxnConnection), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.EndCxnConnection), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>StCxnConnection.</para>
        /// <para>Represents the following element tag in the schema: oac:stCxn.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public StCxnConnection? StCxnConnection
        {
            get => GetElement<StCxnConnection>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EndCxnConnection.</para>
        /// <para>Represents the following element tag in the schema: oac:endCxn.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public EndCxnConnection? EndCxnConnection
        {
            get => GetElement<EndCxnConnection>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ModifyNonVisualConnectorProps>(deep);
    }

    /// <summary>
    /// <para>Defines the ResetNonVisualConnectorProps Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:cNvCxnSpPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>StCxnEmpty &lt;oac:stCxn></description></item>
    ///   <item><description>EndCxnEmpty &lt;oac:endCxn></description></item>
    ///   <item><description>NoGrpEmpty &lt;oac:noGrp></description></item>
    ///   <item><description>NoSelectEmpty &lt;oac:noSelect></description></item>
    ///   <item><description>NoRotEmpty &lt;oac:noRot></description></item>
    ///   <item><description>NoChangeAspectEmpty &lt;oac:noChangeAspect></description></item>
    ///   <item><description>NoMoveEmpty &lt;oac:noMove></description></item>
    ///   <item><description>NoResizeEmpty &lt;oac:noResize></description></item>
    ///   <item><description>NoEditPointsEmpty &lt;oac:noEditPoints></description></item>
    ///   <item><description>NoAdjustHandlesEmpty &lt;oac:noAdjustHandles></description></item>
    ///   <item><description>NoChangeArrowheadsEmpty &lt;oac:noChangeArrowheads></description></item>
    ///   <item><description>NoChangeShapeTypeEmpty &lt;oac:noChangeShapeType></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "cNvCxnSpPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ResetNonVisualConnectorProps : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ResetNonVisualConnectorProps class.
        /// </summary>
        public ResetNonVisualConnectorProps() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ResetNonVisualConnectorProps class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ResetNonVisualConnectorProps(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ResetNonVisualConnectorProps class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ResetNonVisualConnectorProps(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ResetNonVisualConnectorProps class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ResetNonVisualConnectorProps(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "cNvCxnSpPr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<StCxnEmpty>();
            builder.AddChild<EndCxnEmpty>();
            builder.AddChild<NoGrpEmpty>();
            builder.AddChild<NoSelectEmpty>();
            builder.AddChild<NoRotEmpty>();
            builder.AddChild<NoChangeAspectEmpty>();
            builder.AddChild<NoMoveEmpty>();
            builder.AddChild<NoResizeEmpty>();
            builder.AddChild<NoEditPointsEmpty>();
            builder.AddChild<NoAdjustHandlesEmpty>();
            builder.AddChild<NoChangeArrowheadsEmpty>();
            builder.AddChild<NoChangeShapeTypeEmpty>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.StCxnEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.EndCxnEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.NoGrpEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.NoSelectEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.NoRotEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.NoChangeAspectEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.NoMoveEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.NoResizeEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.NoEditPointsEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.NoAdjustHandlesEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.NoChangeArrowheadsEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.NoChangeShapeTypeEmpty), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>StCxnEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:stCxn.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public StCxnEmpty? StCxnEmpty
        {
            get => GetElement<StCxnEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EndCxnEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:endCxn.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public EndCxnEmpty? EndCxnEmpty
        {
            get => GetElement<EndCxnEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NoGrpEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:noGrp.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public NoGrpEmpty? NoGrpEmpty
        {
            get => GetElement<NoGrpEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NoSelectEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:noSelect.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public NoSelectEmpty? NoSelectEmpty
        {
            get => GetElement<NoSelectEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NoRotEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:noRot.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public NoRotEmpty? NoRotEmpty
        {
            get => GetElement<NoRotEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NoChangeAspectEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:noChangeAspect.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public NoChangeAspectEmpty? NoChangeAspectEmpty
        {
            get => GetElement<NoChangeAspectEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NoMoveEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:noMove.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public NoMoveEmpty? NoMoveEmpty
        {
            get => GetElement<NoMoveEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NoResizeEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:noResize.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public NoResizeEmpty? NoResizeEmpty
        {
            get => GetElement<NoResizeEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NoEditPointsEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:noEditPoints.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public NoEditPointsEmpty? NoEditPointsEmpty
        {
            get => GetElement<NoEditPointsEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NoAdjustHandlesEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:noAdjustHandles.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public NoAdjustHandlesEmpty? NoAdjustHandlesEmpty
        {
            get => GetElement<NoAdjustHandlesEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NoChangeArrowheadsEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:noChangeArrowheads.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public NoChangeArrowheadsEmpty? NoChangeArrowheadsEmpty
        {
            get => GetElement<NoChangeArrowheadsEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NoChangeShapeTypeEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:noChangeShapeType.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public NoChangeShapeTypeEmpty? NoChangeShapeTypeEmpty
        {
            get => GetElement<NoChangeShapeTypeEmpty>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ResetNonVisualConnectorProps>(deep);
    }

    /// <summary>
    /// <para>Defines the CompressPictureProps Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:compressPicPr.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "compressPicPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class CompressPictureProps : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the CompressPictureProps class.
        /// </summary>
        public CompressPictureProps() : base()
        {
        }

        /// <summary>
        /// <para>removeCrop, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: removeCrop</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "removeCrop")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? RemoveCrop
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>useLocalDpi, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: useLocalDpi</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "useLocalDpi")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? UseLocalDpi
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>cstate, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: cstate</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "cstate")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.BlipCompressionValues>? Cstate
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.BlipCompressionValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "compressPicPr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<CompressPictureProps>()
.AddAttribute(0, "removeCrop", a => a.RemoveCrop)
.AddAttribute(0, "useLocalDpi", a => a.UseLocalDpi)
.AddAttribute(0, "cstate", a => a.Cstate, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CompressPictureProps>(deep);
    }

    /// <summary>
    /// <para>Defines the ModifyNonVisualPictureProps Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:cNvPicPr.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "cNvPicPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ModifyNonVisualPictureProps : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ModifyNonVisualPictureProps class.
        /// </summary>
        public ModifyNonVisualPictureProps() : base()
        {
        }

        /// <summary>
        /// <para>noGrp, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noGrp</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noGrp")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoGrp
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noSelect, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noSelect</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noSelect")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoSelect
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noRot, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noRot</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noRot")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoRot
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noChangeAspect, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noChangeAspect</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noChangeAspect")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoChangeAspect
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noMove, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noMove</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noMove")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoMove
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noResize, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noResize</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noResize")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoResize
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noEditPoints, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noEditPoints</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noEditPoints")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoEditPoints
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noAdjustHandles, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noAdjustHandles</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noAdjustHandles")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoAdjustHandles
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noChangeArrowheads, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noChangeArrowheads</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noChangeArrowheads")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoChangeArrowheads
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noChangeShapeType, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noChangeShapeType</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noChangeShapeType")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoChangeShapeType
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noCrop, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noCrop</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noCrop")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoCrop
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>preferRelativeResize, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: preferRelativeResize</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "preferRelativeResize")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? PreferRelativeResize
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "cNvPicPr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<ModifyNonVisualPictureProps>()
.AddAttribute(0, "noGrp", a => a.NoGrp)
.AddAttribute(0, "noSelect", a => a.NoSelect)
.AddAttribute(0, "noRot", a => a.NoRot)
.AddAttribute(0, "noChangeAspect", a => a.NoChangeAspect)
.AddAttribute(0, "noMove", a => a.NoMove)
.AddAttribute(0, "noResize", a => a.NoResize)
.AddAttribute(0, "noEditPoints", a => a.NoEditPoints)
.AddAttribute(0, "noAdjustHandles", a => a.NoAdjustHandles)
.AddAttribute(0, "noChangeArrowheads", a => a.NoChangeArrowheads)
.AddAttribute(0, "noChangeShapeType", a => a.NoChangeShapeType)
.AddAttribute(0, "noCrop", a => a.NoCrop)
.AddAttribute(0, "preferRelativeResize", a => a.PreferRelativeResize);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ModifyNonVisualPictureProps>(deep);
    }

    /// <summary>
    /// <para>Defines the ResetNonVisualPictureProps Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:cNvPicPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>LfPrEmpty &lt;oac:lfPr></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "cNvPicPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ResetNonVisualPictureProps : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ResetNonVisualPictureProps class.
        /// </summary>
        public ResetNonVisualPictureProps() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ResetNonVisualPictureProps class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ResetNonVisualPictureProps(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ResetNonVisualPictureProps class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ResetNonVisualPictureProps(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ResetNonVisualPictureProps class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ResetNonVisualPictureProps(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "cNvPicPr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<LfPrEmpty>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.LfPrEmpty), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>LfPrEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:lfPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public LfPrEmpty? LfPrEmpty
        {
            get => GetElement<LfPrEmpty>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ResetNonVisualPictureProps>(deep);
    }

    /// <summary>
    /// <para>Defines the BoundRect Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:bounds.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "bounds")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class BoundRect : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BoundRect class.
        /// </summary>
        public BoundRect() : base()
        {
        }

        /// <summary>
        /// <para>l</para>
        /// <para>Represents the following attribute in the schema: l</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "l")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int64Value? L
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>t</para>
        /// <para>Represents the following attribute in the schema: t</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "t")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int64Value? T
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>r</para>
        /// <para>Represents the following attribute in the schema: r</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "r")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int64Value? R
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>b</para>
        /// <para>Represents the following attribute in the schema: b</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "b")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int64Value? B
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "bounds");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<BoundRect>()
.AddAttribute(0, "l", a => a.L, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
})
.AddAttribute(0, "t", a => a.T, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
})
.AddAttribute(0, "r", a => a.R, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
})
.AddAttribute(0, "b", a => a.B, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BoundRect>(deep);
    }

    /// <summary>
    /// <para>Defines the SVGBlipMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:svgBlipMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "svgBlipMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SVGBlipMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SVGBlipMonikerList class.
        /// </summary>
        public SVGBlipMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SVGBlipMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SVGBlipMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SVGBlipMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SVGBlipMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SVGBlipMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SVGBlipMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "svgBlipMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SVGBlipMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the LinePropertiesType Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:lineProps.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.NoFill &lt;a:noFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SolidFill &lt;a:solidFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.GradientFill &lt;a:gradFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PatternFill &lt;a:pattFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PresetDash &lt;a:prstDash></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.CustomDash &lt;a:custDash></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Round &lt;a:round></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.LineJoinBevel &lt;a:bevel></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Miter &lt;a:miter></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.HeadEnd &lt;a:headEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.TailEnd &lt;a:tailEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "lineProps")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class LinePropertiesType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the LinePropertiesType class.
        /// </summary>
        public LinePropertiesType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LinePropertiesType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LinePropertiesType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LinePropertiesType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LinePropertiesType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LinePropertiesType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LinePropertiesType(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Line Width</para>
        /// <para>Represents the following attribute in the schema: w</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "w")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Width
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Line Ending Cap Type</para>
        /// <para>Represents the following attribute in the schema: cap</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "cap")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.LineCapValues>? CapType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.LineCapValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Compound Line Type</para>
        /// <para>Represents the following attribute in the schema: cmpd</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "cmpd")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.CompoundLineValues>? CompoundLineType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.CompoundLineValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Stroke Alignment</para>
        /// <para>Represents the following attribute in the schema: algn</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "algn")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.PenAlignmentValues>? Alignment
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.PenAlignmentValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "lineProps");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NoFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SolidFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GradientFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PatternFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PresetDash>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.CustomDash>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Round>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.LineJoinBevel>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Miter>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.HeadEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.TailEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            builder.AddElement<LinePropertiesType>()
.AddAttribute(0, "w", a => a.Width, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (20116800L) });
})
.AddAttribute(0, "cap", a => a.CapType, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "cmpd", a => a.CompoundLineType, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "algn", a => a.Alignment, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NoFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SolidFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GradientFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PatternFill), 1, 1)
                    }
                },
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetDash), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.CustomDash), 1, 1)
                    }
                },
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Round), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.LineJoinBevel), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Miter), 1, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HeadEnd), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.TailEnd), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LinePropertiesType>(deep);
    }

    /// <summary>
    /// <para>Defines the ModifyNonVisualInkProps Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:cNvInkPr.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "cNvInkPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ModifyNonVisualInkProps : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ModifyNonVisualInkProps class.
        /// </summary>
        public ModifyNonVisualInkProps() : base()
        {
        }

        /// <summary>
        /// <para>noGrp, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noGrp</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noGrp")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoGrp
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noSelect, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noSelect</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noSelect")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoSelect
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noRot, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noRot</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noRot")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoRot
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noChangeAspect, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noChangeAspect</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noChangeAspect")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoChangeAspect
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noMove, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noMove</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noMove")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoMove
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noResize, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noResize</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noResize")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoResize
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noEditPoints, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noEditPoints</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noEditPoints")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoEditPoints
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noAdjustHandles, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noAdjustHandles</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noAdjustHandles")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoAdjustHandles
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noChangeArrowheads, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noChangeArrowheads</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noChangeArrowheads")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoChangeArrowheads
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noChangeShapeType, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noChangeShapeType</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "noChangeShapeType")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoChangeShapeType
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>isComment, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: isComment</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "isComment")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? IsComment
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "cNvInkPr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<ModifyNonVisualInkProps>()
.AddAttribute(0, "noGrp", a => a.NoGrp)
.AddAttribute(0, "noSelect", a => a.NoSelect)
.AddAttribute(0, "noRot", a => a.NoRot)
.AddAttribute(0, "noChangeAspect", a => a.NoChangeAspect)
.AddAttribute(0, "noMove", a => a.NoMove)
.AddAttribute(0, "noResize", a => a.NoResize)
.AddAttribute(0, "noEditPoints", a => a.NoEditPoints)
.AddAttribute(0, "noAdjustHandles", a => a.NoAdjustHandles)
.AddAttribute(0, "noChangeArrowheads", a => a.NoChangeArrowheads)
.AddAttribute(0, "noChangeShapeType", a => a.NoChangeShapeType)
.AddAttribute(0, "isComment", a => a.IsComment);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ModifyNonVisualInkProps>(deep);
    }

    /// <summary>
    /// <para>Defines the HlinkClickHyperlinkProps Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:hlinkClick.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SndDataImgData &lt;oac:sndData></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "hlinkClick")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class HlinkClickHyperlinkProps : OpenXmlHyperlinkPropsElement
    {
        /// <summary>
        /// Initializes a new instance of the HlinkClickHyperlinkProps class.
        /// </summary>
        public HlinkClickHyperlinkProps() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the HlinkClickHyperlinkProps class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HlinkClickHyperlinkProps(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the HlinkClickHyperlinkProps class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HlinkClickHyperlinkProps(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the HlinkClickHyperlinkProps class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public HlinkClickHyperlinkProps(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "hlinkClick");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.SndDataImgData), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HlinkClickHyperlinkProps>(deep);
    }

    /// <summary>
    /// <para>Defines the HlinkHoverHyperlinkProps Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:hlinkHover.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SndDataImgData &lt;oac:sndData></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "hlinkHover")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class HlinkHoverHyperlinkProps : OpenXmlHyperlinkPropsElement
    {
        /// <summary>
        /// Initializes a new instance of the HlinkHoverHyperlinkProps class.
        /// </summary>
        public HlinkHoverHyperlinkProps() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the HlinkHoverHyperlinkProps class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HlinkHoverHyperlinkProps(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the HlinkHoverHyperlinkProps class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HlinkHoverHyperlinkProps(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the HlinkHoverHyperlinkProps class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public HlinkHoverHyperlinkProps(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "hlinkHover");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.SndDataImgData), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HlinkHoverHyperlinkProps>(deep);
    }

    /// <summary>
    /// <para>Defines the OpenXmlHyperlinkPropsElement Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SndDataImgData &lt;oac:sndData></description></item>
    /// </list>
    /// </remark>
    public abstract partial class OpenXmlHyperlinkPropsElement : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OpenXmlHyperlinkPropsElement class.
        /// </summary>
        protected OpenXmlHyperlinkPropsElement() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlHyperlinkPropsElement class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected OpenXmlHyperlinkPropsElement(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlHyperlinkPropsElement class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected OpenXmlHyperlinkPropsElement(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlHyperlinkPropsElement class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected OpenXmlHyperlinkPropsElement(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>source, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: source</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "source")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Source
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>action, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: action</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "action")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Action
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tgtFrame, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: tgtFrame</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "tgtFrame")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? TgtFrame
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tooltip, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: tooltip</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "tooltip")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Tooltip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>highlightClick, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: highlightClick</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "highlightClick")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? HighlightClick
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>endSnd, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: endSnd</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "endSnd")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? EndSnd
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sndName, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: sndName</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "sndName")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? SndName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<SndDataImgData>();
            builder.AddElement<OpenXmlHyperlinkPropsElement>()
.AddAttribute(0, "source", a => a.Source)
.AddAttribute(0, "action", a => a.Action)
.AddAttribute(0, "tgtFrame", a => a.TgtFrame)
.AddAttribute(0, "tooltip", a => a.Tooltip)
.AddAttribute(0, "highlightClick", a => a.HighlightClick)
.AddAttribute(0, "endSnd", a => a.EndSnd)
.AddAttribute(0, "sndName", a => a.SndName);
        }

        /// <summary>
        /// <para>SndDataImgData.</para>
        /// <para>Represents the following element tag in the schema: oac:sndData.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public SndDataImgData? SndDataImgData
        {
            get => GetElement<SndDataImgData>();
            set => SetElement(value);
        }
    }

    /// <summary>
    /// <para>Defines the ModifyHyperlinkProps Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:hlink.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>HlinkClickHyperlinkProps &lt;oac:hlinkClick></description></item>
    ///   <item><description>HlinkHoverHyperlinkProps &lt;oac:hlinkHover></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "hlink")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ModifyHyperlinkProps : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ModifyHyperlinkProps class.
        /// </summary>
        public ModifyHyperlinkProps() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ModifyHyperlinkProps class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ModifyHyperlinkProps(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ModifyHyperlinkProps class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ModifyHyperlinkProps(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ModifyHyperlinkProps class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ModifyHyperlinkProps(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "hlink");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<HlinkClickHyperlinkProps>();
            builder.AddChild<HlinkHoverHyperlinkProps>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.HlinkClickHyperlinkProps), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.HlinkHoverHyperlinkProps), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>HlinkClickHyperlinkProps.</para>
        /// <para>Represents the following element tag in the schema: oac:hlinkClick.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public HlinkClickHyperlinkProps? HlinkClickHyperlinkProps
        {
            get => GetElement<HlinkClickHyperlinkProps>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>HlinkHoverHyperlinkProps.</para>
        /// <para>Represents the following element tag in the schema: oac:hlinkHover.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public HlinkHoverHyperlinkProps? HlinkHoverHyperlinkProps
        {
            get => GetElement<HlinkHoverHyperlinkProps>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ModifyHyperlinkProps>(deep);
    }

    /// <summary>
    /// <para>Defines the ResetHyperlinkProps Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:hlink.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>HlinkClickEmpty &lt;oac:hlinkClick></description></item>
    ///   <item><description>HlinkHoverEmpty &lt;oac:hlinkHover></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "hlink")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ResetHyperlinkProps : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ResetHyperlinkProps class.
        /// </summary>
        public ResetHyperlinkProps() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ResetHyperlinkProps class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ResetHyperlinkProps(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ResetHyperlinkProps class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ResetHyperlinkProps(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ResetHyperlinkProps class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ResetHyperlinkProps(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "hlink");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<HlinkClickEmpty>();
            builder.AddChild<HlinkHoverEmpty>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.HlinkClickEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.HlinkHoverEmpty), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>HlinkClickEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:hlinkClick.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public HlinkClickEmpty? HlinkClickEmpty
        {
            get => GetElement<HlinkClickEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>HlinkHoverEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:hlinkHover.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public HlinkHoverEmpty? HlinkHoverEmpty
        {
            get => GetElement<HlinkHoverEmpty>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ResetHyperlinkProps>(deep);
    }

    /// <summary>
    /// <para>Defines the TextCharRangeContext Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:context.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "context")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class TextCharRangeContext : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TextCharRangeContext class.
        /// </summary>
        public TextCharRangeContext() : base()
        {
        }

        /// <summary>
        /// <para>len, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: len</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "len")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Len
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>hash, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: hash</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "hash")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Hash
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "context");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<TextCharRangeContext>()
.AddAttribute(0, "len", a => a.Len)
.AddAttribute(0, "hash", a => a.Hash, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextCharRangeContext>(deep);
    }

    /// <summary>
    /// Defines the ResourceLinkage enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2016)]
    public enum ResourceLinkage
    {
        ///<summary>
        ///embed.
        ///<para>When the item is serialized out as xml, its value is "embed".</para>
        ///</summary>
        [EnumString("embed")]
        Embed,
        ///<summary>
        ///link.
        ///<para>When the item is serialized out as xml, its value is "link".</para>
        ///</summary>
        [EnumString("link")]
        Link,
        ///<summary>
        ///linkAndEmbed.
        ///<para>When the item is serialized out as xml, its value is "linkAndEmbed".</para>
        ///</summary>
        [EnumString("linkAndEmbed")]
        LinkAndEmbed,
    }

    /// <summary>
    /// Defines the DetachConnection enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2016)]
    public enum DetachConnection
    {
        ///<summary>
        ///start.
        ///<para>When the item is serialized out as xml, its value is "start".</para>
        ///</summary>
        [EnumString("start")]
        Start,
        ///<summary>
        ///end.
        ///<para>When the item is serialized out as xml, its value is "end".</para>
        ///</summary>
        [EnumString("end")]
        End,
        ///<summary>
        ///both.
        ///<para>When the item is serialized out as xml, its value is "both".</para>
        ///</summary>
        [EnumString("both")]
        Both,
    }
}