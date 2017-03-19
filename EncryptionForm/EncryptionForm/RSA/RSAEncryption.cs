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
            int[] a = new int[100];
            int k = 0, runner = e;
            do
            {
                a[k] = runner % 2;
                k++;
                runner = runner / 2;
            }
            while (runner != 0);
            //Quá trình lấy dư
            long result = 1;
            for (int i = k - 1; i >= 0; i--)
            {
                result = (result * result) % n;
                if (a[i] == 1)
                    result = (result * m) % n;
            }
            return (int)result;
        }
    }
}
