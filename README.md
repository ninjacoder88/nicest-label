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
```

# Resources
- https://en.wikipedia.org/wiki/Code_128
- https://barcodeqrcode.com/code128-barcode-generator/
- https://www.asciitable.com/
