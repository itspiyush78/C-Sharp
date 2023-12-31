namespace Variables
{
    class Program
    {
        int x;    //Non-Static
        static int y = 200;  //Static 
        const float pi = 3.14f;
        readonly bool flag;
        public Program(int x, bool flag)
        {
            this.x = x;
            this.flag = flag;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(y);
            Console.WriteLine(pi);
            Program p1 = new Program(50, true);
            Program p2 = new Program(150, false);
            Console.WriteLine(p1.x + " " + p2.x );
            Console.WriteLine(p1.flag + " " + p2.flag);
            Console.ReadLine();
        }
    }
}

