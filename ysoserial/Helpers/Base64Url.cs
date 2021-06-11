using System;
using System.Text;
using System.Web;

namespace ysoserial.Helpers
{
    public class Base64Url
    {
        public static string Base64Encode(byte[] str)
        {
            string b64str = Convert.ToBase64String(str);
            byte[] bb1 = Encoding.UTF8.GetBytes(b64str);
            string strOut = HttpServerUtility.UrlTokenEncode(bb1).Replace("\n", "");
            return strOut;
        }
        public static byte[] Base64Decode(string str) => Convert.FromBase64String(Encoding.UTF8.GetString(HttpServerUtility.UrlTokenDecode(str)));
    }
}