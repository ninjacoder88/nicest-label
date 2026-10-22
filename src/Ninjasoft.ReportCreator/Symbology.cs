namespace Ninjasoft.ReportCreator
{
    public sealed class Symbology
    {
        private Symbology(string name, string startCode, string stopCode, int value)
        {
            Name = name;
            StartCode = startCode;
            StopCode = stopCode;
            Value = value;
        }
        
        public static Symbology Code128A = new ("Code 128A", "11010000100", "1100011101011", 103);
        public static Symbology Code128B = new ("Code 128B", "11010010000", "1100011101011", 104);
        public static Symbology Code128C = new ("Code 128C", "11010011100", "1100011101011", 105);

        public string Name { get; }

        public string StartCode { get; }

        public string StopCode { get; }

        public int Value { get; }
    }
}