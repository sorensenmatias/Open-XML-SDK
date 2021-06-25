﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Presentation;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    public class OpenXmlElementParsingTests
    {
        [Fact]
        public void ParseXmlWithEmbeddedXml()
        {
            //This test is asserting that an element with embedded Xml can be parsed.
            //This previously crashed with exception System.ObjectDisposedException Cannot read from a closed TextReader.
            const string OuterXml = "<p:cNvPr xmlns:p=\"http://schemas.openxmlformats.org/presentationml/2006/main\" id=\"4\" name=\"[WorkArea]\" descr=\"&lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-16&quot;?&gt;&#xA;&lt;GridTheme xmlns:xsi=&quot;http://www.w3.org/2001/XMLSchema-instance&quot; xmlns:xsd=&quot;http://www.w3.org/2001/XMLSchema&quot;&gt;&#xA;  &lt;GuideLines /&gt;&#xA;  &lt;SubGrids&gt;&#xA;    &lt;SubGrid&gt;&#xA;      &lt;Left&gt;28.3465347&lt;/Left&gt;&#xA;      &lt;Top&gt;28.3464565&lt;/Top&gt;&#xA;      &lt;Width&gt;42.5196075&lt;/Width&gt;&#xA;      &lt;Height&gt;483.3071&lt;/Height&gt;&#xA;    &lt;/SubGrid&gt;&#xA;    &lt;SubGrid&gt;&#xA;      &lt;Left&gt;70.86614&lt;/Left&gt;&#xA;      &lt;Top&gt;28.3464565&lt;/Top&gt;&#xA;      &lt;Width&gt;14.1732283&lt;/Width&gt;&#xA;      &lt;Height&gt;483.3071&lt;/Height&gt;&#xA;    &lt;/SubGrid&gt;&#xA;    &lt;SubGrid&gt;&#xA;      &lt;Left&gt;888.8652&lt;/Left&gt;&#xA;      &lt;Top&gt;28.3464565&lt;/Top&gt;&#xA;      &lt;Width&gt;42.5196838&lt;/Width&gt;&#xA;      &lt;Height&gt;483.3071&lt;/Height&gt;&#xA;    &lt;/SubGrid&gt;&#xA;    &lt;SubGrid&gt;&#xA;      &lt;Left&gt;151.275589&lt;/Left&gt;&#xA;      &lt;Top&gt;28.3464565&lt;/Top&gt;&#xA;      &lt;Width&gt;14.1732283&lt;/Width&gt;&#xA;      &lt;Height&gt;483.3071&lt;/Height&gt;&#xA;    &lt;/SubGrid&gt;&#xA;    &lt;SubGrid&gt;&#xA;      &lt;Left&gt;874.691956&lt;/Left&gt;&#xA;      &lt;Top&gt;28.3463&lt;/Top&gt;&#xA;      &lt;Width&gt;14.1732283&lt;/Width&gt;&#xA;      &lt;Height&gt;483.307&lt;/Height&gt;&#xA;    &lt;/SubGrid&gt;&#xA;    &lt;SubGrid&gt;&#xA;      &lt;Left&gt;85.03937&lt;/Left&gt;&#xA;      &lt;Top&gt;28.3464565&lt;/Top&gt;&#xA;      &lt;Width&gt;66.23622&lt;/Width&gt;&#xA;      &lt;Height&gt;483.3071&lt;/Height&gt;&#xA;    &lt;/SubGrid&gt;&#xA;    &lt;SubGrid&gt;&#xA;      &lt;Left&gt;231.685043&lt;/Left&gt;&#xA;      &lt;Top&gt;28.3464565&lt;/Top&gt;&#xA;      &lt;Width&gt;14.1732283&lt;/Width&gt;&#xA;      &lt;Height&gt;483.3071&lt;/Height&gt;&#xA;    &lt;/SubGrid&gt;&#xA;    &lt;SubGrid&gt;&#xA;      &lt;Left&gt;165.448822&lt;/Left&gt;&#xA;      &lt;Top&gt;28.3464565&lt;/Top&gt;&#xA;      &lt;Width&gt;66.23622&lt;/Width&gt;&#xA;      &lt;Height&gt;483.3071&lt;/Height&gt;&#xA;    &lt;/SubGrid&gt;&#xA;    &lt;SubGrid&gt;&#xA;      &lt;Left&gt;312.094482&lt;/Left&gt;&#xA;      &lt;Top&gt;28.3464565&lt;/Top&gt;&#xA;      &lt;Width&gt;14.1732283&lt;/Width&gt;&#xA;      &lt;Height&gt;483.3071&lt;/Height&gt;&#xA;    &lt;/SubGrid&gt;&#xA;    &lt;SubGrid&gt;&#xA;      &lt;Left&gt;245.858261&lt;/Left&gt;&#xA;      &lt;Top&gt;28.3464565&lt;/Top&gt;&#xA;      &lt;Width&gt;66.23622&lt;/Width&gt;&#xA;      &lt;Height&gt;483.3071&lt;/Height&gt;&#xA;    &lt;/SubGrid&gt;&#xA;    &lt;SubGrid&gt;&#xA;      &lt;Left&gt;392.503937&lt;/Left&gt;&#xA;      &lt;Top&gt;28.3464565&lt;/Top&gt;&#xA;      &lt;Width&gt;14.1732283&lt;/Width&gt;&#xA;      &lt;Height&gt;483.3071&lt;/Height&gt;&#xA;    &lt;/SubGrid&gt;&#xA;    &lt;SubGrid&gt;&#xA;      &lt;Left&gt;326.267731&lt;/Left&gt;&#xA;      &lt;Top&gt;28.3464565&lt;/Top&gt;&#xA;      &lt;Width&gt;66.23622&lt;/Width&gt;&#xA;      &lt;Height&gt;483.3071&lt;/Height&gt;&#xA;    &lt;/SubGrid&gt;&#xA;    &lt;SubGrid&gt;&#xA;      &lt;Left&gt;472.779053&lt;/Left&gt;&#xA;      &lt;Top&gt;28.3464565&lt;/Top&gt;&#xA;      &lt;Width&gt;14.1732283&lt;/Width&gt;&#xA;      &lt;Height&gt;483.3071&lt;/Height&gt;&#xA;    &lt;/SubGrid&gt;&#xA;    &lt;SubGrid&gt;&#xA;      &lt;Left&gt;406.542847&lt;/Left&gt;&#xA;      &lt;Top&gt;28.3464565&lt;/Top&gt;&#xA;      &lt;Width&gt;66.23622&lt;/Width&gt;&#xA;      &lt;Height&gt;483.3071&lt;/Height&gt;&#xA;    &lt;/SubGrid&gt;&#xA;    &lt;SubGrid&gt;&#xA;      &lt;Left&gt;553.1885&lt;/Left&gt;&#xA;      &lt;Top&gt;28.3464565&lt;/Top&gt;&#xA;      &lt;Width&gt;14.1732283&lt;/Width&gt;&#xA;      &lt;Height&gt;483.3071&lt;/Height&gt;&#xA;    &lt;/SubGrid&gt;&#xA;    &lt;SubGrid&gt;&#xA;      &lt;Left&gt;486.952271&lt;/Left&gt;&#xA;      &lt;Top&gt;28.3464565&lt;/Top&gt;&#xA;      &lt;Width&gt;66.23622&lt;/Width&gt;&#xA;      &lt;Height&gt;483.3071&lt;/Height&gt;&#xA;    &lt;/SubGrid&gt;&#xA;    &lt;SubGrid&gt;&#xA;      &lt;Left&gt;633.597961&lt;/Left&gt;&#xA;      &lt;Top&gt;28.3464565&lt;/Top&gt;&#xA;      &lt;Width&gt;14.1732283&lt;/Width&gt;&#xA;      &lt;Height&gt;483.3071&lt;/Height&gt;&#xA;    &lt;/SubGrid&gt;&#xA;    &lt;SubGrid&gt;&#xA;      &lt;Left&gt;567.361755&lt;/Left&gt;&#xA;      &lt;Top&gt;28.3464565&lt;/Top&gt;&#xA;      &lt;Width&gt;66.23622&lt;/Width&gt;&#xA;      &lt;Height&gt;483.3071&lt;/Height&gt;&#xA;    &lt;/SubGrid&gt;&#xA;    &lt;SubGrid&gt;&#xA;      &lt;Left&gt;714.0074&lt;/Left&gt;&#xA;      &lt;Top&gt;28.3464565&lt;/Top&gt;&#xA;      &lt;Width&gt;14.1732283&lt;/Width&gt;&#xA;      &lt;Height&gt;483.3071&lt;/Height&gt;&#xA;    &lt;/SubGrid&gt;&#xA;    &lt;SubGrid&gt;&#xA;      &lt;Left&gt;647.7712&lt;/Left&gt;&#xA;      &lt;Top&gt;28.3464565&lt;/Top&gt;&#xA;      &lt;Width&gt;66.23622&lt;/Width&gt;&#xA;      &lt;Height&gt;483.3071&lt;/Height&gt;&#xA;    &lt;/SubGrid&gt;&#xA;    &lt;SubGrid&gt;&#xA;      &lt;Left&gt;794.282532&lt;/Left&gt;&#xA;      &lt;Top&gt;28.3460636&lt;/Top&gt;&#xA;      &lt;Width&gt;14.1732283&lt;/Width&gt;&#xA;      &lt;Height&gt;483.3071&lt;/Height&gt;&#xA;    &lt;/SubGrid&gt;&#xA;    &lt;SubGrid&gt;&#xA;      &lt;Left&gt;728.0463&lt;/Left&gt;&#xA;      &lt;Top&gt;28.3460636&lt;/Top&gt;&#xA;      &lt;Width&gt;66.23622&lt;/Width&gt;&#xA;      &lt;Height&gt;483.3071&lt;/Height&gt;&#xA;    &lt;/SubGrid&gt;&#xA;    &lt;SubGrid&gt;&#xA;      &lt;Left&gt;808.45575&lt;/Left&gt;&#xA;      &lt;Top&gt;28.3460636&lt;/Top&gt;&#xA;      &lt;Width&gt;66.23622&lt;/Width&gt;&#xA;      &lt;Height&gt;483.3071&lt;/Height&gt;&#xA;    &lt;/SubGrid&gt;&#xA;  &lt;/SubGrids&gt;&#xA;  &lt;WorkArea&gt;&#xA;    &lt;Top&gt;28.3460636&lt;/Top&gt;&#xA;    &lt;Left&gt;28.3465347&lt;/Left&gt;&#xA;    &lt;Width&gt;903.0383&lt;/Width&gt;&#xA;    &lt;Height&gt;483.3075&lt;/Height&gt;&#xA;  &lt;/WorkArea&gt;&#xA;  &lt;AspectW&gt;16&lt;/AspectW&gt;&#xA;  &lt;AspectH&gt;9&lt;/AspectH&gt;&#xA;  &lt;Width&gt;960&lt;/Width&gt;&#xA;  &lt;Height&gt;540&lt;/Height&gt;&#xA;  &lt;HGap&gt;10&lt;/HGap&gt;&#xA;  &lt;VGap&gt;10&lt;/VGap&gt;&#xA;  &lt;OfficeVersion&gt;16&lt;/OfficeVersion&gt;&#xA;&lt;/GridTheme&gt;\" hidden=\"1\">";
            var properties = new NonVisualDrawingProperties(OuterXml);
            Assert.NotNull(properties);
        }
    }
}
