using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Program
    {
        int i; bool b;
        static void Main(string[] args)
        {
            Program p = new DemoProject.Program();
            Console.WriteLine(p.i);
        }
    }
}
