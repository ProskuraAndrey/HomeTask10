using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityForms
{
    public class CoutingClass
    {
        public double Mean(string a, string b, string c, string d, string f)
        {
            double x1 = Convert.ToDouble(a);
            double x2 = Convert.ToDouble(b);
            double x3 = Convert.ToDouble(c);
            double x4 = Convert.ToDouble(d);
            double x5 = Convert.ToDouble(f);

            double _mean = (x1+x2+x3+x4+x5)/5;
            return _mean;
        }
    }
}
