namespace Ninjasoft.ReportCreator
{
    internal sealed class BarcodeCreator(Symbology symbology)
    {
        public string Create(string text)
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
                if(text.Length % 2 == 1)
                    text = "0" + text;
                
                char[] chars = text.ToCharArray();
                
                string barcodePattern = symbology.StartCode;
                int sum = symbology.Value;

                for(int i = 0; i < chars.Length; i+=2)
                {
                    int asciiValue1 = chars[i];
                    int asciiValue2 = chars[i+1];

                    string s = chars[i] + "" + chars[i+1];
                    if(!int.TryParse(s, out int v))
                        return string.Empty;
                    if(v < 0 || v > 99)
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
            return string.Empty;
        }
    }
}
