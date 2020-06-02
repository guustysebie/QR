using System;
using System.Drawing;
using QR.models;

namespace QR
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = new Machine()
            {
                Amount = "Ik",
                Name = "hou",
                Yeeted = "van",
                Yooted = "jou",
            };
            var bitmap = (Bitmap) Bitmap.FromFile("/home/guust/Code/personal/QR/out.png");
            var img = QrCodeFactory.GenerateQrCode(m,bitmap);
            img.Save("/home/guust/Code/personal/QR/yeet.png");
        }
    }
}