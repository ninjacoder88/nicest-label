namespace NicestLabel.UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            string str = new BarcodeCreator(Symbology.Code128B).Create("ABC");
            Assert.That(str, Is.EqualTo("11010010000101000110001000101100010001000110110011011001100011101011"));
        }
    }
}