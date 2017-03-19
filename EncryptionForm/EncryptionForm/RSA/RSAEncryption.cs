using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionForm.RSA
{
    class RSAEncryption
    {
        private decimal n = 0;
        private decimal e = 0;

        public RSAEncryption(decimal e, decimal n)
        {
            this.n = n;
            this.e = e;
        }

        public decimal encrypt(decimal m)
        {
            decimal p = m % n;
            decimal c = 1;
            for (int i = 0; i < e; i++)
            {
                c *= p;
                c %= n;
            }
            return c;
        }
    }
}
