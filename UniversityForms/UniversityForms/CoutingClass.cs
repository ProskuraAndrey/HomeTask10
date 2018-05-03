using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityForms
{
    public class CoutingClass
    {
        public int Mean(string a, string b, string c, string d, string f)
        {
            int x1 = Convert.ToInt32(a);
            int x2 = Convert.ToInt32(b);
            int x3 = Convert.ToInt32(c);
            int x4 = Convert.ToInt32(d);
            int x5 = Convert.ToInt32(f);

            int _mean = (x1+x2+x3+x4+x5)/5;
            return _mean;
        }
    }
}
