using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_nonthread
{
    public class nonthread
    {
        public void kuliah()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Kuliah ke-{0}", i);
            }
        }
        public void rapat()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Rapat ke-{0}", i);
            }
        }
    }
}
