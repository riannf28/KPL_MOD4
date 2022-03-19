using System;

namespace modul4_1302200040
{
    class Program
    {
        static void Main(string[] args)
        {
            long a, b, c;
            a = 13;
            b = 02;
            c = 20;

            Console.WriteLine("=====Penjumlahan=====");
            Penjumlahan<long> jumlah = new Penjumlahan<long>();
            jumlah.JumlahTigaAngka<long>(ref a, ref b, ref c);
            Console.WriteLine(a + b + c);

            Console.WriteLine("=====Simple Database=====");
            SimpleDataBase<int> data = new SimpleDataBase<int>();
            data.PrintAllData();

        }
    }
}
