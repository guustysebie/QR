using System;
using System.Drawing;
using QRCoder;

namespace QR.models
{
    public class QrCodeFactory
    {
        public static Bitmap GenerateQrCode(IQrGenerator data, Bitmap icon = null)
        {
            var qrGenerator = new QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(data.CreateQrContent(), QRCodeGenerator.ECCLevel.L);
            var qrCode = new QRCode(qrCodeData);
            var qr = icon == null
                ? qrCode.GetGraphic(20, Color.Black, Color.White, false)
                : qrCode.GetGraphic(20, Color.Black, Color.White, icon);
            return qr ?? throw new ArgumentNullException("generated qrcode is null with parameters data:" + icon);
        }
    }
}