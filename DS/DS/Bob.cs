using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace DS
{
    class Bob
    {
        RSAParameters rsaPubParams;
        RSAParameters rsaPrivateParams;

        public Bob()
        {
            RSACryptoServiceProvider rsaCSP = new RSACryptoServiceProvider();

            rsaPrivateParams = rsaCSP.ExportParameters(true);
            rsaPubParams = rsaCSP.ExportParameters(false);
        }

        public RSAParameters PublicParameters() 
        {
            return rsaPubParams;
        }
    }
}
