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
            
            Penjumlahan jumlah = new Penjumlahan();
            jumlah.JumlahTigaAngka<long>(ref a, ref b, ref c);
        }
    }
}
