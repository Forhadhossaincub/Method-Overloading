using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    class Overload 
    {
        
        public void OvlDemo()
        {
            Console.WriteLine("No Parameters");
        }

        // Overload OvlDemo for once interger parameter.
        public void OvlDemo(int a)
        {
            Console.WriteLine($"One Parameter is : {a}");
        }

        // Overload OvlDemo for two interger parameter.
        public int OvlDemo(int a, int b)
        {
            Console.WriteLine($"Two Parameter is : {a} and {b}" );
            return a + b;
        }

        // Overload OvlDemo for two double parameter.
        public double OvlDemo(double a, double b)
        {
            Console.WriteLine($"Two Double Parameter is : {a} and {b}");
            return a + b;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            Overload ob = new Overload();
            ob.OvlDemo();
            ob.OvlDemo(10);
            ob.OvlDemo(10,20);
            ob.OvlDemo(10.0,20.0);

            Console.ReadKey();
        }
    }
}
