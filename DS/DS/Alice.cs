using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace DS
{
    class Alice
    {
        RSAParameters rsaPubParams;
        RSAParameters rsaPrivateParams;

        public Alice()
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
