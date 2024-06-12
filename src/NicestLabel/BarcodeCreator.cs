namespace NicestLabel
{
    internal sealed class BarcodeCreator
    {
        public BarcodeCreator(Symbology symbology)
        {
            _symbology = symbology;
        }

        public string Create(string text)
        {
            char[] chars = text.ToCharArray();

            string barcodePattern = _symbology.StartCode;
            int sum = _symbology.Value;

            for (int i = 0; i < chars.Length; i++)
            {
                int asciiValue = chars[i];
                CharacterValue cv = Code128Map.CharacterMap[asciiValue];

                barcodePattern += cv.Pattern;
                sum += ((i + 1) * cv.Value);
            }

            int rem = sum % 103;
            string checkSumPattern = Code128Map.ValueMap[rem].Pattern;
            barcodePattern += checkSumPattern;
            barcodePattern += _symbology.StopCode;

            return barcodePattern;
        }

        private readonly Symbology _symbology;
    }
}
