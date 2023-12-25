using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class Program
    {
        int i; bool b;
        static void Main(string[] args)
        {
            Program p = new DemoProject.Program();
            Console.WriteLine("Value of i is:" + p.i);
            Console.WriteLine("Value of b is:" + p.b);

            Console.ReadLine();
        }
    }
}
