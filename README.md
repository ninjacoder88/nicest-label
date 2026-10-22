# Ninjasoft.LabelCreator

## Purpose
THe purpose of this project is to provide the ability for consumers to build labels that can be used on documentation or products.

## Usage
```
new LabelBuilder(100, 250)
    .AddText("hello", 10, 10)
    .AddBarcode("ABC", 10, 50, Symbology.Code128A)
    .Build(@"d:\temp\label-ABC-A.png");

new LabelBuilder(100, 250)
    .AddText("hello", 10, 10)
    .AddBarcode(123, 10, 50)
    .Build(@"d:\temp\label-ABC-C.png");

Font font = new(FontFamily.GenericMonospace, 10);
Brush brush = new SolidBrush(Color.Bisque);

new LabelBuilder(100, 250)
    .AddText("chage the font", 10, 10, font)
    .Build(@"d:\temp\label-ABC-B.png");

new LabelBuilder(100, 250)
    .AddText("chage the brush", 10, 10, brush)
    .Build(@"d:\temp\label-ABC-B.png");

new LabelBuilder(100, 250)
    .AddText("chage the font and brush", 10, 10, font, brush)
    .Build(@"d:\temp\label-ABC-B.png");

new LabelBuilder(100, 250)
    .AddText("here is an image", 10, 10, font, brush)
    .AddImage(20, 20, Image.FromFile(@"d:\temp\someimage.png"))
    .Build(@"d:\temp\label-ABC-B.png");
```

# Resources
- https://en.wikipedia.org/wiki/Code_128
- https://barcodeqrcode.com/code128-barcode-generator/
- https://www.asciitable.com/
