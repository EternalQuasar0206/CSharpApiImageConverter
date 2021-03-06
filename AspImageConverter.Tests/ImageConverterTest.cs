using Xunit;
using AspImageConverter.Conversion;
using System.Threading.Tasks;
using System.IO;

namespace Tests
{
    public class ImageConverterTest
    {
        [Fact]
        public async Task ImageConversionIntegrity() {
            string file = "iVBORw0KGgoAAAANSUhEUgAAAAUAAAAFCAYAAACNbyblAAAAHElEQVQI12P4//8/w38GIAXDIBKE0DHxgljNBAAO9TXL0Y4OHwAAAABJRU5ErkJggg==";
            MemoryStream result = await ImageConverter.GetStream(file, "jpg");
            Assert.NotEqual(0, result.Length);
        }
    }
}