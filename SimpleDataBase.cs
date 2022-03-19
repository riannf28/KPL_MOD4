using System;
using System.Collections.Generic;
using System.Text;

namespace modul4_1302200040
{
    class SimpleDataBase<T>
    {
        List<T> storedData = new List<T>();
        List<DateTime> inputDates = new List<DateTime>();

        public void AddNewData<T>(ref T add)
        {

        }

        public void PrintAllData()
        {
            Console.WriteLine("Data 1 berisi: " + storedData + ", yang disimpan pada waktu" + inputDates);
            Console.WriteLine("Data 2 berisi: " + storedData + ", yang disimpan pada waktu" + inputDates);
            Console.WriteLine("Data 3 berisi: " + storedData + ", yang disimpan pada waktu" + inputDates);
        }
    }
}
