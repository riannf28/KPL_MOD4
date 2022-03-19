using System;
using System.Collections.Generic;
using System.Text;

namespace modul4_1302200040
{
    class Penjumlahan
    {
        public void JumlahTigaAngka<T>(ref T a, ref T b, ref T c)
        {
            T temp;
            temp = a;
            a = b;
            b = c;
            c = temp;
        }
    }
}
