using System.Drawing;
using System.Runtime.Versioning;

namespace NicestLabel.LabelComponents
{
    internal class BarcodeComponent : ILabelComponent
    {
        public BarcodeComponent(string text, float x, float y, Symbology symbology)
        {
            X = x;
            Y = y;
            Text = text;
            _symbology = symbology;
        }

        public string Text { get; }

        public float X { get; }

        public float Y { get; }

        private readonly Symbology _symbology;

        [SupportedOSPlatform("windows")]
        public void Draw(Graphics graphics, Font f, Brush b)
        {
            Pen p = new Pen(b);
            float x = X;
            float y = Y;

            string barcodePattern = new BarcodeCreator(_symbology).Create(Text);

            DrawPattern(graphics, p, barcodePattern, x, y);
        }

        [SupportedOSPlatform("windows")]
        private float DrawPattern(Graphics graphics, Pen p, string pattern, float x, float y)
        {
            foreach (var bit in pattern.ToCharArray())
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
    }
}
