using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionForm.RSA
{
    class RSADecryption
    {
        private int n = 0;
        private int d = 0;

        public RSADecryption(int d, int n)
        {
            this.n = n;
            this.d = d;
        }

        public int decrypt(int c)
        {
            int[] a = new int[100];
            int k = 0, runner = d;
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
                    result = (result * c) % n;
            }
            return (int)result;

        }
    }
}
