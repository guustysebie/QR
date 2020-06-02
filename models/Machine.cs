using System.Text;

namespace QR.models
{
    public class Machine : IQrGenerator
    {
        public string Name { get; set; }
        public string Amount { get; set; }
        public string Yeeted { get; set; }
        public string Yooted { get; set; }
        
        
        
        
        public string CreateQrContent()
        {
            var sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(",");
            sb.Append(Amount);
            sb.Append(",");
            sb.Append(Yeeted);
            sb.Append(",");
            sb.Append(Yooted);
            return sb.ToString();
        }
    }
}