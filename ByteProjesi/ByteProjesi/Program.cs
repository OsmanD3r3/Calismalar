using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteProjesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Byte birinci = 5;

            Byte ikinci = 25;

            Byte ucuncu = 244; // 0 -255

            Byte maxDeger = byte.MaxValue;
            Byte minDeger = byte.MinValue;


            Console.WriteLine(minDeger);
            Console.WriteLine(birinci);
            Console.WriteLine(ikinci);
            Console.WriteLine(ucuncu);
            Console.WriteLine(maxDeger);
            Console.ReadLine();

        }
    }
}
