using QRCoder;

namespace QR_Code_Generator.Generator;

public class Generator
{
    public void GenerateQrCode(string text)
    {
        using var qrGenerator = new QRCodeGenerator();
        using var qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
        using var qrCode = new PngByteQRCode(qrCodeData);
        var qrCodeImage = qrCode.GetGraphic(20);
        File.WriteAllBytes("myQRCode.png", qrCodeImage);
    }
}
