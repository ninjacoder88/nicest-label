using System.Drawing;
using System.Runtime.Versioning;

namespace Ninjasoft.ReportCreator.LabelComponents
{
    internal sealed class ImageComponent : LabelComponent
    {
        public ImageComponent(float x, float y, Font font, Brush brush, Image image)
            : base(string.Empty, x, y, font, brush)
        {
            Image = image;
        }

        private Image Image { get; }

        [SupportedOSPlatform("windows")]
        public override void Draw(Graphics graphics) => graphics.DrawImage(Image, X, Y);
    }
}