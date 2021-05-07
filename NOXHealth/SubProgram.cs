using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOXHealth
{
    class SubProgram
    {
        public string setName()
        {
            Console.WriteLine("Siapa nama Anda?");
            return Console.ReadLine();
        }
        public int setAge()
        {
            Console.WriteLine("Berapa usia Anda? (angka saja)");
            return Convert.ToInt32(Console.ReadLine());
        }
        public int setGender()
        {
            Console.WriteLine("Apa jenis kelamin Anda? Pilih salah satu (angka saja): \n1. Laki-laki \n2. Perempuan");
            return Convert.ToInt32(Console.ReadLine());
        }
        public int setProfession()
        {
            Console.WriteLine("Apa profesi Anda? Pilih salah satu (angka saja):" +
                "\n1. Pelajar" +
                "\n2. Dosen/Guru" +
                "\n3. PNS" +
                "\n4. Atlet" +
                "\n5. Polisi/Tentara/Satuan Keamanan lain" +
                "\n6. Petani/Nelayan/Buruh");
            return Convert.ToInt32(Console.ReadLine());
        }
        public double setHeight()
        {
            Console.WriteLine("Berapa tinggi Anda? (dalam meter)");
            return Convert.ToDouble(Console.ReadLine());

        }
        public double setWeight()
        {
            Console.WriteLine("Berapa berat badan Anda? (dalam kilogram)");
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}
