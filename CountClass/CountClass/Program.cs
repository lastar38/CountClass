using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var countclass = new CountClass(@"C:\Users\雄基\source\repos\Sample2\Sample2\Program.cs");
            Console.WriteLine(countclass.Count());
        }
    }
}
