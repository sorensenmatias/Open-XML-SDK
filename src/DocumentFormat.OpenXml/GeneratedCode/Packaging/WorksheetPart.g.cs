﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the WorksheetPart
    /// </summary>
    [ContentType(ContentTypeConstant)]
    [RelationshipTypeAttribute(RelationshipTypeConstant)]
    [PartConstraint(typeof(SpreadsheetPrinterSettingsPart), false, true)]
    [PartConstraint(typeof(DrawingsPart), false, false)]
    [PartConstraint(typeof(VmlDrawingPart), false, true)]
    [PartConstraint(typeof(WorksheetCommentsPart), false, false)]
    [PartConstraint(typeof(PivotTablePart), false, true)]
    [PartConstraint(typeof(SingleCellTablePart), false, false)]
    [PartConstraint(typeof(TableDefinitionPart), false, true)]
    [PartConstraint(typeof(EmbeddedControlPersistencePart), false, true)]
    [PartConstraint(typeof(ControlPropertiesPart), false, true)]
    [PartConstraint(typeof(EmbeddedObjectPart), false, true)]
    [PartConstraint(typeof(EmbeddedPackagePart), false, true)]
    [PartConstraint(typeof(ImagePart), false, true)]
    [PartConstraint(typeof(CustomPropertyPart), false, true)]
    [PartConstraint(typeof(WorksheetSortMapPart), false, false)]
    [PartConstraint(typeof(QueryTablePart), false, true)]
    [PartConstraint(typeof(EmbeddedControlPersistenceBinaryDataPart), false, true)]
    [PartConstraint(typeof(SlicersPart), false, true)]
    [PartConstraint(typeof(TimeLinePart), false, true)]
    [PartConstraint(typeof(WorksheetThreadedCommentsPart), false, true)]
    public partial class WorksheetPart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.spreadsheetml.worksheet+xml";
        internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/worksheet";
        private DocumentFormat.OpenXml.Spreadsheet.Worksheet? _rootElement;

        /// <summary>
        /// Creates an instance of the WorksheetPart OpenXmlType
        /// </summary>
        internal protected WorksheetPart()
        {
        }

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        /// <summary>
        /// Gets the ControlPropertiesParts of the WorksheetPart
        /// </summary>
        public IEnumerable<ControlPropertiesPart> ControlPropertiesParts => GetPartsOfType<ControlPropertiesPart>();

        /// <summary>
        /// Gets the CustomPropertyParts of the WorksheetPart
        /// </summary>
        public IEnumerable<CustomPropertyPart> CustomPropertyParts => GetPartsOfType<CustomPropertyPart>();

        /// <summary>
        /// Gets the DrawingsPart of the WorksheetPart
        /// </summary>
        public DrawingsPart? DrawingsPart => GetSubPartOfType<DrawingsPart>();

        /// <summary>
        /// Gets the EmbeddedControlPersistenceBinaryDataParts of the WorksheetPart
        /// </summary>
        public IEnumerable<EmbeddedControlPersistenceBinaryDataPart> EmbeddedControlPersistenceBinaryDataParts => GetPartsOfType<EmbeddedControlPersistenceBinaryDataPart>();

        /// <summary>
        /// Gets the EmbeddedControlPersistenceParts of the WorksheetPart
        /// </summary>
        public IEnumerable<EmbeddedControlPersistencePart> EmbeddedControlPersistenceParts => GetPartsOfType<EmbeddedControlPersistencePart>();

        /// <summary>
        /// Gets the EmbeddedObjectParts of the WorksheetPart
        /// </summary>
        public IEnumerable<EmbeddedObjectPart> EmbeddedObjectParts => GetPartsOfType<EmbeddedObjectPart>();

        /// <summary>
        /// Gets the EmbeddedPackageParts of the WorksheetPart
        /// </summary>
        public IEnumerable<EmbeddedPackagePart> EmbeddedPackageParts => GetPartsOfType<EmbeddedPackagePart>();

        /// <summary>
        /// Gets the ImageParts of the WorksheetPart
        /// </summary>
        public IEnumerable<ImagePart> ImageParts => GetPartsOfType<ImagePart>();

        private protected override OpenXmlPartRootElement? InternalRootElement
        {
            get
            {
                return _rootElement;
            }

            set
            {
                _rootElement = value as DocumentFormat.OpenXml.Spreadsheet.Worksheet;
            }
        }

        internal override OpenXmlPartRootElement? PartRootElement => Worksheet;

        /// <summary>
        /// Gets the PivotTableParts of the WorksheetPart
        /// </summary>
        public IEnumerable<PivotTablePart> PivotTableParts => GetPartsOfType<PivotTablePart>();

        /// <summary>
        /// Gets the QueryTableParts of the WorksheetPart
        /// </summary>
        public IEnumerable<QueryTablePart> QueryTableParts => GetPartsOfType<QueryTablePart>();

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <summary>
        /// Gets the SingleCellTablePart of the WorksheetPart
        /// </summary>
        public SingleCellTablePart? SingleCellTablePart => GetSubPartOfType<SingleCellTablePart>();

        /// <summary>
        /// Gets the SlicersParts of the WorksheetPart
        /// </summary>
        public IEnumerable<SlicersPart> SlicersParts => GetPartsOfType<SlicersPart>();

        /// <summary>
        /// Gets the SpreadsheetPrinterSettingsParts of the WorksheetPart
        /// </summary>
        public IEnumerable<SpreadsheetPrinterSettingsPart> SpreadsheetPrinterSettingsParts => GetPartsOfType<SpreadsheetPrinterSettingsPart>();

        /// <summary>
        /// Gets the TableDefinitionParts of the WorksheetPart
        /// </summary>
        public IEnumerable<TableDefinitionPart> TableDefinitionParts => GetPartsOfType<TableDefinitionPart>();

        /// <inheritdoc/>
        internal sealed override string TargetName => "sheet";

        /// <inheritdoc/>
        internal sealed override string TargetPath => "worksheets";

        /// <summary>
        /// Gets the TimeLineParts of the WorksheetPart
        /// </summary>
        public IEnumerable<TimeLinePart> TimeLineParts => GetPartsOfType<TimeLinePart>();

        /// <summary>
        /// Gets the VmlDrawingParts of the WorksheetPart
        /// </summary>
        public IEnumerable<VmlDrawingPart> VmlDrawingParts => GetPartsOfType<VmlDrawingPart>();

        /// <summary>
        /// Gets or sets the root element of this part.
        /// </summary>
        public DocumentFormat.OpenXml.Spreadsheet.Worksheet Worksheet
        {
            get
            {
                if (_rootElement is null)
                {
                    LoadDomTree<DocumentFormat.OpenXml.Spreadsheet.Worksheet>();
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

        /// <summary>
        /// Gets the WorksheetCommentsPart of the WorksheetPart
        /// </summary>
        public WorksheetCommentsPart? WorksheetCommentsPart => GetSubPartOfType<WorksheetCommentsPart>();

        /// <summary>
        /// Gets the WorksheetSortMapPart of the WorksheetPart
        /// </summary>
        public WorksheetSortMapPart? WorksheetSortMapPart => GetSubPartOfType<WorksheetSortMapPart>();

        /// <summary>
        /// Gets the WorksheetThreadedCommentsParts of the WorksheetPart
        /// </summary>
        public IEnumerable<WorksheetThreadedCommentsPart> WorksheetThreadedCommentsParts => GetPartsOfType<WorksheetThreadedCommentsPart>();

        /// <summary>
        /// Adds a CustomPropertyPart to the WorksheetPart
        /// </summary>
        /// <param name="contentType">The content type of the CustomPropertyPart</param>
        /// <return>The newly added part</return>
        public CustomPropertyPart AddCustomPropertyPart(string contentType)
        {
            var childPart = new CustomPropertyPart();
            InitPart(childPart, contentType);
            return childPart;
        }

        /// <summary>
        /// Adds a CustomPropertyPart to the WorksheetPart
        /// </summary>
        /// <param name="contentType">The content type of the CustomPropertyPart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public CustomPropertyPart AddCustomPropertyPart(string contentType, string id)
        {
            var childPart = new CustomPropertyPart();
            InitPart(childPart, contentType, id);
            return childPart;
        }

        /// <summary>
        /// Adds a CustomPropertyPart to the WorksheetPart
        /// </summary>
        /// <param name="partType">The part type of the CustomPropertyPart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public CustomPropertyPart AddCustomPropertyPart(CustomPropertyPartType partType, string id)
        {
            var contentType = CustomPropertyPartTypeInfo.GetContentType(partType);
            var partExtension = CustomPropertyPartTypeInfo.GetTargetExtension();
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddCustomPropertyPart(contentType, id);
        }

        /// <summary>
        /// Adds a CustomPropertyPart to the WorksheetPart
        /// </summary>
        /// <param name="partType">The part type of the CustomPropertyPart</param>
        /// <return>The newly added part</return>
        public CustomPropertyPart AddCustomPropertyPart(CustomPropertyPartType partType)
        {
            var contentType = CustomPropertyPartTypeInfo.GetContentType(partType);
            var partExtension = CustomPropertyPartTypeInfo.GetTargetExtension();
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddCustomPropertyPart(contentType);
        }

        /// <summary>
        /// Adds a EmbeddedControlPersistenceBinaryDataPart to the WorksheetPart
        /// </summary>
        /// <param name="contentType">The content type of the EmbeddedControlPersistenceBinaryDataPart</param>
        /// <return>The newly added part</return>
        public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(string contentType)
        {
            var childPart = new EmbeddedControlPersistenceBinaryDataPart();
            InitPart(childPart, contentType);
            return childPart;
        }

        /// <summary>
        /// Adds a EmbeddedControlPersistenceBinaryDataPart to the WorksheetPart
        /// </summary>
        /// <param name="contentType">The content type of the EmbeddedControlPersistenceBinaryDataPart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(string contentType, string id)
        {
            var childPart = new EmbeddedControlPersistenceBinaryDataPart();
            InitPart(childPart, contentType, id);
            return childPart;
        }

        /// <summary>
        /// Adds a EmbeddedControlPersistenceBinaryDataPart to the WorksheetPart
        /// </summary>
        /// <param name="partType">The part type of the EmbeddedControlPersistenceBinaryDataPart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(EmbeddedControlPersistenceBinaryDataPartType partType, string id)
        {
            var contentType = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetContentType(partType);
            var partExtension = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetTargetExtension();
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddEmbeddedControlPersistenceBinaryDataPart(contentType, id);
        }

        /// <summary>
        /// Adds a EmbeddedControlPersistenceBinaryDataPart to the WorksheetPart
        /// </summary>
        /// <param name="partType">The part type of the EmbeddedControlPersistenceBinaryDataPart</param>
        /// <return>The newly added part</return>
        public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(EmbeddedControlPersistenceBinaryDataPartType partType)
        {
            var contentType = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetContentType(partType);
            var partExtension = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetTargetExtension();
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddEmbeddedControlPersistenceBinaryDataPart(contentType);
        }

        /// <summary>
        /// Adds a EmbeddedControlPersistencePart to the WorksheetPart
        /// </summary>
        /// <param name="contentType">The content type of the EmbeddedControlPersistencePart</param>
        /// <return>The newly added part</return>
        public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(string contentType)
        {
            var childPart = new EmbeddedControlPersistencePart();
            InitPart(childPart, contentType);
            return childPart;
        }

        /// <summary>
        /// Adds a EmbeddedControlPersistencePart to the WorksheetPart
        /// </summary>
        /// <param name="contentType">The content type of the EmbeddedControlPersistencePart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(string contentType, string id)
        {
            var childPart = new EmbeddedControlPersistencePart();
            InitPart(childPart, contentType, id);
            return childPart;
        }

        /// <summary>
        /// Adds a EmbeddedControlPersistencePart to the WorksheetPart
        /// </summary>
        /// <param name="partType">The part type of the EmbeddedControlPersistencePart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(EmbeddedControlPersistencePartType partType, string id)
        {
            var contentType = EmbeddedControlPersistencePartTypeInfo.GetContentType(partType);
            var partExtension = EmbeddedControlPersistencePartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddEmbeddedControlPersistencePart(contentType, id);
        }

        /// <summary>
        /// Adds a EmbeddedControlPersistencePart to the WorksheetPart
        /// </summary>
        /// <param name="partType">The part type of the EmbeddedControlPersistencePart</param>
        /// <return>The newly added part</return>
        public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(EmbeddedControlPersistencePartType partType)
        {
            var contentType = EmbeddedControlPersistencePartTypeInfo.GetContentType(partType);
            var partExtension = EmbeddedControlPersistencePartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddEmbeddedControlPersistencePart(contentType);
        }

        /// <summary>
        /// Adds a EmbeddedObjectPart to the WorksheetPart
        /// </summary>
        /// <param name="contentType">The content type of the EmbeddedObjectPart</param>
        /// <return>The newly added part</return>
        public EmbeddedObjectPart AddEmbeddedObjectPart(string contentType)
        {
            var childPart = new EmbeddedObjectPart();
            InitPart(childPart, contentType);
            return childPart;
        }

        /// <summary>
        /// Adds a EmbeddedPackagePart to the WorksheetPart
        /// </summary>
        /// <param name="contentType">The content type of the EmbeddedPackagePart</param>
        /// <return>The newly added part</return>
        public EmbeddedPackagePart AddEmbeddedPackagePart(string contentType)
        {
            var childPart = new EmbeddedPackagePart();
            InitPart(childPart, contentType);
            return childPart;
        }

        /// <summary>
        /// Adds a ImagePart to the WorksheetPart
        /// </summary>
        /// <param name="contentType">The content type of the ImagePart</param>
        /// <return>The newly added part</return>
        public ImagePart AddImagePart(string contentType)
        {
            var childPart = new ImagePart();
            InitPart(childPart, contentType);
            return childPart;
        }

        /// <summary>
        /// Adds a ImagePart to the WorksheetPart
        /// </summary>
        /// <param name="contentType">The content type of the ImagePart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public ImagePart AddImagePart(string contentType, string id)
        {
            var childPart = new ImagePart();
            InitPart(childPart, contentType, id);
            return childPart;
        }

        /// <summary>
        /// Adds a ImagePart to the WorksheetPart
        /// </summary>
        /// <param name="partType">The part type of the ImagePart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public ImagePart AddImagePart(ImagePartType partType, string id)
        {
            var contentType = ImagePartTypeInfo.GetContentType(partType);
            var partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddImagePart(contentType, id);
        }

        /// <summary>
        /// Adds a ImagePart to the WorksheetPart
        /// </summary>
        /// <param name="partType">The part type of the ImagePart</param>
        /// <return>The newly added part</return>
        public ImagePart AddImagePart(ImagePartType partType)
        {
            var contentType = ImagePartTypeInfo.GetContentType(partType);
            var partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddImagePart(contentType);
        }

        /// <inheritdoc/>
        internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
        {
            ThrowIfObjectDisposed();
            if (relationshipType is null)
            {
                throw new ArgumentNullException(nameof(relationshipType));
            }

            switch (relationshipType)
            {
                case SpreadsheetPrinterSettingsPart.RelationshipTypeConstant:
                    return new SpreadsheetPrinterSettingsPart();
                case DrawingsPart.RelationshipTypeConstant:
                    return new DrawingsPart();
                case VmlDrawingPart.RelationshipTypeConstant:
                    return new VmlDrawingPart();
                case WorksheetCommentsPart.RelationshipTypeConstant:
                    return new WorksheetCommentsPart();
                case PivotTablePart.RelationshipTypeConstant:
                    return new PivotTablePart();
                case SingleCellTablePart.RelationshipTypeConstant:
                    return new SingleCellTablePart();
                case TableDefinitionPart.RelationshipTypeConstant:
                    return new TableDefinitionPart();
                case EmbeddedControlPersistencePart.RelationshipTypeConstant:
                    return new EmbeddedControlPersistencePart();
                case ControlPropertiesPart.RelationshipTypeConstant:
                    return new ControlPropertiesPart();
                case EmbeddedObjectPart.RelationshipTypeConstant:
                    return new EmbeddedObjectPart();
                case EmbeddedPackagePart.RelationshipTypeConstant:
                    return new EmbeddedPackagePart();
                case ImagePart.RelationshipTypeConstant:
                    return new ImagePart();
                case CustomPropertyPart.RelationshipTypeConstant:
                    return new CustomPropertyPart();
                case WorksheetSortMapPart.RelationshipTypeConstant:
                    return new WorksheetSortMapPart();
                case QueryTablePart.RelationshipTypeConstant:
                    return new QueryTablePart();
                case EmbeddedControlPersistenceBinaryDataPart.RelationshipTypeConstant:
                    return new EmbeddedControlPersistenceBinaryDataPart();
                case SlicersPart.RelationshipTypeConstant:
                    return new SlicersPart();
                case TimeLinePart.RelationshipTypeConstant:
                    return new TimeLinePart();
                case WorksheetThreadedCommentsPart.RelationshipTypeConstant:
                    return new WorksheetThreadedCommentsPart();
            }

            throw new ArgumentOutOfRangeException(nameof(relationshipType));
        }
    }
}
