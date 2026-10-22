using System.Drawing;
using System.Runtime.Versioning;

namespace Ninjasoft.ReportCreator.LabelComponents
{
    internal sealed class TextComponent : LabelComponent
    {
        public TextComponent(string text, float x, float y, Font font, Brush brush)
            : base(text, x, y, font, brush)
        {
        }

        [SupportedOSPlatform("windows")]
        public override void Draw(Graphics graphics) => graphics.DrawString(Text, Font, Brush, X, Y);
    }
}
