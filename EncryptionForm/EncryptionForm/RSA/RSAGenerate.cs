using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionForm.RSA
{
    class RSAGenerate
    {
        private decimal n, e, phiN, d;

        public decimal N
        {
            get { return n; }
            set { n = value; }
        }

        public decimal D
        {
            get { return d; }
            set { d = value; }
        }
        public RSAGenerate(decimal p, decimal q, decimal e)
        {
            this.n = p * q;
            this.phiN = (p - 1) * (q - 1);
            this.e = e;
            findD();
        }

        public decimal findD()
        {
            d = 0;
            decimal y0 = 0, y1 = 1;
            decimal a = phiN;
            decimal b = e;
            decimal r, q;
            while (true)
            {
                r = a % b;
                if (r == 0) break;
                q = Math.Truncate(a / b);
                d = y0 - y1 * q;
                y0 = y1;
                y1 = d;
                a = b;
                b = r;
            }
            if (d < 0) d = phiN + d;  
            return d;
        }
    }
}
