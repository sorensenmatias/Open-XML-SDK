﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    public class FileFormatVersionExtensionsTests
    {
        [InlineData(FileFormatVersions.None, false)]
        [InlineData(FileFormatVersions.Office2007, true)]
        [InlineData(FileFormatVersions.Office2010, true)]
        [InlineData(FileFormatVersions.Office2013, true)]
        [InlineData(FileFormatVersions.Office2016, true)]
        [InlineData(FileFormatVersions.Office2019, true)]
        [InlineData(FileFormatVersions.Office2021, true)]
        [InlineData(FileFormatVersions.Office2007 | FileFormatVersions.Office2010, false)]
        [InlineData(FileFormatVersions.Office2007 | FileFormatVersions.Office2013, false)]
        [InlineData(FileFormatVersions.Office2010 | FileFormatVersions.Office2013, false)]
        [InlineData(FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013, false)]
        [InlineData(FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2016, false)]
        [InlineData(FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013 | FileFormatVersions.Office2016, false)]
        [InlineData(FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013 | FileFormatVersions.Office2016 | FileFormatVersions.Office2019, false)]
        [InlineData(FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013 | FileFormatVersions.Office2016 | FileFormatVersions.Office2019 | FileFormatVersions.Office2021, false)]
        [Theory]
        public void CheckAny(FileFormatVersions version, bool expected)
        {
            Assert.Equal(expected, version.Any());
        }

        [InlineData(FileFormatVersions.None, false)]
        [InlineData(FileFormatVersions.Office2007, false)]
        [InlineData(FileFormatVersions.Office2010, false)]
        [InlineData(FileFormatVersions.Office2013, false)]
        [InlineData(FileFormatVersions.Office2016, false)]
        [InlineData(FileFormatVersions.Office2007 | FileFormatVersions.Office2010, false)]
        [InlineData(FileFormatVersions.Office2007 | FileFormatVersions.Office2013, false)]
        [InlineData(FileFormatVersions.Office2010 | FileFormatVersions.Office2013, false)]
        [InlineData(FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013, false)]
        [InlineData(FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013 | FileFormatVersions.Office2016, false)]
        [InlineData(FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013 | FileFormatVersions.Office2016 | FileFormatVersions.Office2019, false)]
        [InlineData(FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013 | FileFormatVersions.Office2016 | FileFormatVersions.Office2019 | FileFormatVersions.Office2021, true)]
        [Theory]
        public void CheckAll(FileFormatVersions version, bool expected)
        {
            Assert.Equal(expected, version.All());
        }

        [InlineData(FileFormatVersions.None)]
        [InlineData(FileFormatVersions.Office2007 | FileFormatVersions.Office2010)]
        [InlineData(FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
        [InlineData(FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
        [InlineData(FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2016)]
        [InlineData(FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013 | FileFormatVersions.Office2016)]
        [InlineData(FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013 | FileFormatVersions.Office2016 | FileFormatVersions.Office2019)]
        [InlineData(FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013 | FileFormatVersions.Office2016 | FileFormatVersions.Office2019 | FileFormatVersions.Office2021)]
        [Theory]
        public void AndLaterExceptions(FileFormatVersions version)
        {
            Assert.Throws<ArgumentOutOfRangeException>(nameof(version), () => version.AndLater());
        }

        [InlineData(FileFormatVersions.Office2007, FileFormatVersions.Office2007, true)]
        [InlineData(FileFormatVersions.Office2007 | FileFormatVersions.Office2010, FileFormatVersions.Office2007, true)]
        [InlineData(FileFormatVersions.Office2010, FileFormatVersions.Office2007, true)]
        [InlineData(FileFormatVersions.Office2013, FileFormatVersions.Office2007, true)]
        [InlineData(FileFormatVersions.Office2016, FileFormatVersions.Office2007, true)]
        [InlineData(FileFormatVersions.Office2019, FileFormatVersions.Office2007, true)]
        [InlineData(FileFormatVersions.Office2021, FileFormatVersions.Office2007, true)]
        [InlineData(FileFormatVersions.Office2007, FileFormatVersions.Office2010, false)]
        [InlineData(FileFormatVersions.Office2010, FileFormatVersions.Office2010, true)]
        [InlineData(FileFormatVersions.Office2010 | FileFormatVersions.Office2013, FileFormatVersions.Office2010, true)]
        [InlineData(FileFormatVersions.Office2013, FileFormatVersions.Office2010, true)]
        [InlineData(FileFormatVersions.Office2016, FileFormatVersions.Office2010, true)]
        [InlineData(FileFormatVersions.Office2019, FileFormatVersions.Office2010, true)]
        [InlineData(FileFormatVersions.Office2021, FileFormatVersions.Office2010, true)]
        [InlineData(FileFormatVersions.Office2007, FileFormatVersions.Office2013, false)]
        [InlineData(FileFormatVersions.Office2010, FileFormatVersions.Office2013, false)]
        [InlineData(FileFormatVersions.Office2013, FileFormatVersions.Office2013, true)]
        [InlineData(FileFormatVersions.Office2016, FileFormatVersions.Office2013, true)]
        [InlineData(FileFormatVersions.Office2019, FileFormatVersions.Office2013, true)]
        [InlineData(FileFormatVersions.Office2021, FileFormatVersions.Office2013, true)]
        [InlineData(FileFormatVersions.Office2013 | FileFormatVersions.Office2016, FileFormatVersions.Office2013, true)]
        [InlineData(FileFormatVersions.Office2007, FileFormatVersions.Office2016, false)]
        [InlineData(FileFormatVersions.Office2010, FileFormatVersions.Office2016, false)]
        [InlineData(FileFormatVersions.Office2013, FileFormatVersions.Office2016, false)]
        [InlineData(FileFormatVersions.Office2016, FileFormatVersions.Office2016, true)]
        [InlineData(FileFormatVersions.Office2021, FileFormatVersions.Office2016, true)]
        [InlineData(FileFormatVersions.Office2016 | FileFormatVersions.Office2019, FileFormatVersions.Office2016, true)]
        [InlineData(FileFormatVersions.Office2007, FileFormatVersions.Office2019, false)]
        [InlineData(FileFormatVersions.Office2010, FileFormatVersions.Office2019, false)]
        [InlineData(FileFormatVersions.Office2013, FileFormatVersions.Office2019, false)]
        [InlineData(FileFormatVersions.Office2016, FileFormatVersions.Office2019, false)]
        [InlineData(FileFormatVersions.Office2019, FileFormatVersions.Office2019, true)]
        [InlineData(FileFormatVersions.Office2021, FileFormatVersions.Office2019, true)]

        [Theory]
        public void CheckAtLeast(FileFormatVersions version, FileFormatVersions minimum, bool expected)
        {
            Assert.Equal(expected, version.AtLeast(minimum));
        }

        [InlineData((FileFormatVersions)(2 << 6))]
        [Theory]
        public void AtLeastExceptions(FileFormatVersions version)
        {
            Assert.Throws<ArgumentOutOfRangeException>(nameof(version), () => version.AtLeast(FileFormatVersions.Office2007));
            Assert.Throws<ArgumentOutOfRangeException>("minimum", () => FileFormatVersions.Office2007.AtLeast(version));
        }

        [MemberData(nameof(AllOfficeVersions))]
        [Theory]
        public void ValidateElementThrows(FileFormatVersions version)
        {
            var name = version.ToString().Substring("Office".Length);
            var element = new OfficeNonElement();

            var exception = Assert.Throws<InvalidOperationException>(() => version.ThrowIfNotInVersion(element));

            Assert.Contains($" {name} ", exception.Message);
        }

        [MemberData(nameof(AllOfficeVersions))]
        [Theory]
        public void ValidatePartThrows(FileFormatVersions version)
        {
            var name = version.ToString().Substring("Office".Length);
            var part = Substitute.ForPartsOf<OpenXmlPart>();

            part.IsInVersion(Arg.Any<FileFormatVersions>()).Returns(false);

            var exception = Assert.Throws<InvalidOperationException>(() => version.ThrowIfNotInVersion(part));
            Assert.Contains($" {name} ", exception.Message);
        }

        [InlineData(FileFormatVersions.None)]
        [InlineData(FileFormatVersions.Office2007 | FileFormatVersions.Office2010)]
        [InlineData((FileFormatVersions)(2 << 10))]
        [Theory]
        public void ArgumentOutOfRangeWhenInvalidForPart(FileFormatVersions version)
        {
            const string ParamName = "version";

            Assert.True(version == default || !Enum.IsDefined(typeof(FileFormatVersions), version));

            var part = Substitute.ForPartsOf<OpenXmlPart>();
            part.IsInVersion(Arg.Any<FileFormatVersions>()).Returns(true);

            Assert.Throws<ArgumentOutOfRangeException>(ParamName, () => version.ThrowIfNotInVersion(part));
        }

        [InlineData(FileFormatVersions.None)]
        [InlineData(FileFormatVersions.Office2007 | FileFormatVersions.Office2010)]
        [InlineData((FileFormatVersions)(2 << 10))]
        [Theory]
        public void ArgumentOutOfRangeWhenInvalidForElement(FileFormatVersions version)
        {
            const string ParamName = "version";

            Assert.True(version == default || !Enum.IsDefined(typeof(FileFormatVersions), version));

            var element = new Office2007Element();

            Assert.Throws<ArgumentOutOfRangeException>(ParamName, () => version.ThrowIfNotInVersion(element));
        }

        public static IEnumerable<object[]> AllOfficeVersions()
        {
            var values = Enum.GetValues(typeof(FileFormatVersions))
                .Cast<FileFormatVersions>()
                .Where(v => v != FileFormatVersions.None);

            foreach (var version in values)
            {
                yield return new object[] { version };
            }
        }

        private class OfficeNonElement : MockedOpenXmlElement
        {
            internal override void ConfigureMetadata(ElementMetadata.Builder builder)
            {
                builder.Availability = FileFormatVersions.None;
            }
        }

        private class Office2007Element : MockedOpenXmlElement
        {
            internal override void ConfigureMetadata(ElementMetadata.Builder builder)
            {
                builder.Availability = FileFormatVersions.Office2007;
            }
        }
    }
}
