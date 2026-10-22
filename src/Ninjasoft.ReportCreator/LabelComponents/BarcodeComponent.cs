using System.Drawing;
using System.Runtime.Versioning;

namespace Ninjasoft.ReportCreator.LabelComponents
{
    internal sealed class BarcodeComponent : LabelComponent
    {
        public BarcodeComponent(string text, float x, float y, Font font, Brush brush, Symbology symbology)
         : base(text, x, y, font, brush)
        {
            _symbology = symbology;
        }

        [SupportedOSPlatform("windows")]
        public override void Draw(Graphics graphics)
        {
            Pen p = new(Brush);
            float x = X;
            float y = Y;

            string barcodePattern = BarcodeCreator.Create(Text, _symbology);

            DrawPattern(graphics, p, barcodePattern, x, y);
        }

        [SupportedOSPlatform("windows")]
        private static float DrawPattern(Graphics graphics, Pen p, string pattern, float x, float y)
        {
            foreach (char bit in pattern.ToCharArray())
            {
                switch (bit)
                {
                    case '0':
                        break;
                    case '1':
                        graphics.DrawLine(p, x, y, x, y + 50);
                        break;
                }
                x += 1;
            }

            return x;
        }

        private readonly Symbology _symbology;
    }
}
