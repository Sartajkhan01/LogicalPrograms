using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class ReverseNumber
    {
        public void Calculation(int numb)
        {
            int r, reverse = 0;
            while (numb > 0)
            {
                r = numb % 10;
                reverse = reverse * 10 + r;
                numb = numb / 10;
            }
        }

        internal void Calculation()
        {
            throw new NotImplementedException();
        }
    }
}
