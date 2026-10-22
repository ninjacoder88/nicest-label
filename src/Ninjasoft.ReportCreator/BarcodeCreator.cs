namespace Ninjasoft.ReportCreator
{
    internal static class BarcodeCreator
    {
        public static string Create(string text, Symbology symbology)
        {
            if(symbology == Symbology.Code128A || symbology == Symbology.Code128B)
            {
                char[] chars = text.ToCharArray();

                string barcodePattern = symbology.StartCode;
                int sum = symbology.Value;

                for (int i = 0; i < chars.Length; i++)
                {
                    int asciiValue = chars[i];
                    Code128CharcterValue cv = Code128Map.CharacterMap[asciiValue];

                    barcodePattern += cv.Pattern;
                    sum += ((i + 1) * cv.Value);
                }

                int rem = sum % 103;
                string checkSumPattern = Code128Map.ValueMap[rem].Pattern;
                barcodePattern += checkSumPattern;
                barcodePattern += symbology.StopCode;

                return barcodePattern;
            }

            if(symbology == Symbology.Code128C)
            {
                if(!int.TryParse(text, out int number))
                    throw new Exception("Invalid input for Code 128C. Must be a number");
                if(number < 0)
                    throw new Exception("Invalid input for Code 128C. Must be a positive number");

                if(text.Length % 2 == 1)
                    text = "0" + text;
                
                char[] chars = text.ToCharArray();
                
                string barcodePattern = symbology.StartCode;
                int sum = symbology.Value;

                for(int i = 0; i < chars.Length; i+=2)
                {
                    string s = new([chars[i], chars[i+1]]);
                    if(!int.TryParse(s, out int v))
                        return string.Empty;

                    Code128CharcterValue cv = Code128Map.ValueMap[v];
                    barcodePattern += cv.Pattern;
                    sum += ((i + 1) * cv.Value);
                }

                int rem = sum % 103;
                string checkSumPattern = Code128Map.ValueMap[rem].Pattern; //not sure this is correct
                barcodePattern += checkSumPattern;
                barcodePattern += symbology.StopCode;

                return barcodePattern;
            }

            throw new Exception("invalid symbology. only 128A, 128B, and 128C are supported");
        }
    }
}
