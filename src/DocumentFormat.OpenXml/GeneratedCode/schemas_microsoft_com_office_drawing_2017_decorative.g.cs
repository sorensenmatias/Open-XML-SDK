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

namespace DocumentFormat.OpenXml.Office2019.Drawing
{
    /// <summary>
    /// <para>Defines the Decorative Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is adec:decorative.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(112, "decorative")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Decorative : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Decorative class.
        /// </summary>
        public Decorative() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? Val
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(112, "decorative");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddElement<Decorative>()
.AddAttribute(0, "val", a => a.Val);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Decorative>(deep);
    }
}