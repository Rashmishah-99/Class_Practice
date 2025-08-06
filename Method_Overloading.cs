using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Practice
{
    internal class Method_Overloading
    {
         static int Add(int x, int y)
        {
            return x + y;
        }
       static int Add(int x, int y, int z)
        {
            return x + y + z;
        }
        public static void Main(string[] args)
        {
            int res1 = Add(5, 10);
            Console.WriteLine("Result of Add: " + res1);
            int res2 = Add(5, 10, 15);
            Console.WriteLine("Result of Add: " + res2);
        }
    }
}
