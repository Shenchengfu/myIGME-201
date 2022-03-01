using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classy
{
    class Program
    {
        public static void MyMethod(Coffee MyObject)
        {
            MyObject.AboutCoffee();
        }

        static void Main(string[] args)
        {
            Espresso coffee1 = new Espresso();
            MyMethod(coffee1);
            Latte coffee2 = new Latte();
            MyMethod(coffee2);
        }
    }
}
