using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.testprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Hello World!";
            string name = "Christian Karlsson";
            string[] words = SplitName(name);

            foreach(var str in words)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine(greeting);
            Console.ReadLine();
        }

        static string[] SplitName(string str)
        {
            return str.Split();
        }
    }
}
