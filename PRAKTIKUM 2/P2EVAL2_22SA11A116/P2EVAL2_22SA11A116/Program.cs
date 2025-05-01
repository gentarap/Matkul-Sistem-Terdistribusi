using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2EVAL2_22SA11A116
{
    class Program
    {
        static void Main(string[] args)
        {
            string folder = @"D:\Gentar Asmara Putra\Kuliah\Semester6\SISTER\";
            string filename = "NilaiMahasiswa_WriteAllLines.txt";
            string fullPath = folder + filename;

            // Data mahasiswa dalam array string
            string[] dataMahasiswa = {
                "Nama Mahasiswa,Nilai",
                "Budi,85",
                "Siti,90",
                "Agus,78",
                "Dewi,88"
            };

            // Menulis ke file menggunakan WriteAllLines
            File.WriteAllLines(fullPath, dataMahasiswa);

            // Membaca isi file
            Console.WriteLine("Isi file menggunakan WriteAllLines:");
            string readText = File.ReadAllText(fullPath);
            Console.WriteLine(readText);
        }
    }
}
