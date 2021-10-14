using System.IO;
using System.Linq;
using System.Reflection;
using DocumentFormat.OpenXml.Packaging;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    public class TemporaryTests
    {
        [Fact]
        public void TemplateWithoutApp()
        {
            using (var stream = GetStream(TestAssets.TestFiles.TemplateWithoutApp, true))
            using (var doc = WordprocessingDocument.Open(stream, true))
            {
                doc.AddCoreFilePropertiesPart();
                doc.MainDocumentPart.OpenXmlPackage.PackageProperties.Category = "g";
            }
        }

        /// <summary>
        /// Gets a readonly stream for a test file
        /// </summary>
        /// <param name="name">Name of embedded resource</param>
        /// <returns></returns>
        public static Stream GetStream(string name)
        {
            var assembly = typeof(TestAssets.TestFiles).GetTypeInfo().Assembly;
            var stream = assembly.GetManifestResourceStream($"DocumentFormat.OpenXml.Tests.Assets.assets.{name}");
            var names = assembly.GetManifestResourceNames().OrderBy(t => t).ToList();

            Assert.NotNull(stream);

            return stream;
        }

        public static Stream GetStream(string name, bool isEditable)
        {
            var stream = GetStream(name);

            return isEditable ? AsMemoryStream(stream) : stream;
        }

        private static Stream AsMemoryStream(Stream stream)
        {
            if (stream is MemoryStream ms)
            {
                return ms;
            }
            else
            {
                using (stream)
                {
                    var result = new MemoryStream();
                    stream.CopyTo(result);
                    return result;
                }
            }
        }
    }
}
