using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionForm.RSA
{
    class RSADecryption
    {
        private decimal n = 0;
        private decimal d = 0;

        public RSADecryption(decimal d, decimal n)
        {
            this.n = n;
            this.d = d;
        }

        public decimal decrypt(decimal c)
        {
            decimal p = c % n;
            decimal m = 1;
            for (int i = 0; i < d; i++)
            {
                m *= p;
                m %= n;
            }
            return m;
        }
    }
}
