using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace P4_22SA11A116_GENTAR_ASMARA_PUTRA_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************");
            Console.WriteLine("Mulai Keseharian");
            Console.WriteLine("*********************");
            Thread tid1 = new Thread(new ThreadStart(Threads.Thread1));
            Thread tid2 = new Thread(new ThreadStart(Threads.Thread2));
            tid1.Start();
            tid2.Start();
            Console.ReadLine();
        }
    }
}
