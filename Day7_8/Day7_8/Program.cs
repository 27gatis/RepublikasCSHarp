using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_8
{
    class Program
    {
        static void Main(string[] args)
        {

            SarakstaUzdevumi sar = new SarakstaUzdevumi(); // uztaisam objektu, no saraksta piemeri
            sar.IzvaditLietotajuSaraksts();  //no objekta izsaucam funkciju sarakstapiemers
            Console.ReadLine();

        }
    }
}
