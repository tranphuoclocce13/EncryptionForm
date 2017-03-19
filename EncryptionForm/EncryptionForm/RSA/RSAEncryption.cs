using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionForm.RSA
{
    class RSAEncryption
    {
        private int n = 0;
        private int e = 0;

        public RSAEncryption(int e, int n)
        {
            this.n = n;
            this.e = e;
        }

        public int encrypt(int m)
        {
            int p = m % n;
            int c = 1;
            for (int i = 0; i < e; i++)
            {
                c *= p;
                c %= n;
            }
            return c;
        }
    }
}
