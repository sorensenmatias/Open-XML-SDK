﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the RichStylesPart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2019)]
    [ContentType(ContentTypeConstant)]
    [RelationshipTypeAttribute(RelationshipTypeConstant)]
    public partial class RichStylesPart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.ms-excel.richstyles+xml";
        internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2017/06/relationships/richStyles";
        private DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichStylesheet? _rootElement;

        /// <summary>
        /// Creates an instance of the RichStylesPart OpenXmlType
        /// </summary>
        internal protected RichStylesPart()
        {
        }

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        private protected override OpenXmlPartRootElement? InternalRootElement
        {
            get
            {
                return _rootElement;
            }

            set
            {
                _rootElement = value as DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichStylesheet;
            }
        }

        internal override OpenXmlPartRootElement? PartRootElement => RichStylesheet;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <summary>
        /// Gets or sets the root element of this part.
        /// </summary>
        public DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichStylesheet RichStylesheet
        {
            get
            {
                if (_rootElement is null)
                {
                    LoadDomTree<DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichStylesheet>();
                }

                return _rootElement!;
            }

            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException(nameof(value));
                }

                SetDomTree(value);
            }
        }

        /// <inheritdoc/>
        internal sealed override string TargetName => "richStyles";

        /// <inheritdoc/>
        internal sealed override string TargetPath => "richData";

        internal override bool IsInVersion(FileFormatVersions version)
        {
            return version.AtLeast(FileFormatVersions.Office2019);
        }
    }
}
