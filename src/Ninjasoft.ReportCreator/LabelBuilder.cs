using Ninjasoft.ReportCreator.LabelComponents;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.Versioning;

namespace Ninjasoft.ReportCreator
{
    public class LabelBuilder
    {
        public LabelBuilder(int height, int width)
        {
            Height = height;
            Width = width;
            _components = new List<ILabelComponent>();
        }

        public int Height { get; }

        public int Width { get; }

        public LabelBuilder AddText(string text, float x, float y)
        {
            _components.Add(new TextComponent(text, x, y));
            return this;
        }

        public LabelBuilder AddBarcode(string text, float x, float y, Symbology symbology)
        {
            _components.Add(new BarcodeComponent(text, x, y, symbology));
            return this;
        }

        /// <summary>
        /// only use this for 128C barcodes
        /// </summary>
        /// <param name="barcode"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public LabelBuilder AddBarcode(int barcode, float x, float y)
        {
            _components.Add(new BarcodeComponent(barcode.ToString(), x, y, Symbology.Code128C));
            return this;
        }

        [SupportedOSPlatform("windows")]
        public void Build(string filePath)
        {
            Font f = new (FontFamily.GenericMonospace, 10);
            Brush b = new SolidBrush(Color.Black);

            using (var bitmap = new Bitmap(Width, Height))
            {
                using(var graphics = Graphics.FromImage(bitmap))
                {
                    foreach(var component in _components)
                    {
                        component.Draw(graphics, f, b);
                    }
                }
                bitmap.Save(filePath, ImageFormat.Png);
            }
        }

        private List<ILabelComponent> _components;
    }
}
