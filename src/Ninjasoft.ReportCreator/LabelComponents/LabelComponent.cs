using System.Drawing;
using System.Runtime.Versioning;

namespace Ninjasoft.ReportCreator.LabelComponents
{
    internal abstract class LabelComponent
    {
        public LabelComponent(string text, float x, float y, Font f, Brush b)
        {
            Text = text;
            X = x;
            Y = y;
            Font = f;
            Brush = b;
        }

        public string Text { get; }

        public float X { get; }

        public float Y { get; }

        public Font Font { get; }

        public Brush Brush { get; }

        [SupportedOSPlatform("windows")]
        public abstract void Draw(Graphics graphics);
    }
}
