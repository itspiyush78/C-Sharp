using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDemo2
{
  //  Case 5: Consuming members of a class from non-child class of different project
    internal class Five
    {
        static void Main()
        {
            AccessDemo1.Program p = new AccessDemo1.Program();
            p.Test5();
            Console.ReadLine();
        }
    }
}
