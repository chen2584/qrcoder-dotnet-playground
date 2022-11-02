// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.Reflection;
using QRCoder;

var qrGenerator = new QRCodeGenerator();
var qrCodeData = qrGenerator.CreateQrCode("http://www.example.com", QRCodeGenerator.ECCLevel.Q);
var svgQrCode = new SvgQRCode(qrCodeData);
var qrCode = svgQrCode.GetGraphic(20);

// Console.WriteLine(qrCode);

var rootPath = Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location)!;
var svgPath = Path.Combine(rootPath, "example.svg");
File.WriteAllText(svgPath, qrCode);

Console.WriteLine($"Generate SVG File to: {svgPath}");