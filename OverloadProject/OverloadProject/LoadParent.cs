using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadProject
{
    internal class LoadParent
    {
        public void Show()
        {
            Console.WriteLine("Parent's Show Method is Called.");
        }
        public void Test() // Overridable
        {
            Console.WriteLine("Parent's Test Method is Called.");
        }
    }
    class LoadChild : LoadParent
    {
        // Overloading parent's Show method in child class
        public void Show(int i)
        {
            Console.WriteLine("Child's Show Method is Called.");
        }
        public override void Test()
        {
            Console.WriteLine("Child's Test Method is Called.");
        }

        static void Main()
        {
            LoadChild c = new LoadChild();
            c.Show();
            c.Show(10);
            c.Test();

            Console.ReadLine();
        }
    }
}
