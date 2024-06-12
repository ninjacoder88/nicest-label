namespace NicestLabel.IntegrationTests
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
            new LabelBuilder(100, 250)
                .AddText("hello", 10, 10)
                .AddBarcode("ABC", 10, 50, Symbology.Code128A)
                .Build(@"d:\temp\label-ABC-A.png");

            new LabelBuilder(100, 250)
                .AddText("hello", 10, 10)
                .AddBarcode("ABC", 10, 50, Symbology.Code128B)
                .Build(@"d:\temp\label-ABC-B.png");
        }
    }
}