﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace DocumentFormat.OpenXml.Framework
{
    internal readonly struct OpenXmlNamespace : IComparable<OpenXmlNamespace>, IEquatable<OpenXmlNamespace>
    {
        private readonly string? _prefix;
        private readonly string? _uri;

        internal OpenXmlNamespace(byte nsId)
        {
            _prefix = GetNamespacePrefix(nsId);
            _uri = GetNamespaceUri(nsId);
        }

        public OpenXmlNamespace(string? nsUri, string? prefix = null)
        {
            _uri = nsUri;
            _prefix = prefix;
        }

        public string Uri => _uri ?? string.Empty;

        public string Prefix => _prefix ?? GetNamespacePrefix(Uri) ?? string.Empty;

        public bool IsKnown => TryGetNamespaceId(Uri, out _);

        public bool IsEmpty => string.IsNullOrEmpty(Uri);

        internal byte NsId => TryGetNamespaceId(Uri, out var id) ? id : throw new InvalidOperationException();

        public FileFormatVersions Version
            => _namespaceResolver.TryGetByNamespace(Uri, out var info) ? info.Version : FileFormatVersions.None;

        public bool IsInVersion(FileFormatVersions version)
            => Version == version;

        /// <summary>
        /// Attempts to get the Transitional equivalent namespace.
        /// </summary>
        /// <param name="transitionalNamespace">An equivalent namespace in Transitional.</param>
        /// <returns>Returns true when a Transitional equivalent namespace is found, returns false when it is not found.</returns>
        public bool TryGetTransitionalNamespace(out OpenXmlNamespace transitionalNamespace)
            => _strictTransitionalNamespaces.TryGetValue(Uri, out transitionalNamespace);

        /// <summary>
        /// Attempts to get the Transitional equivalent relationship.
        /// </summary>
        /// <param name="transitionalRelationship">An equivalent relationship in Transitional.</param>
        /// <returns>Returns true when a Transitional equivalent relationship is found, returns false when it is not.</returns>
        public bool TryGetTransitionalRelationship(out OpenXmlNamespace transitionalRelationship)
            => _strictTransitionalRelationshipPairs.TryGetValue(Uri, out transitionalRelationship);

        /// <summary>
        /// Try to get the expected namespace if the passed namespace is an obsolete.
        /// </summary>
        /// <param name="extNamespaceUri">The expected namespace when the passed namespace is an obsolete.</param>
        /// <returns>True when the passed namespace is an obsolete and the expected namespace found</returns>
        public bool TryGetExtendedNamespace(out OpenXmlNamespace extNamespaceUri)
            => _extendedNamespaces.TryGetValue(Uri, out extNamespaceUri);

        public override bool Equals(object? obj) => obj is OpenXmlNamespace ns && Equals(ns);

        public bool Equals(OpenXmlNamespace other)
            => string.Equals(Uri, other.Uri, StringComparison.Ordinal);

        public override int GetHashCode()
        {
            var hashcode = new HashCode();

            hashcode.Add(Uri, StringComparer.Ordinal);

            return hashcode.ToHashCode();
        }

        public override string ToString() => Uri;

        public int CompareTo(OpenXmlNamespace other)
            => string.CompareOrdinal(Uri, other.Uri);

        public static implicit operator OpenXmlNamespace(string ns) => new OpenXmlNamespace(ns);

        private static bool TryGetNamespaceId(string namespaceUri, out byte id)
        {
            if (namespaceUri is not null && _namespaceResolver.TryGetByNamespace(NormalizeNamespace(namespaceUri), out var info))
            {
                id = info.Id;
                return true;
            }
            else
            {
                id = byte.MaxValue;
                return false;
            }
        }

        private static string GetNamespaceUri(byte namespaceId) => _namespaceResolver[namespaceId].Namespace;

        /// <summary>
        /// Gets the namespace URI for the specified namespace prefix.
        /// </summary>
        /// <param name="prefix">The namespace prefix.</param>
        /// <returns></returns>
        public static string? GetNamespaceUri(string prefix)
        {
            if (prefix is null)
            {
                throw new ArgumentNullException(nameof(prefix));
            }

            if (_namespaceResolver.TryGetByPrefix(prefix, out var info))
            {
                return info.Namespace;
            }

            return null;
        }

        /// <summary>
        /// Gets the default namespace prefix for the specified namespace ID.
        /// </summary>
        /// <param name="namespaceId">The namespace ID.</param>
        /// <returns>The default namespace prefix.</returns>
        private static string GetNamespacePrefix(byte namespaceId) => _namespaceResolver[namespaceId].Prefix;

        /// <summary>
        /// Gets the default namespace prefix for the specified namespace URI.
        /// </summary>
        /// <param name="namespaceUri">The namespace URI.</param>
        /// <returns>The default namespace prefix.</returns>
        public static string? GetNamespacePrefix(string namespaceUri) =>
            _namespaceResolver.TryGetByNamespace(namespaceUri, out var info) ? info.Prefix : null;

        private static string NormalizeNamespace(in OpenXmlNamespace ns)
        {
            if (ns.TryGetExtendedNamespace(out var result))
            {
                return result.Uri;
            }

            return ns.Uri;
        }

        /// <summary>
        /// A list of namespaces, associated prefixes and the version in which it was introduced.
        /// </summary>
        /// <remarks>
        /// CAUTION: Do NOT modify this list except by adding to the end. The index of the entry is tied
        /// directly to an id used extensively throughout the SDK. Ideally, this will be updated to not
        /// have this magic, but that will take time. If any items are updated in the middle of the list,
        /// the strongly typed schema classes and validation data will need to be regenerated.
        /// </remarks>
        private static readonly NamespaceResolver _namespaceResolver = new NamespaceResolver
        {
            { string.Empty, string.Empty, FileFormatVersions.None },
            { "http://www.w3.org/XML/1998/namespace", "xml", FileFormatVersions.Office2007 },
            { "http://schemas.openxmlformats.org/package/2006/metadata/core-properties", "cp", FileFormatVersions.Office2007 },
            { "http://schemas.openxmlformats.org/officeDocument/2006/extended-properties", "ap", FileFormatVersions.Office2007 },
            { "http://schemas.openxmlformats.org/officeDocument/2006/custom-properties", "op", FileFormatVersions.Office2007 },
            { "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes", "vt", FileFormatVersions.Office2007 },
            { "http://purl.org/dc/elements/1.1/", "dc", FileFormatVersions.Office2007 },
            { "http://purl.org/dc/terms/", "dcterms", FileFormatVersions.Office2007 },
            { "http://schemas.openxmlformats.org/officeDocument/2006/characteristics", "ac", FileFormatVersions.Office2007 },
            { "http://schemas.openxmlformats.org/officeDocument/2006/bibliography", "b", FileFormatVersions.Office2007 },
            { "http://schemas.openxmlformats.org/drawingml/2006/main", "a", FileFormatVersions.Office2007 },
            { "http://schemas.openxmlformats.org/drawingml/2006/chart", "c", FileFormatVersions.Office2007 },
            { "http://schemas.openxmlformats.org/drawingml/2006/chartDrawing", "cdr", FileFormatVersions.Office2007 },
            { "http://schemas.openxmlformats.org/drawingml/2006/compatibility", "comp", FileFormatVersions.Office2007 },
            { "http://schemas.openxmlformats.org/drawingml/2006/diagram", "dgm", FileFormatVersions.Office2007 },
            { "http://schemas.openxmlformats.org/drawingml/2006/lockedCanvas", "lc", FileFormatVersions.Office2007 },
            { "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing", "wp", FileFormatVersions.Office2007 },
            { "http://schemas.openxmlformats.org/drawingml/2006/picture", "pic", FileFormatVersions.Office2007 },
            { "http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing", "xdr", FileFormatVersions.Office2007 },
            { "http://schemas.openxmlformats.org/officeDocument/2006/relationships", "r", FileFormatVersions.Office2007 },
            { "http://schemas.openxmlformats.org/officeDocument/2006/customXml", "ds", FileFormatVersions.Office2007 },
            { "http://schemas.openxmlformats.org/officeDocument/2006/math", "m", FileFormatVersions.Office2007 },
            { "http://schemas.openxmlformats.org/spreadsheetml/2006/main", "x", FileFormatVersions.Office2007 },
            { "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "w", FileFormatVersions.Office2007 },
            { "http://schemas.openxmlformats.org/presentationml/2006/main", "p", FileFormatVersions.Office2007 },
            { "http://schemas.openxmlformats.org/schemaLibrary/2006/main", "sl", FileFormatVersions.Office2007 },
            { "urn:schemas-microsoft-com:vml", "v", FileFormatVersions.Office2007 },
            { "urn:schemas-microsoft-com:office:office", "o", FileFormatVersions.Office2007 },
            { "urn:schemas-microsoft-com:office:word", "w10", FileFormatVersions.Office2007 },
            { "urn:schemas-microsoft-com:office:excel", "xvml", FileFormatVersions.Office2007 },
            { "urn:schemas-microsoft-com:office:powerpoint", "pvml", FileFormatVersions.Office2007 },
            { "http://schemas.openxmlformats.org/markup-compatibility/2006", "mc", FileFormatVersions.Office2007 },
            { "http://schemas.microsoft.com/office/excel/2006/main", "xne", FileFormatVersions.Office2007 },
            { "http://schemas.microsoft.com/office/word/2006/wordml", "wne", FileFormatVersions.Office2007 },
            { "http://schemas.microsoft.com/office/2006/01/customui", "mso", FileFormatVersions.Office2007 },
            { "http://schemas.microsoft.com/office/2006/activeX", "ax", FileFormatVersions.Office2007 },
            { "http://schemas.microsoft.com/office/2006/coverPageProps", "cppr", FileFormatVersions.Office2007 },
            { "http://schemas.microsoft.com/office/2006/customDocumentInformationPanel", "cdip", FileFormatVersions.Office2007 },
            { "http://schemas.microsoft.com/office/2006/metadata/contentType", "ct", FileFormatVersions.Office2007 },
            { "http://schemas.microsoft.com/office/2006/metadata/customXsn", "ntns", FileFormatVersions.Office2007 },
            { "http://schemas.microsoft.com/office/2006/metadata/longProperties", "lp", FileFormatVersions.Office2007 },
            { "http://schemas.microsoft.com/office/2006/metadata/properties/metaAttributes", "ma", FileFormatVersions.Office2007 },
            { "http://www.w3.org/2001/XMLSchema", "xsd", FileFormatVersions.Office2007 },
            { "http://www.w3.org/2003/InkML", "inkml", FileFormatVersions.Office2007 },
            { "http://www.w3.org/2003/04/emma", "emma", FileFormatVersions.Office2007 },
            { "http://schemas.microsoft.com/ink/2010/main", "msink", FileFormatVersions.Office2007 },
            { "http://schemas.microsoft.com/office/drawing/2007/8/2/chart", "c14", FileFormatVersions.Office2010 },
            { "http://schemas.microsoft.com/office/drawing/2010/chartDrawing", "cdr14", FileFormatVersions.Office2010 },
            { "http://schemas.microsoft.com/office/drawing/2010/main", "a14", FileFormatVersions.Office2010 },
            { "http://schemas.microsoft.com/office/powerpoint/2010/main", "p14", FileFormatVersions.Office2010 },
            { "http://schemas.microsoft.com/office/drawing/2010/picture", "pic14", FileFormatVersions.Office2010 },
            { "http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing", "wp14", FileFormatVersions.Office2010 },
            { "http://schemas.microsoft.com/office/word/2010/wordml", "w14", FileFormatVersions.Office2010 },
            { "http://schemas.microsoft.com/office/spreadsheetml/2009/9/main", "x14", FileFormatVersions.Office2010 },
            { "http://schemas.microsoft.com/office/excel/2010/spreadsheetDrawing", "xdr14", FileFormatVersions.Office2010 },
            { "http://schemas.microsoft.com/office/spreadsheetml/2009/9/ac", "x14ac", FileFormatVersions.Office2010 },
            { "http://schemas.microsoft.com/office/drawing/2008/diagram", "dsp", FileFormatVersions.Office2007 },
            { "http://schemas.microsoft.com/office/2009/07/customui", "mso14", FileFormatVersions.Office2010 },
            { "http://schemas.microsoft.com/office/drawing/2010/diagram", "dgm14", FileFormatVersions.Office2010 },
            { "http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas", "wpc", FileFormatVersions.Office2010 },
            { "http://schemas.microsoft.com/office/word/2010/wordprocessingGroup", "wpg", FileFormatVersions.Office2010 },
            { "http://schemas.microsoft.com/office/word/2010/wordprocessingShape", "wps", FileFormatVersions.Office2010 },
            { "http://schemas.microsoft.com/office/drawing/2010/slicer", "sle", FileFormatVersions.Office2010 },
            { "http://schemas.microsoft.com/office/drawing/2010/compatibility", "com14", FileFormatVersions.Office2010 },
            { "http://schemas.microsoft.com/office/drawing/2012/chart", "c15", FileFormatVersions.Office2013 },
            { "http://schemas.microsoft.com/office/drawing/2012/chartStyle", "cs", FileFormatVersions.Office2013 },
            { "http://schemas.microsoft.com/office/webextensions/webextension/2010/11", "we", FileFormatVersions.Office2013 },
            { "http://schemas.microsoft.com/office/drawing/2012/main", "a15", FileFormatVersions.Office2013 },
            { "http://schemas.microsoft.com/office/powerpoint/2012/main", "p15", FileFormatVersions.Office2013 },
            { "http://schemas.microsoft.com/office/word/2012/wordml", "w15", FileFormatVersions.Office2013 },
            { "http://schemas.microsoft.com/office/webextensions/taskpanes/2010/11", "wetp", FileFormatVersions.Office2013 },
            { "http://schemas.microsoft.com/office/spreadsheetml/2010/11/main", "x15", FileFormatVersions.Office2013 },
            { "http://schemas.microsoft.com/office/spreadsheetml/2011/1/ac", "x12ac", FileFormatVersions.Office2013 },
            { "http://schemas.microsoft.com/office/thememl/2012/main", "thm15", FileFormatVersions.Office2013 },
            { "http://schemas.microsoft.com/office/spreadsheetml/2010/11/ac", "x15ac", FileFormatVersions.Office2013 },
            { "http://schemas.microsoft.com/office/word/2012/wordprocessingDrawing", "wp15", FileFormatVersions.Office2013 },
            { "http://schemas.microsoft.com/office/powerpoint/2012/roamingSettings", "pRoam", FileFormatVersions.Office2013 },
            { "http://schemas.microsoft.com/office/drawing/2012/timeslicer", "tsle", FileFormatVersions.Office2013 },
            { "http://schemas.microsoft.com/office/powerpoint/2015/main", "p16", FileFormatVersions.Office2016 },
            { "http://schemas.microsoft.com/office/drawing/2014/main", "a16", FileFormatVersions.Office2016 },
            { "http://schemas.microsoft.com/office/drawing/2014/chartex", "cx", FileFormatVersions.Office2016 },
            { "http://schemas.microsoft.com/office/drawing/2014/chart/ac", "c16ac", FileFormatVersions.Office2016 },
            { "http://schemas.microsoft.com/office/drawing/2014/chart", "c16", FileFormatVersions.Office2016 },
            { "http://schemas.microsoft.com/office/spreadsheetml/2014/revision", "xr", FileFormatVersions.Office2016 },
            { "http://schemas.microsoft.com/office/spreadsheetml/2014/11/main", "x16", FileFormatVersions.Office2016 },
            { "http://schemas.microsoft.com/office/spreadsheetml/2015/02/main", "x16r2", FileFormatVersions.Office2016 },
            { "http://schemas.microsoft.com/office/word/2015/wordml/symex", "w16se", FileFormatVersions.Office2016 },

            // Named 2013/main/command with "oac" ns prefix to avoid conflict with officedocument/2006/characteristics
            { "http://schemas.microsoft.com/office/drawing/2013/main/command", "oac", FileFormatVersions.Office2016 },
            { "http://schemas.microsoft.com/office/powerpoint/2013/main/command", "pc", FileFormatVersions.Office2016 },

            // O19
            { "http://schemas.microsoft.com/office/powerpoint/2017/3/main", "p173", FileFormatVersions.Office2019 },
            { "http://schemas.microsoft.com/office/powerpoint/2017/10/main", "p1710", FileFormatVersions.Office2019 },
            { "http://schemas.microsoft.com/office/powerpoint/2018/4/main", "p184", FileFormatVersions.Office2019 },
            { "http://schemas.microsoft.com/office/spreadsheetml/2016/pivotdefaultlayout", "xpdl", FileFormatVersions.Office2019 },
            { "http://schemas.microsoft.com/office/spreadsheetml/2016/01/main", "xlPr", FileFormatVersions.Office2019 },
            { "http://schemas.microsoft.com/office/spreadsheetml/2015/revision2", "xr2", FileFormatVersions.Office2019 },
            { "http://schemas.microsoft.com/office/spreadsheetml/2016/revision3", "xr3", FileFormatVersions.Office2019 },
            { "http://schemas.microsoft.com/office/spreadsheetml/2016/revision5", "xr5", FileFormatVersions.Office2019 },
            { "http://schemas.microsoft.com/office/spreadsheetml/2016/revision6", "xr6", FileFormatVersions.Office2019 },
            { "http://schemas.microsoft.com/office/spreadsheetml/2016/revision9", "xr9", FileFormatVersions.Office2019 },
            { "http://schemas.microsoft.com/office/spreadsheetml/2016/revision10", "xr10", FileFormatVersions.Office2019 },
            { "http://schemas.microsoft.com/office/spreadsheetml/2017/revision16", "xr16", FileFormatVersions.Office2019 },
            { "http://schemas.microsoft.com/office/spreadsheetml/2017/richdata2", "xlrd2", FileFormatVersions.Office2019 },
            { "http://schemas.microsoft.com/office/spreadsheetml/2017/richdata", "xlrd", FileFormatVersions.Office2019 },
            { "http://schemas.microsoft.com/office/spreadsheetml/2018/calcfeatures", "xcalcf", FileFormatVersions.Office2019 },
            { "http://schemas.microsoft.com/office/spreadsheetml/2018/threadedcomments", "xltc", FileFormatVersions.Office2019 },
            { "http://schemas.microsoft.com/office/drawing/2017/03/chart", "c16r3", FileFormatVersions.Office2019 },
            { "http://schemas.microsoft.com/office/spreadsheetml/2017/dynamicarray", "xda", FileFormatVersions.Office2019 },
            { "http://schemas.microsoft.com/office/drawing/2016/11/main", "a1611", FileFormatVersions.Office2019 },
            { "http://schemas.microsoft.com/office/drawing/2016/11/diagram", "dgm1611", FileFormatVersions.Office2019 },
            { "http://schemas.microsoft.com/office/drawing/2016/12/diagram", "dgm1612", FileFormatVersions.Office2019 },
            { "http://schemas.microsoft.com/office/drawing/2016/ink", "aink", FileFormatVersions.Office2019 },
            { "http://schemas.microsoft.com/office/drawing/2017/model3d", "am3d", FileFormatVersions.Office2019 },
            { "http://schemas.microsoft.com/office/drawing/2017/decorative", "adec", FileFormatVersions.Office2019 },
            { "http://schemas.microsoft.com/office/drawing/2018/animation", "aanim", FileFormatVersions.Office2019 },
            { "http://schemas.microsoft.com/office/drawing/2018/animation/model3d", "a3danim", FileFormatVersions.Office2019 },
            { "http://schemas.microsoft.com/office/drawing/2018/hyperlinkcolor", "ahyp", FileFormatVersions.Office2019 },
            { "http://schemas.microsoft.com/office/word/2016/wordml/cid", "w16cid", FileFormatVersions.Office2019 },
            { "http://schemas.microsoft.com/office/drawing/2016/SVG/main", "asvg", FileFormatVersions.Office2019 },

            // O21
            { "http://schemas.microsoft.com/office/2020/mipLabelMetadata" , "clbl", FileFormatVersions.Office2021 },
            { "http://schemas.microsoft.com/office/drawing/2020/classificationShape"  , "aclsh", FileFormatVersions.Office2021 },
            { "http://schemas.microsoft.com/office/drawing/2018/sketchyshapes"  , "ask", FileFormatVersions.Office2021 },
            { "http://schemas.microsoft.com/office/drawing/2021/livefeed"  , "alf", FileFormatVersions.Office2021 },
            { "http://schemas.microsoft.com/office/2019/extlst"  , "oel", FileFormatVersions.Office2021 },
            { "http://schemas.microsoft.com/office/powerpoint/2018/8/main"  , "p188", FileFormatVersions.Office2021 },
            { "http://schemas.microsoft.com/office/powerpoint/2020/02/main"  , "p202", FileFormatVersions.Office2021 },
            { "http://schemas.microsoft.com/office/tasks/2019/documenttasks"  , "t", FileFormatVersions.Office2021 },
            { "http://schemas.microsoft.com/office/word/2018/wordml"  , "w16cur", FileFormatVersions.Office2021 },
            { "http://schemas.microsoft.com/office/word/2018/wordml/cex"  , "w16cex", FileFormatVersions.Office2021 },
            { "http://schemas.microsoft.com/office/word/2020/wordml/sdtdatahash"  , "w16sdtdh", FileFormatVersions.Office2021 },
            { "http://schemas.microsoft.com/office/spreadsheetml/2019/namedsheetviews"  , "xnsv", FileFormatVersions.Office2021 },
            { "http://schemas.microsoft.com/office/spreadsheetml/2020/richdatawebimage"  , "xlrdwi", FileFormatVersions.Office2021 },
            { "http://schemas.microsoft.com/office/spreadsheetml/2020/threadedcomments2"  , "xltc2", FileFormatVersions.Office2021 },
            { "http://schemas.microsoft.com/office/spreadsheetml/2018/08/main"  , "x16r3", FileFormatVersions.Office2021 },
            { "http://schemas.microsoft.com/office/spreadsheetml/2019/extlinksprops"  , "xxlnp", FileFormatVersions.Office2021 },
            { "http://schemas.microsoft.com/office/spreadsheetml/2020/richvaluerefresh"  , "xlrvr", FileFormatVersions.Office2021 },
            { "http://schemas.microsoft.com/office/spreadsheetml/2020/pivotNov2020"  , "xxpim", FileFormatVersions.Office2021 },
            { "http://schemas.microsoft.com/office/powerpoint/2019/12/main"  , "ppt1912SchemaUri", FileFormatVersions.Office2021 },
        };

        internal static int Count => _namespaceResolver.Count;

        // The namespaces listed here are somewhat obsolete ones that we need to support. Before we try to get the index of a namespace,
        // we check if it's in this list to rename to the expected correct namespace.
        private static readonly Dictionary<OpenXmlNamespace, OpenXmlNamespace> _extendedNamespaces = new Dictionary<OpenXmlNamespace, OpenXmlNamespace>
        {
            { "http://schemas.openxmlformats.org/wordprocessingml/2006/3/main", "http://schemas.openxmlformats.org/wordprocessingml/2006/main" },
            { "http://schemas.openxmlformats.org/wordprocessingml/2006/5/main", "http://schemas.openxmlformats.org/wordprocessingml/2006/main" },
            { "http://schemas.openxmlformats.org/wordprocessingml/2006/6/main", "http://schemas.openxmlformats.org/wordprocessingml/2006/main" },
            { "http://schemas.openxmlformats.org/spreadsheetml/2006/5/main", "http://schemas.openxmlformats.org/spreadsheetml/2006/main" },
            { "http://schemas.openxmlformats.org/spreadsheetml/2006/7/main", "http://schemas.openxmlformats.org/spreadsheetml/2006/main" },
            { "http://schemas.openxmlformats.org/presentationml/2006/3/main", "http://schemas.openxmlformats.org/presentationml/2006/main" },
            { "http://schemas.openxmlformats.org/drawingml/2006/3/main", "http://schemas.openxmlformats.org/drawingml/2006/main" },
            { "http://schemas.microsoft.com/office/word/2010/11/wordml", "http://schemas.microsoft.com/office/word/2012/wordml" },
        };

        // This dictionary contains the Strict and Transitional namespaces pairs to be interpreted equivalent.
        private static readonly Dictionary<OpenXmlNamespace, OpenXmlNamespace> _strictTransitionalNamespaces = new Dictionary<OpenXmlNamespace, OpenXmlNamespace>
        {
            // Namespaces
            { "http://purl.oclc.org/ooxml/descriptions/base", "http://descriptions.openxmlformats.org/description/base" },
            { "http://purl.oclc.org/ooxml/descriptions/full", "http://descriptions.openxmlformats.org/description/full" },
            { "http://purl.oclc.org/ooxml/drawingml/chart", "http://schemas.openxmlformats.org/drawingml/2006/chart" },
            { "http://purl.oclc.org/ooxml/drawingml/chartDrawing", "http://schemas.openxmlformats.org/drawingml/2006/chartDrawing" },
            { "http://purl.oclc.org/ooxml/drawingml/diagram", "http://schemas.openxmlformats.org/drawingml/2006/diagram" },
            { "http://purl.oclc.org/ooxml/drawingml/main", "http://schemas.openxmlformats.org/drawingml/2006/main" },
            { "http://purl.oclc.org/ooxml/drawingml/picture", "http://schemas.openxmlformats.org/drawingml/2006/picture" },
            { "http://purl.oclc.org/ooxml/drawingml/spreadsheetDrawing", "http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing" },
            { "http://purl.oclc.org/ooxml/drawingml/wordprocessingDrawing", "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing" },
            { "http://purl.oclc.org/ooxml/officeDocument/bibliography", "http://schemas.openxmlformats.org/officeDocument/2006/bibliography" },
            { "http://purl.oclc.org/ooxml/officeDocument/customProperties", "http://schemas.openxmlformats.org/officeDocument/2006/custom-properties" },
            { "http://purl.oclc.org/ooxml/officeDocument/customXml", "http://schemas.openxmlformats.org/officeDocument/2006/customXml" },
            { "http://purl.oclc.org/ooxml/officeDocument/customXmlDataProps", "http://schemas.openxmlformats.org/officeDocument/2006/customXmlDataProps" },
            { "http://purl.oclc.org/ooxml/officeDocument/docPropsVTypes", "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes" },
            { "http://purl.oclc.org/ooxml/officeDocument/extendedProperties", "http://schemas.openxmlformats.org/officeDocument/2006/extended-properties" },
            { "http://purl.oclc.org/ooxml/officeDocument/math", "http://schemas.openxmlformats.org/officeDocument/2006/math" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships", "http://schemas.openxmlformats.org/officeDocument/2006/relationships" },
            { "http://purl.oclc.org/ooxml/presentationml/main", "http://schemas.openxmlformats.org/presentationml/2006/main" },
            { "http://purl.oclc.org/ooxml/schemaLibrary/main", "http://schemas.openxmlformats.org/schemaLibrary/2006/main" },
            { "http://purl.oclc.org/ooxml/spreadsheetml/main", "http://schemas.openxmlformats.org/spreadsheetml/2006/main" },
            { "http://purl.oclc.org/ooxml/wordprocessingml/main", "http://schemas.openxmlformats.org/wordprocessingml/2006/main" },
            { "http://purl.org/dc/dcmitype/", "http://purl.org/dc/dcmitype/" },
            { "http://purl.org/dc/elements/1.1/", "http://purl.org/dc/elements/1.1/" },
            { "http://purl.org/dc/terms/", "http://purl.org/dc/terms/" },
            { "http://www.w3.org/2001/XMLSchema", "http://www.w3.org/2001/XMLSchema" },
            { "http://www.w3.org/2001/XMLSchema-instance", "http://www.w3.org/2001/XMLSchema-instance" },
            { "http://purl.oclc.org/ooxml/drawingml/lockedCanvas", "http://schemas.openxmlformats.org/drawingml/2006/lockedCanvas" },
            { "http://purl.oclc.org/ooxml/drawingml/compatibility", "http://schemas.openxmlformats.org/drawingml/2006/compatibility" },
            { "http://purl.oclc.org/ooxml/officeDocument/sharedTypes", "http://schemas.openxmlformats.org/officeDocument/2006/sharedTypes" },

            // This is a namespace conversion. Workaround for a bug in ISO spec. https://www.assembla.com/code/IS29500/subversion/changesets/160
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/customXml", "http://schemas.openxmlformats.org/officeDocument/2006/customXml" },
        };

        // This dictionary contains the Strict and Transitional relationship pairs to be interpreted equivalent.
        private static readonly Dictionary<OpenXmlNamespace, OpenXmlNamespace> _strictTransitionalRelationshipPairs = new Dictionary<OpenXmlNamespace, OpenXmlNamespace>
        {
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/aFChunk", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/aFChunk" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/attachedTemplate", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/attachedTemplate" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/audio", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/audio" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/calcChain", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/calcChain" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/chart", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chart" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/chartsheet", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chartsheet" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/chartUserShapes", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chartUserShapes" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/commentAuthors", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/commentAuthors" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/comments", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/comments" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/connections", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/connections" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/control", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/control" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/customProperties", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/custom-properties" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/customProperty", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customProperty" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/customXml", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXml" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/customXmlProps", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXmlProps" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/diagramColors", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramColors" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/diagramData", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramData" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/diagramLayout", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramLayout" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/diagramQuickStyle", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramQuickStyle" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/dialogsheet", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/dialogsheet" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/drawing", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/drawing" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/endnotes", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/endnotes" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/extendedProperties", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/extended-properties" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/externalLink", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/externalLink" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/externalLinkPath", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/externalLinkPath" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/font", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/font" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/fontTable", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/fontTable" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/footer", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/footer" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/footnotes", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/footnotes" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/frame", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/frame" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/glossaryDocument", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/glossaryDocument" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/handoutMaster", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/handoutMaster" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/header", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/header" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/htmlPubSaveAs", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/htmlPubSaveAs" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/hyperlink", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/hyperlink" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/image", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/mailMergeHeaderSource", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/mailMergeHeaderSource" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/mailMergeRecipientData", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/mailMergeRecipientData" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/mailMergeSource", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/mailMergeSource" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/metadata/thumbnail", "http://schemas.openxmlformats.org/package/2006/relationships/metadata/thumbnail" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/movie", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/movie" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/notesMaster", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/notesMaster" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/notesSlide", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/notesSlide" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/numbering", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/numbering" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/officeDocument", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/oleObject", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/package", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/package" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/pivotCacheDefinition", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotCacheDefinition" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/pivotCacheRecords", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotCacheRecords" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/pivotTable", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotTable" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/presProps", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/presProps" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/printerSettings", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/printerSettings" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/queryTable", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/queryTable" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/revisionHeaders", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/revisionHeaders" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/revisionLog", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/revisionLog" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/settings", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/settings" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/sharedStrings", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/sharedStrings" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/sheetMetadata", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/sheetMetadata" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/slide", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slide" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/slideLayout", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slideLayout" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/slideMaster", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slideMaster" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/slideUpdateInfo", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slideUpdateInfo" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/slideUpdateUrl", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slideUpdateUrl" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/styles", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/styles" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/subDocument", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/subDocument" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/table", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/table" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/tableSingleCells", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/tableSingleCells" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/tableStyles", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/tableStyles" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/tags", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/tags" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/theme", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/theme" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/themeOverride", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/themeOverride" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/transform", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/transform" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/usernames", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/usernames" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/video", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/video" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/viewProps", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/viewProps" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/volatileDependencies", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/volatileDependencies" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/webSettings", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/webSettings" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/worksheet", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/worksheet" },
            { "http://purl.oclc.org/ooxml/officeDocument/relationships/xmlMaps", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/xmlMaps" },
        };

        private class NamespaceResolver : IEnumerable
        {
            private readonly Dictionary<string, NamespaceInfo> _byNamespace = new Dictionary<string, NamespaceInfo>(StringComparer.Ordinal);
            private readonly Dictionary<string, NamespaceInfo> _byPrefix = new Dictionary<string, NamespaceInfo>(StringComparer.Ordinal);
            private readonly List<NamespaceInfo> _info = new List<NamespaceInfo>();

            public int Count => _info.Count;

            public void Add(string @namespace, string prefix, FileFormatVersions version)
            {
                var info = new NamespaceInfo(@namespace, prefix, version, (byte)_info.Count);

                _byNamespace.Add(@namespace, info);
                _byPrefix.Add(prefix, info);
                _info.Add(info);
            }

            public NamespaceInfo this[int id] => _info[id];

            public bool TryGetByNamespace(string ns, [MaybeNullWhen(false)] out NamespaceInfo info) => _byNamespace.TryGetValue(ns, out info);

            public bool TryGetByPrefix(string prefix, [MaybeNullWhen(false)] out NamespaceInfo info) => _byPrefix.TryGetValue(prefix, out info);

            IEnumerator IEnumerable.GetEnumerator() => _info.GetEnumerator();

            public class NamespaceInfo
            {
                public NamespaceInfo(string ns, string prefix, FileFormatVersions version, byte id)
                {
                    Namespace = ns;
                    Prefix = prefix;
                    Version = version;
                    Id = id;
                }

                public string Namespace { get; }

                public string Prefix { get; }

                public FileFormatVersions Version { get; }

                public byte Id { get; }
            }
        }
    }
}
