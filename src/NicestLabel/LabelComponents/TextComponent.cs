using System.Drawing;
using System.Runtime.Versioning;

namespace NicestLabel.LabelComponents
{
    internal class TextComponent : ILabelComponent
    {
        public TextComponent(string text, float x, float y)
        {
            Text = text;
            X = x;
            Y = y;
        }

        public string Text { get; }

        public float X { get; }

        public float Y { get; }

        [SupportedOSPlatform("windows")]
        public void Draw(Graphics graphics, Font f, Brush b)
        {
            graphics.DrawString(Text, f, b, X, Y);
        }
    }
}
