using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selfStudy.MyTypes
{
    internal class Casting
    {
        public Casting()
        {
            // int.TryParse
            // Convert.ToDouble(x)
            // (int)55.5
            // (89.123).ToString()
            int i = 1;
            decimal d = 2.3m;
            string s = Convert.ToString(i * d);
            string s1 = (i * d).ToString();
            
            string sx = "10.3";
            int.TryParse(sx, out int n);
            int n1 = (int)Convert.ToDecimal(sx);
            Console.WriteLine($"s is: {s} - {s1} - {n} - {n1} type is {n1.GetType().Name} - {(int)55.5} - {55.5.ToString()}.");
        }
    }
}
