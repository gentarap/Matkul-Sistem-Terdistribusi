using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2EVAL1_22SA11A116
{
    class Program
    {
        static void Main(string[] args)
        {
            string folder = @"D:\Gentar Asmara Putra\Kuliah\Semester6\SISTER\";
            string filename = "NilaiMahasiswa_StreamWriter.txt";
            string fullPath = folder + filename;

            // Menulis ke file menggunakan StreamWriter
            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                writer.WriteLine("Nama Mahasiswa,Nilai");
                writer.WriteLine("Budi,85");
                writer.WriteLine("Siti,90");
                writer.WriteLine("Agus,78");
                writer.WriteLine("Dewi,88");
            }

            // Membaca isi file
            Console.WriteLine("Isi file menggunakan StreamWriter:");
            string readText = File.ReadAllText(fullPath);
            Console.WriteLine(readText);
        }
    }
}

