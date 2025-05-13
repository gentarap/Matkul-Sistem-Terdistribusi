using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace P4_22SA11A116_GENTAR_ASMARA_PUTRA_1
{
    public class Threads
    {
        public static void Thread1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Kuliah ke- {0}", i);
                Thread.Sleep(3000);
            }
        }
        public static void Thread2()
        {
            for(int i = 0;i < 10;i++)
            {
                Console.WriteLine("Rapat ke- {0}", i);
                Thread.Sleep(3000);
            }
        }
    }
}
