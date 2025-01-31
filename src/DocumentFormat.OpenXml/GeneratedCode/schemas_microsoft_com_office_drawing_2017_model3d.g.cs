﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Office2019.Drawing;
using DocumentFormat.OpenXml.Office2019.Drawing.Animation.Model3D;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2019.Drawing.Model3D
{
    /// <summary>
    /// <para>Defines the Model3D Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:model3D.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ShapeProperties &lt;am3d:spPr></description></item>
    ///   <item><description>Model3DCamera &lt;am3d:camera></description></item>
    ///   <item><description>Model3DTransform &lt;am3d:trans></description></item>
    ///   <item><description>PictureAttributionSourceURL &lt;am3d:attrSrcUrl></description></item>
    ///   <item><description>Model3DRaster &lt;am3d:raster></description></item>
    ///   <item><description>Model3DExtensionList &lt;am3d:extLst></description></item>
    ///   <item><description>ObjectViewport &lt;am3d:objViewport></description></item>
    ///   <item><description>WindowViewport &lt;am3d:winViewport></description></item>
    ///   <item><description>AmbientLight &lt;am3d:ambientLight></description></item>
    ///   <item><description>PointLight &lt;am3d:ptLight></description></item>
    ///   <item><description>SpotLight &lt;am3d:spotLight></description></item>
    ///   <item><description>DirectionalLight &lt;am3d:dirLight></description></item>
    ///   <item><description>UnknownLight &lt;am3d:unkLight></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(111, "model3D")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Model3D : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Model3D class.
        /// </summary>
        public Model3D() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model3D class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Model3D(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model3D class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Model3D(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model3D class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Model3D(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Embedded Picture Reference</para>
        /// <para>Represents the following attribute in the schema: r:embed</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(19, "embed")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Embed
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Linked Picture Reference</para>
        /// <para>Represents the following attribute in the schema: r:link</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(19, "link")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Link
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(111, "model3D");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<ShapeProperties>();
            builder.AddChild<Model3DCamera>();
            builder.AddChild<Model3DTransform>();
            builder.AddChild<PictureAttributionSourceURL>();
            builder.AddChild<Model3DRaster>();
            builder.AddChild<Model3DExtensionList>();
            builder.AddChild<ObjectViewport>();
            builder.AddChild<WindowViewport>();
            builder.AddChild<AmbientLight>();
            builder.AddChild<PointLight>();
            builder.AddChild<SpotLight>();
            builder.AddChild<DirectionalLight>();
            builder.AddChild<UnknownLight>();
            builder.AddElement<Model3D>()
.AddAttribute(19, "embed", a => a.Embed)
.AddAttribute(19, "link", a => a.Link);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.ShapeProperties), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Model3DCamera), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Model3DTransform), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PictureAttributionSourceURL), 0, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Model3DRaster), 0, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Model3DExtensionList), 0, 1, version: FileFormatVersions.Office2019),
                new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.ObjectViewport), 1, 1, version: FileFormatVersions.Office2019),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.WindowViewport), 1, 1, version: FileFormatVersions.Office2019)
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.AmbientLight), 0, 1, version: FileFormatVersions.Office2019),
                new CompositeParticle.Builder(ParticleType.Choice, 0, 0)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PointLight), 1, 1, version: FileFormatVersions.Office2019),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.SpotLight), 1, 1, version: FileFormatVersions.Office2019),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.DirectionalLight), 1, 1, version: FileFormatVersions.Office2019),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.UnknownLight), 1, 1, version: FileFormatVersions.Office2019)
                }
            };
        }

        /// <summary>
        /// <para>ShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: am3d:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public ShapeProperties? ShapeProperties
        {
            get => GetElement<ShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Model3DCamera.</para>
        /// <para>Represents the following element tag in the schema: am3d:camera.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public Model3DCamera? Model3DCamera
        {
            get => GetElement<Model3DCamera>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Model3DTransform.</para>
        /// <para>Represents the following element tag in the schema: am3d:trans.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public Model3DTransform? Model3DTransform
        {
            get => GetElement<Model3DTransform>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Optional source attribution URL describes from whence the 3D model came..</para>
        /// <para>Represents the following element tag in the schema: am3d:attrSrcUrl.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public PictureAttributionSourceURL? PictureAttributionSourceURL
        {
            get => GetElement<PictureAttributionSourceURL>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Model3DRaster.</para>
        /// <para>Represents the following element tag in the schema: am3d:raster.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public Model3DRaster? Model3DRaster
        {
            get => GetElement<Model3DRaster>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Future Model3D extensions.</para>
        /// <para>Represents the following element tag in the schema: am3d:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public Model3DExtensionList? Model3DExtensionList
        {
            get => GetElement<Model3DExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Model3D>(deep);
    }

    /// <summary>
    /// <para>Defines the SxRatio Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:sx.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(111, "sx")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SxRatio : RatioType
    {
        /// <summary>
        /// Initializes a new instance of the SxRatio class.
        /// </summary>
        public SxRatio() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(111, "sx");
            builder.Availability = FileFormatVersions.Office2019;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SxRatio>(deep);
    }

    /// <summary>
    /// <para>Defines the SyRatio Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:sy.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(111, "sy")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SyRatio : RatioType
    {
        /// <summary>
        /// Initializes a new instance of the SyRatio class.
        /// </summary>
        public SyRatio() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(111, "sy");
            builder.Availability = FileFormatVersions.Office2019;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SyRatio>(deep);
    }

    /// <summary>
    /// <para>Defines the SzRatio Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:sz.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(111, "sz")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SzRatio : RatioType
    {
        /// <summary>
        /// Initializes a new instance of the SzRatio class.
        /// </summary>
        public SzRatio() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(111, "sz");
            builder.Availability = FileFormatVersions.Office2019;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SzRatio>(deep);
    }

    /// <summary>
    /// <para>Defines the RatioType Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class RatioType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RatioType class.
        /// </summary>
        protected RatioType() : base()
        {
        }

        /// <summary>
        /// <para>Numerator</para>
        /// <para>Represents the following attribute in the schema: n</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "n")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Numerator
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Denominator</para>
        /// <para>Represents the following attribute in the schema: d</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "d")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Denominator
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<RatioType>()
                           .AddAttribute(0, "n", a => a.Numerator, aBuilder =>
                           {
                               aBuilder.AddValidator(RequiredValidator.Instance);
                           })
                           .AddAttribute(0, "d", a => a.Denominator, aBuilder =>
                           {
                               aBuilder.AddValidator(RequiredValidator.Instance);
                           });
        }
    }

    /// <summary>
    /// <para>Defines the MeterPerModelUnitPositiveRatio Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:meterPerModelUnit.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(111, "meterPerModelUnit")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class MeterPerModelUnitPositiveRatio : OpenXmlPositiveRatioElement
    {
        /// <summary>
        /// Initializes a new instance of the MeterPerModelUnitPositiveRatio class.
        /// </summary>
        public MeterPerModelUnitPositiveRatio() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(111, "meterPerModelUnit");
            builder.Availability = FileFormatVersions.Office2019;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MeterPerModelUnitPositiveRatio>(deep);
    }

    /// <summary>
    /// <para>Defines the SzPositiveRatio Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:sz.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(111, "sz")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SzPositiveRatio : OpenXmlPositiveRatioElement
    {
        /// <summary>
        /// Initializes a new instance of the SzPositiveRatio class.
        /// </summary>
        public SzPositiveRatio() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(111, "sz");
            builder.Availability = FileFormatVersions.Office2019;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SzPositiveRatio>(deep);
    }

    /// <summary>
    /// <para>Defines the IlluminancePositiveRatio Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:illuminance.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(111, "illuminance")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class IlluminancePositiveRatio : OpenXmlPositiveRatioElement
    {
        /// <summary>
        /// Initializes a new instance of the IlluminancePositiveRatio class.
        /// </summary>
        public IlluminancePositiveRatio() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(111, "illuminance");
            builder.Availability = FileFormatVersions.Office2019;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<IlluminancePositiveRatio>(deep);
    }

    /// <summary>
    /// <para>Defines the IntensityPositiveRatio Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:intensity.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(111, "intensity")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class IntensityPositiveRatio : OpenXmlPositiveRatioElement
    {
        /// <summary>
        /// Initializes a new instance of the IntensityPositiveRatio class.
        /// </summary>
        public IntensityPositiveRatio() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(111, "intensity");
            builder.Availability = FileFormatVersions.Office2019;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<IntensityPositiveRatio>(deep);
    }

    /// <summary>
    /// <para>Defines the OpenXmlPositiveRatioElement Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class OpenXmlPositiveRatioElement : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the OpenXmlPositiveRatioElement class.
        /// </summary>
        protected OpenXmlPositiveRatioElement() : base()
        {
        }

        /// <summary>
        /// <para>n, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: n</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "n")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt64Value? N
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>d, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: d</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "d")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt64Value? D
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<OpenXmlPositiveRatioElement>()
                           .AddAttribute(0, "n", a => a.N, aBuilder =>
                           {
                               aBuilder.AddValidator(RequiredValidator.Instance);
                           })
                           .AddAttribute(0, "d", a => a.D, aBuilder =>
                           {
                               aBuilder.AddValidator(RequiredValidator.Instance);
                           });
        }
    }

    /// <summary>
    /// <para>Defines the PreTransVector3D Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:preTrans.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(111, "preTrans")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class PreTransVector3D : Vector3DType
    {
        /// <summary>
        /// Initializes a new instance of the PreTransVector3D class.
        /// </summary>
        public PreTransVector3D() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(111, "preTrans");
            builder.Availability = FileFormatVersions.Office2019;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PreTransVector3D>(deep);
    }

    /// <summary>
    /// <para>Defines the PostTransVector3D Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:postTrans.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(111, "postTrans")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class PostTransVector3D : Vector3DType
    {
        /// <summary>
        /// Initializes a new instance of the PostTransVector3D class.
        /// </summary>
        public PostTransVector3D() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(111, "postTrans");
            builder.Availability = FileFormatVersions.Office2019;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PostTransVector3D>(deep);
    }

    /// <summary>
    /// <para>Defines the UpVector3D Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:up.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(111, "up")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class UpVector3D : Vector3DType
    {
        /// <summary>
        /// Initializes a new instance of the UpVector3D class.
        /// </summary>
        public UpVector3D() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(111, "up");
            builder.Availability = FileFormatVersions.Office2019;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<UpVector3D>(deep);
    }

    /// <summary>
    /// <para>Defines the Vector3DType Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class Vector3DType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Vector3DType class.
        /// </summary>
        protected Vector3DType() : base()
        {
        }

        /// <summary>
        /// <para>Distance along X-axis in 3D</para>
        /// <para>Represents the following attribute in the schema: dx</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "dx")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int64Value? Dx
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Distance along Y-axis in 3D</para>
        /// <para>Represents the following attribute in the schema: dy</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "dy")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int64Value? Dy
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Distance along Z-axis in 3D</para>
        /// <para>Represents the following attribute in the schema: dz</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "dz")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int64Value? Dz
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<Vector3DType>()
                           .AddAttribute(0, "dx", a => a.Dx, aBuilder =>
                           {
                               aBuilder.AddValidator(RequiredValidator.Instance);
                               aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
                           })
                           .AddAttribute(0, "dy", a => a.Dy, aBuilder =>
                           {
                               aBuilder.AddValidator(RequiredValidator.Instance);
                               aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
                           })
                           .AddAttribute(0, "dz", a => a.Dz, aBuilder =>
                           {
                               aBuilder.AddValidator(RequiredValidator.Instance);
                               aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
                           });
        }
    }

    /// <summary>
    /// <para>Defines the Scale3D Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:scale.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SxRatio &lt;am3d:sx></description></item>
    ///   <item><description>SyRatio &lt;am3d:sy></description></item>
    ///   <item><description>SzRatio &lt;am3d:sz></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(111, "scale")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Scale3D : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Scale3D class.
        /// </summary>
        public Scale3D() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Scale3D class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Scale3D(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Scale3D class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Scale3D(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Scale3D class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Scale3D(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(111, "scale");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<SxRatio>();
            builder.AddChild<SyRatio>();
            builder.AddChild<SzRatio>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.SxRatio), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.SyRatio), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.SzRatio), 1, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>SxRatio.</para>
        /// <para>Represents the following element tag in the schema: am3d:sx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public SxRatio? SxRatio
        {
            get => GetElement<SxRatio>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>SyRatio.</para>
        /// <para>Represents the following element tag in the schema: am3d:sy.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public SyRatio? SyRatio
        {
            get => GetElement<SyRatio>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>SzRatio.</para>
        /// <para>Represents the following element tag in the schema: am3d:sz.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public SzRatio? SzRatio
        {
            get => GetElement<SzRatio>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Scale3D>(deep);
    }

    /// <summary>
    /// <para>Defines the Rotate3D Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:rot.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(111, "rot")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Rotate3D : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Rotate3D class.
        /// </summary>
        public Rotate3D() : base()
        {
        }

        /// <summary>
        /// <para>ax, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: ax</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "ax")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Ax
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ay, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: ay</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "ay")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Ay
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>az, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: az</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "az")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Az
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(111, "rot");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddElement<Rotate3D>()
.AddAttribute(0, "ax", a => a.Ax)
.AddAttribute(0, "ay", a => a.Ay)
.AddAttribute(0, "az", a => a.Az);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Rotate3D>(deep);
    }

    /// <summary>
    /// <para>Defines the OfficeArtExtensionList Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Extension &lt;a:ext></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(111, "extLst")]
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
            builder.SetSchema(111, "extLst");
            builder.Availability = FileFormatVersions.Office2019;
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

    /// <summary>
    /// <para>Defines the PosPoint3D Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:pos.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(111, "pos")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class PosPoint3D : OpenXmlPoint3DElement
    {
        /// <summary>
        /// Initializes a new instance of the PosPoint3D class.
        /// </summary>
        public PosPoint3D() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(111, "pos");
            builder.Availability = FileFormatVersions.Office2019;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PosPoint3D>(deep);
    }

    /// <summary>
    /// <para>Defines the LookAtPoint3D Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:lookAt.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(111, "lookAt")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class LookAtPoint3D : OpenXmlPoint3DElement
    {
        /// <summary>
        /// Initializes a new instance of the LookAtPoint3D class.
        /// </summary>
        public LookAtPoint3D() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(111, "lookAt");
            builder.Availability = FileFormatVersions.Office2019;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LookAtPoint3D>(deep);
    }

    /// <summary>
    /// <para>Defines the OpenXmlPoint3DElement Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class OpenXmlPoint3DElement : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the OpenXmlPoint3DElement class.
        /// </summary>
        protected OpenXmlPoint3DElement() : base()
        {
        }

        /// <summary>
        /// <para>X-Coordinate in 3D</para>
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
        /// <para>Y-Coordinate in 3D</para>
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
        /// <para>Z-Coordinate in 3D</para>
        /// <para>Represents the following attribute in the schema: z</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "z")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int64Value? Z
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<OpenXmlPoint3DElement>()
                           .AddAttribute(0, "x", a => a.X, aBuilder =>
                           {
                               aBuilder.AddValidator(RequiredValidator.Instance);
                               aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
                           })
                           .AddAttribute(0, "y", a => a.Y, aBuilder =>
                           {
                               aBuilder.AddValidator(RequiredValidator.Instance);
                               aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
                           })
                           .AddAttribute(0, "z", a => a.Z, aBuilder =>
                           {
                               aBuilder.AddValidator(RequiredValidator.Instance);
                               aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
                           });
        }
    }

    /// <summary>
    /// <para>Defines the OrthographicProjection Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:orthographic.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SzPositiveRatio &lt;am3d:sz></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;am3d:extLst></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(111, "orthographic")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class OrthographicProjection : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OrthographicProjection class.
        /// </summary>
        public OrthographicProjection() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OrthographicProjection class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OrthographicProjection(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OrthographicProjection class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OrthographicProjection(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OrthographicProjection class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public OrthographicProjection(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(111, "orthographic");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<SzPositiveRatio>();
            builder.AddChild<OfficeArtExtensionList>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.SzPositiveRatio), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>SzPositiveRatio.</para>
        /// <para>Represents the following element tag in the schema: am3d:sz.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public SzPositiveRatio? SzPositiveRatio
        {
            get => GetElement<SzPositiveRatio>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: am3d:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public OfficeArtExtensionList? OfficeArtExtensionList
        {
            get => GetElement<OfficeArtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OrthographicProjection>(deep);
    }

    /// <summary>
    /// <para>Defines the PerspectiveProjection Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:perspective.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>OfficeArtExtensionList &lt;am3d:extLst></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(111, "perspective")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class PerspectiveProjection : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PerspectiveProjection class.
        /// </summary>
        public PerspectiveProjection() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PerspectiveProjection class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PerspectiveProjection(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PerspectiveProjection class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PerspectiveProjection(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PerspectiveProjection class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PerspectiveProjection(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>fov, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: fov</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "fov")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Fov
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(111, "perspective");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<OfficeArtExtensionList>();
            builder.AddElement<PerspectiveProjection>()
.AddAttribute(0, "fov", a => a.Fov, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (10800000L) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: am3d:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public OfficeArtExtensionList? OfficeArtExtensionList
        {
            get => GetElement<OfficeArtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PerspectiveProjection>(deep);
    }

    /// <summary>
    /// <para>Defines the Blip Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:blip.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.AlphaBiLevel &lt;a:alphaBiLevel></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.AlphaCeiling &lt;a:alphaCeiling></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.AlphaFloor &lt;a:alphaFloor></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.AlphaInverse &lt;a:alphaInv></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.AlphaModulationEffect &lt;a:alphaMod></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.AlphaModulationFixed &lt;a:alphaModFix></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.AlphaReplace &lt;a:alphaRepl></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.BiLevel &lt;a:biLevel></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Blur &lt;a:blur></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ColorChange &lt;a:clrChange></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ColorReplacement &lt;a:clrRepl></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Duotone &lt;a:duotone></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.FillOverlay &lt;a:fillOverlay></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Grayscale &lt;a:grayscl></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Hsl &lt;a:hsl></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.LuminanceEffect &lt;a:lum></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.TintEffect &lt;a:tint></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.BlipExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(111, "blip")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Blip : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Blip class.
        /// </summary>
        public Blip() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Blip class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Blip(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Blip class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Blip(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Blip class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Blip(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Embedded Picture Reference</para>
        /// <para>Represents the following attribute in the schema: r:embed</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(19, "embed")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Embed
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Linked Picture Reference</para>
        /// <para>Represents the following attribute in the schema: r:link</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(19, "link")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Link
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Compression state for blips.</para>
        /// <para>Represents the following attribute in the schema: cstate</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "cstate")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.BlipCompressionValues>? CompressionState
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.BlipCompressionValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(111, "blip");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.AlphaBiLevel>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.AlphaCeiling>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.AlphaFloor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.AlphaInverse>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.AlphaModulationEffect>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.AlphaModulationFixed>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.AlphaReplace>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BiLevel>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Blur>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ColorChange>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ColorReplacement>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Duotone>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.FillOverlay>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Grayscale>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Hsl>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.LuminanceEffect>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.TintEffect>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BlipExtensionList>();
            builder.AddElement<Blip>()
.AddAttribute(19, "embed", a => a.Embed)
.AddAttribute(19, "link", a => a.Link)
.AddAttribute(0, "cstate", a => a.CompressionState, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Choice, 0, 0)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.AlphaBiLevel), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.AlphaCeiling), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.AlphaFloor), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.AlphaInverse), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.AlphaModulationEffect), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.AlphaModulationFixed), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.AlphaReplace), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BiLevel), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Blur), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ColorChange), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ColorReplacement), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Duotone), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.FillOverlay), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Grayscale), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Hsl), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.LuminanceEffect), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.TintEffect), 1, 1)
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BlipExtensionList), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Blip>(deep);
    }

    /// <summary>
    /// <para>Defines the ColorType Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:clr.</para>
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
    [SchemaAttr(111, "clr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ColorType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ColorType class.
        /// </summary>
        public ColorType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ColorType(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(111, "clr");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.HslColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SystemColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SchemeColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PresetColor>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
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
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorType>(deep);
    }

    /// <summary>
    /// <para>Defines the Model3DExtension Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2019.Drawing.Animation.Model3D.EmbeddedAnimation &lt;a3danim:embedAnim></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2019.Drawing.Animation.Model3D.PosterFrame &lt;a3danim:posterFrame></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(111, "ext")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Model3DExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Model3DExtension class.
        /// </summary>
        public Model3DExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model3DExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Model3DExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model3DExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Model3DExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model3DExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Model3DExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "uri")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Uri
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(111, "ext");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Animation.Model3D.EmbeddedAnimation>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Animation.Model3D.PosterFrame>();
            builder.AddElement<Model3DExtension>()
.AddAttribute(0, "uri", a => a.Uri, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Animation.Model3D.EmbeddedAnimation), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Animation.Model3D.PosterFrame), 1, 1, version: FileFormatVersions.Office2019),
                new AnyParticle(0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Model3DExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the ShapeProperties Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:spPr.</para>
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
    [SchemaAttr(111, "spPr")]
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
            builder.SetSchema(111, "spPr");
            builder.Availability = FileFormatVersions.Office2019;
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
    /// <para>Defines the Model3DCamera Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:camera.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>PosPoint3D &lt;am3d:pos></description></item>
    ///   <item><description>UpVector3D &lt;am3d:up></description></item>
    ///   <item><description>LookAtPoint3D &lt;am3d:lookAt></description></item>
    ///   <item><description>OrthographicProjection &lt;am3d:orthographic></description></item>
    ///   <item><description>PerspectiveProjection &lt;am3d:perspective></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;am3d:extLst></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(111, "camera")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Model3DCamera : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Model3DCamera class.
        /// </summary>
        public Model3DCamera() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model3DCamera class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Model3DCamera(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model3DCamera class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Model3DCamera(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model3DCamera class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Model3DCamera(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(111, "camera");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<PosPoint3D>();
            builder.AddChild<UpVector3D>();
            builder.AddChild<LookAtPoint3D>();
            builder.AddChild<OrthographicProjection>();
            builder.AddChild<PerspectiveProjection>();
            builder.AddChild<OfficeArtExtensionList>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PosPoint3D), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.UpVector3D), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.LookAtPoint3D), 1, 1, version: FileFormatVersions.Office2019),
                new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OrthographicProjection), 1, 1, version: FileFormatVersions.Office2019),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PerspectiveProjection), 1, 1, version: FileFormatVersions.Office2019)
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>PosPoint3D.</para>
        /// <para>Represents the following element tag in the schema: am3d:pos.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public PosPoint3D? PosPoint3D
        {
            get => GetElement<PosPoint3D>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>UpVector3D.</para>
        /// <para>Represents the following element tag in the schema: am3d:up.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public UpVector3D? UpVector3D
        {
            get => GetElement<UpVector3D>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>LookAtPoint3D.</para>
        /// <para>Represents the following element tag in the schema: am3d:lookAt.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public LookAtPoint3D? LookAtPoint3D
        {
            get => GetElement<LookAtPoint3D>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Model3DCamera>(deep);
    }

    /// <summary>
    /// <para>Defines the Model3DTransform Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:trans.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>MeterPerModelUnitPositiveRatio &lt;am3d:meterPerModelUnit></description></item>
    ///   <item><description>PreTransVector3D &lt;am3d:preTrans></description></item>
    ///   <item><description>Scale3D &lt;am3d:scale></description></item>
    ///   <item><description>Rotate3D &lt;am3d:rot></description></item>
    ///   <item><description>PostTransVector3D &lt;am3d:postTrans></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;am3d:extLst></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(111, "trans")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Model3DTransform : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Model3DTransform class.
        /// </summary>
        public Model3DTransform() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model3DTransform class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Model3DTransform(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model3DTransform class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Model3DTransform(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model3DTransform class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Model3DTransform(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(111, "trans");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<MeterPerModelUnitPositiveRatio>();
            builder.AddChild<PreTransVector3D>();
            builder.AddChild<Scale3D>();
            builder.AddChild<Rotate3D>();
            builder.AddChild<PostTransVector3D>();
            builder.AddChild<OfficeArtExtensionList>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.MeterPerModelUnitPositiveRatio), 0, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PreTransVector3D), 0, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Scale3D), 0, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Rotate3D), 0, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PostTransVector3D), 0, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>MeterPerModelUnitPositiveRatio.</para>
        /// <para>Represents the following element tag in the schema: am3d:meterPerModelUnit.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public MeterPerModelUnitPositiveRatio? MeterPerModelUnitPositiveRatio
        {
            get => GetElement<MeterPerModelUnitPositiveRatio>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PreTransVector3D.</para>
        /// <para>Represents the following element tag in the schema: am3d:preTrans.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public PreTransVector3D? PreTransVector3D
        {
            get => GetElement<PreTransVector3D>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Scale3D.</para>
        /// <para>Represents the following element tag in the schema: am3d:scale.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public Scale3D? Scale3D
        {
            get => GetElement<Scale3D>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Rotate3D.</para>
        /// <para>Represents the following element tag in the schema: am3d:rot.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public Rotate3D? Rotate3D
        {
            get => GetElement<Rotate3D>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PostTransVector3D.</para>
        /// <para>Represents the following element tag in the schema: am3d:postTrans.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public PostTransVector3D? PostTransVector3D
        {
            get => GetElement<PostTransVector3D>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: am3d:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public OfficeArtExtensionList? OfficeArtExtensionList
        {
            get => GetElement<OfficeArtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Model3DTransform>(deep);
    }

    /// <summary>
    /// <para>Optional source attribution URL describes from whence the 3D model came..</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:attrSrcUrl.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(111, "attrSrcUrl")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class PictureAttributionSourceURL : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the PictureAttributionSourceURL class.
        /// </summary>
        public PictureAttributionSourceURL() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: r:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(19, "id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(111, "attrSrcUrl");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddElement<PictureAttributionSourceURL>()
.AddAttribute(19, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PictureAttributionSourceURL>(deep);
    }

    /// <summary>
    /// <para>Defines the Model3DRaster Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:raster.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Blip &lt;am3d:blip></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(111, "raster")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Model3DRaster : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Model3DRaster class.
        /// </summary>
        public Model3DRaster() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model3DRaster class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Model3DRaster(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model3DRaster class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Model3DRaster(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model3DRaster class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Model3DRaster(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>rName, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: rName</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "rName")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? RName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>rVer, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: rVer</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "rVer")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? RVer
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(111, "raster");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<Blip>();
            builder.AddElement<Model3DRaster>()
.AddAttribute(0, "rName", a => a.RName, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "rVer", a => a.RVer, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Blip), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>Blip.</para>
        /// <para>Represents the following element tag in the schema: am3d:blip.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public Blip? Blip
        {
            get => GetElement<Blip>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Model3DRaster>(deep);
    }

    /// <summary>
    /// <para>Future Model3D extensions.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Model3DExtension &lt;am3d:ext></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(111, "extLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Model3DExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Model3DExtensionList class.
        /// </summary>
        public Model3DExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model3DExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Model3DExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model3DExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Model3DExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model3DExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Model3DExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(111, "extLst");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<Model3DExtension>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Model3DExtension), 0, 0, version: FileFormatVersions.Office2019)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Model3DExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the ObjectViewport Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:objViewport.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>OfficeArtExtensionList &lt;am3d:extLst></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(111, "objViewport")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ObjectViewport : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ObjectViewport class.
        /// </summary>
        public ObjectViewport() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ObjectViewport class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ObjectViewport(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ObjectViewport class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ObjectViewport(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ObjectViewport class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ObjectViewport(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>viewportSz, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: viewportSz</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "viewportSz")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int64Value? ViewportSz
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(111, "objViewport");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<OfficeArtExtensionList>();
            builder.AddElement<ObjectViewport>()
.AddAttribute(0, "viewportSz", a => a.ViewportSz, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (2147483647L) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: am3d:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public OfficeArtExtensionList? OfficeArtExtensionList
        {
            get => GetElement<OfficeArtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ObjectViewport>(deep);
    }

    /// <summary>
    /// <para>Defines the WindowViewport Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:winViewport.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>OfficeArtExtensionList &lt;am3d:extLst></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(111, "winViewport")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class WindowViewport : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the WindowViewport class.
        /// </summary>
        public WindowViewport() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the WindowViewport class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WindowViewport(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WindowViewport class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WindowViewport(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WindowViewport class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public WindowViewport(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(111, "winViewport");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<OfficeArtExtensionList>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: am3d:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public OfficeArtExtensionList? OfficeArtExtensionList
        {
            get => GetElement<OfficeArtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WindowViewport>(deep);
    }

    /// <summary>
    /// <para>Ambient light in a scene.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:ambientLight.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ColorType &lt;am3d:clr></description></item>
    ///   <item><description>IlluminancePositiveRatio &lt;am3d:illuminance></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;am3d:extLst></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(111, "ambientLight")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class AmbientLight : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the AmbientLight class.
        /// </summary>
        public AmbientLight() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AmbientLight class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AmbientLight(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AmbientLight class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AmbientLight(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AmbientLight class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public AmbientLight(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "enabled")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(111, "ambientLight");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<ColorType>();
            builder.AddChild<IlluminancePositiveRatio>();
            builder.AddChild<OfficeArtExtensionList>();
            builder.AddElement<AmbientLight>()
.AddAttribute(0, "enabled", a => a.Enabled);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.ColorType), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.IlluminancePositiveRatio), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>ColorType.</para>
        /// <para>Represents the following element tag in the schema: am3d:clr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public ColorType? ColorType
        {
            get => GetElement<ColorType>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>IlluminancePositiveRatio.</para>
        /// <para>Represents the following element tag in the schema: am3d:illuminance.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public IlluminancePositiveRatio? IlluminancePositiveRatio
        {
            get => GetElement<IlluminancePositiveRatio>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: am3d:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public OfficeArtExtensionList? OfficeArtExtensionList
        {
            get => GetElement<OfficeArtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AmbientLight>(deep);
    }

    /// <summary>
    /// <para>Defines the PointLight Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:ptLight.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ColorType &lt;am3d:clr></description></item>
    ///   <item><description>IntensityPositiveRatio &lt;am3d:intensity></description></item>
    ///   <item><description>PosPoint3D &lt;am3d:pos></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;am3d:extLst></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(111, "ptLight")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class PointLight : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PointLight class.
        /// </summary>
        public PointLight() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PointLight class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PointLight(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PointLight class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PointLight(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PointLight class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PointLight(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "enabled")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>rad, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: rad</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "rad")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int64Value? Rad
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(111, "ptLight");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<ColorType>();
            builder.AddChild<IntensityPositiveRatio>();
            builder.AddChild<PosPoint3D>();
            builder.AddChild<OfficeArtExtensionList>();
            builder.AddElement<PointLight>()
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "rad", a => a.Rad, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (2147483647L) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.ColorType), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.IntensityPositiveRatio), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PosPoint3D), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>ColorType.</para>
        /// <para>Represents the following element tag in the schema: am3d:clr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public ColorType? ColorType
        {
            get => GetElement<ColorType>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>IntensityPositiveRatio.</para>
        /// <para>Represents the following element tag in the schema: am3d:intensity.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public IntensityPositiveRatio? IntensityPositiveRatio
        {
            get => GetElement<IntensityPositiveRatio>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PosPoint3D.</para>
        /// <para>Represents the following element tag in the schema: am3d:pos.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public PosPoint3D? PosPoint3D
        {
            get => GetElement<PosPoint3D>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: am3d:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public OfficeArtExtensionList? OfficeArtExtensionList
        {
            get => GetElement<OfficeArtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PointLight>(deep);
    }

    /// <summary>
    /// <para>Defines the SpotLight Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:spotLight.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ColorType &lt;am3d:clr></description></item>
    ///   <item><description>IntensityPositiveRatio &lt;am3d:intensity></description></item>
    ///   <item><description>PosPoint3D &lt;am3d:pos></description></item>
    ///   <item><description>LookAtPoint3D &lt;am3d:lookAt></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;am3d:extLst></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(111, "spotLight")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SpotLight : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SpotLight class.
        /// </summary>
        public SpotLight() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SpotLight class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SpotLight(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SpotLight class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SpotLight(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SpotLight class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SpotLight(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "enabled")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>rad, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: rad</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "rad")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int64Value? Rad
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>spotAng, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: spotAng</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "spotAng")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? SpotAng
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(111, "spotLight");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<ColorType>();
            builder.AddChild<IntensityPositiveRatio>();
            builder.AddChild<PosPoint3D>();
            builder.AddChild<LookAtPoint3D>();
            builder.AddChild<OfficeArtExtensionList>();
            builder.AddElement<SpotLight>()
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "rad", a => a.Rad, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (2147483647L) });
})
.AddAttribute(0, "spotAng", a => a.SpotAng, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (10800000L) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.ColorType), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.IntensityPositiveRatio), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PosPoint3D), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.LookAtPoint3D), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>ColorType.</para>
        /// <para>Represents the following element tag in the schema: am3d:clr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public ColorType? ColorType
        {
            get => GetElement<ColorType>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>IntensityPositiveRatio.</para>
        /// <para>Represents the following element tag in the schema: am3d:intensity.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public IntensityPositiveRatio? IntensityPositiveRatio
        {
            get => GetElement<IntensityPositiveRatio>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PosPoint3D.</para>
        /// <para>Represents the following element tag in the schema: am3d:pos.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public PosPoint3D? PosPoint3D
        {
            get => GetElement<PosPoint3D>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>LookAtPoint3D.</para>
        /// <para>Represents the following element tag in the schema: am3d:lookAt.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public LookAtPoint3D? LookAtPoint3D
        {
            get => GetElement<LookAtPoint3D>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: am3d:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public OfficeArtExtensionList? OfficeArtExtensionList
        {
            get => GetElement<OfficeArtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SpotLight>(deep);
    }

    /// <summary>
    /// <para>Defines the DirectionalLight Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:dirLight.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ColorType &lt;am3d:clr></description></item>
    ///   <item><description>IlluminancePositiveRatio &lt;am3d:illuminance></description></item>
    ///   <item><description>PosPoint3D &lt;am3d:pos></description></item>
    ///   <item><description>LookAtPoint3D &lt;am3d:lookAt></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;am3d:extLst></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(111, "dirLight")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class DirectionalLight : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DirectionalLight class.
        /// </summary>
        public DirectionalLight() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DirectionalLight class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DirectionalLight(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DirectionalLight class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DirectionalLight(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DirectionalLight class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DirectionalLight(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "enabled")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>angularRad, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: angularRad</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "angularRad")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? AngularRad
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(111, "dirLight");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<ColorType>();
            builder.AddChild<IlluminancePositiveRatio>();
            builder.AddChild<PosPoint3D>();
            builder.AddChild<LookAtPoint3D>();
            builder.AddChild<OfficeArtExtensionList>();
            builder.AddElement<DirectionalLight>()
.AddAttribute(0, "enabled", a => a.Enabled)
.AddAttribute(0, "angularRad", a => a.AngularRad, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (5400000L) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.ColorType), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.IlluminancePositiveRatio), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PosPoint3D), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.LookAtPoint3D), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>ColorType.</para>
        /// <para>Represents the following element tag in the schema: am3d:clr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public ColorType? ColorType
        {
            get => GetElement<ColorType>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>IlluminancePositiveRatio.</para>
        /// <para>Represents the following element tag in the schema: am3d:illuminance.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public IlluminancePositiveRatio? IlluminancePositiveRatio
        {
            get => GetElement<IlluminancePositiveRatio>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PosPoint3D.</para>
        /// <para>Represents the following element tag in the schema: am3d:pos.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public PosPoint3D? PosPoint3D
        {
            get => GetElement<PosPoint3D>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>LookAtPoint3D.</para>
        /// <para>Represents the following element tag in the schema: am3d:lookAt.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public LookAtPoint3D? LookAtPoint3D
        {
            get => GetElement<LookAtPoint3D>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: am3d:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public OfficeArtExtensionList? OfficeArtExtensionList
        {
            get => GetElement<OfficeArtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DirectionalLight>(deep);
    }

    /// <summary>
    /// <para>Defines the UnknownLight Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:unkLight.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(111, "unkLight")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class UnknownLight : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the UnknownLight class.
        /// </summary>
        public UnknownLight() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(111, "unkLight");
            builder.Availability = FileFormatVersions.Office2019;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<UnknownLight>(deep);
    }
}