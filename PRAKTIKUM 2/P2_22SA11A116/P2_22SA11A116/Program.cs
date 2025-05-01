using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_22SA11A116
{
    //22SA11A116_Gentar Asmara Putra
    class Program
    {
        static void Main(string[] args)
        {
            string folder = @"D:\Gentar Asmara Putra\Kuliah\Semester6\SISTER";
            string filename = "Gentar Asmara Putra_22SA11A116.txt";
            string fullPath = folder + filename;

            //using (StreamWriter writer = new StreamWriter(fullPath))
            //{
            //    writer.WriteLine("Bondan Prakoso");
            //    writer.WriteLine("Ariel Peterpan");
            //    writer.WriteLine("Andika Kangenband");
            //    writer.WriteLine("Pasha Ungu");
            //    writer.WriteLine("Didi Kempot");
            //}
            //string readText = File.ReadAllText(fullPath);
            //Console.WriteLine(readText);

            //Dengan Menggunakan Array
            string[] band = { "Didi Kempot", "Ariel Peterpan", "Andika Kangenband", "Pasha Ungu", "Bondan Prakoso" };
            File.WriteAllLines(fullPath, band);
            string readText = File.ReadAllText(fullPath);
            Console.WriteLine(readText);
        }
    }
}
