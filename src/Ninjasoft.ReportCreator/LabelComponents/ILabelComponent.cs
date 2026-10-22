using System.Drawing;
using System.Runtime.Versioning;

namespace Ninjasoft.ReportCreator.LabelComponents
{
    internal interface ILabelComponent
    {
        public float X { get; }

        public float Y { get; }

        [SupportedOSPlatform("windows")]
        void Draw(Graphics graphics, Font f, Brush b);
    }
}
