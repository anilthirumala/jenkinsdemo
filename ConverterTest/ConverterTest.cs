using NUnit.Framework;
using ConverterLibrary;
namespace ConverterTest
{
    public class ConverterTest
    {
        Converter converter;
        public ConverterTest()
        {
            converter = new Converter();
        }
        [Test]
        public void TestMeterToCmSuccess()
        {
            Assert.That(converter.MeterToCM(34), Is.EqualTo(3400));
        }
        [Test]
        public void TestMeterToKm()
        {
            var result = converter.MeterToKm(5200);
            Assert.That(result, Is.EqualTo(5.2));
        }
    }
}