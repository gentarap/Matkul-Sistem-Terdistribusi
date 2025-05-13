using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_nonthread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************");
            Console.WriteLine("Mulai Keseharian");
            Console.WriteLine("*****************");
            nonthread tid1 = new nonthread();

            tid1.kuliah();
            tid1.rapat();
            Console.WriteLine("*******************");
            Console.WriteLine("Selesai");
            Console.WriteLine("*******************");
            Console.WriteLine();
        }
    }
}
