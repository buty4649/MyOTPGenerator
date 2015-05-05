using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Base32;

namespace MyOTPGenerator
{
    class MyOTPGenerator
    {
        byte[] secret;

        private readonly OTPType type;
        public OTPType Type { get { return type; } }
        private readonly HashAlgorithm algorithm;
        public HashAlgorithm Algorithm { get { return algorithm; } }
        private readonly int digit;
        public int Digit { get { return digit; } }
        private readonly int period;
        public int Period { get { return period; } }

        public enum OTPType { TOTP, HOTP }
        public enum HashAlgorithm { SHA1, SHA256, SHA512 }

        public MyOTPGenerator(string keyuri)
        {
            Uri uri = new Uri(keyuri);

            if(uri.Scheme != "otpauth" || uri.Query == "")
            {
                throw new Exception("OTPAUTH用のURIじゃありません");
            }

            Dictionary<string, string> query = new Dictionary<string,string>();
            uri.Query
                .Substring(1)
                .Split('&')
                .ToList()
                .ForEach((q) =>
                {
                    string[] p = q.Split('=');
                    query.Add(p[0], p[1]);
                });

            if(!query.ContainsKey("secret"))
            {
                throw new Exception("OTPAUTH用のURIじゃありません");
            }

            secret = Base32.Base32Encoder.Decode(query["secret"]);

            // 未実装なので固定
            type = OTPType.TOTP;
            algorithm = HashAlgorithm.SHA1;
            digit = 6;
            period = 30;
        }

        public string Generate()
        {
            return GenerateTotp();
        }

        private string GenerateHotp(ulong c)
        {
            byte[] counter = BitConverter.GetBytes(c);
            if (BitConverter.IsLittleEndian)
            {
                counter = counter.Reverse().ToArray();
            }

            HMACSHA1 hmac = new HMACSHA1(secret);
            byte[] hs = hmac.ComputeHash(counter);

            int offset = hs[19] & 0x0f;
            uint bin_code = ((uint)hs[offset] & 0x7f) << 24
                | ((uint)hs[offset + 1] & 0xff) << 16
                | ((uint)hs[offset + 2] & 0xff) << 8
                | (uint)hs[offset + 3] & 0xff;

            string d = bin_code.ToString();
            return d.Substring(d.Length - digit);
        }

        private string GenerateTotp()
        {
            DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            ulong t = (ulong)(DateTime.UtcNow - epoch).TotalSeconds / (ulong)period;
            return GenerateHotp(t);
        }
    }
}
