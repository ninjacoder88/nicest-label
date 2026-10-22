using Ninjasoft.ReportCreator.LabelComponents;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.Versioning;

namespace Ninjasoft.ReportCreator
{
    [SupportedOSPlatform("windows")]
    public class LabelBuilder
    {
        public LabelBuilder(int height, int width)
        {
            Height = height;
            Width = width;
            _components = [];
        }

        public int Height { get; }

        public int Width { get; }

        private Font Font { get; set; } = new Font(FontFamily.GenericMonospace, 10);

        private Brush Brush { get; set; } = new SolidBrush(Color.Black);

        public LabelBuilder SetDefaultFont(Font font)
        {
            Font = font;
            return this;
        }

        public LabelBuilder SetDefaultBrush(Brush brush)
        {
            Brush = brush;
            return this;
        }

        public LabelBuilder AddText(string text, float x, float y)
        {
            _components.Add(new TextComponent(text, x, y, Font, Brush));
            return this;
        }

        public LabelBuilder AddText(string text, float x, float y, Font font)
        {
            _components.Add(new TextComponent(text, x, y, font, Brush));
            return this;
        }

        public LabelBuilder AddText(string text, float x, float y, Brush brush)
        {
            _components.Add(new TextComponent(text, x, y, Font, brush));
            return this;
        }

        public LabelBuilder AddText(string text, float x, float y, Font font, Brush brush)
        {
            _components.Add(new TextComponent(text, x, y, font, brush));
            return this;
        }

        public LabelBuilder AddBarcode(string text, float x, float y, Symbology symbology)
        {
            _components.Add(new BarcodeComponent(text, x, y, Font, Brush, symbology));
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
            _components.Add(new BarcodeComponent(barcode.ToString(), x, y, Font, Brush, Symbology.Code128C));
            return this;
        }

        public LabelBuilder AddImage(float x, float y, Image image)
        {
            _components.Add(new ImageComponent(x, y, Font, Brush, image));
            return this;
        }

        public void Build(string filePath) => Build(filePath, ImageFormat.Png);

        public void Build(string filePath, ImageFormat imageFormat)
        {
            using (Bitmap bitmap = new(Width, Height))
            {
                using(Graphics graphics = Graphics.FromImage(bitmap))
                {
                    foreach(LabelComponent component in _components)
                    {
                        component.Draw(graphics);
                    }
                }
                bitmap.Save(filePath, imageFormat);
            }
        }

        public void Build(Stream stream) => Build(stream, ImageFormat.Png);

        public void Build(Stream stream, ImageFormat imageFormat)
        {
            using (Bitmap bitmap = new (Width, Height))
            {
                using(Graphics graphics = Graphics.FromImage(bitmap))
                {
                    foreach(LabelComponent component in _components)
                    {
                        component.Draw(graphics);
                    }
                }
                bitmap.Save(stream, imageFormat);
            }
        }

        private readonly List<LabelComponent> _components;
    }
}