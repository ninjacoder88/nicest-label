using System.Drawing;
using System.Runtime.Versioning;

namespace NicestLabel.LabelComponents
{
    internal interface ILabelComponent
    {
        public float X { get; }

        public float Y { get; }

        [SupportedOSPlatform("windows")]
        void Draw(Graphics graphics, Font f, Brush b);
    }
}
