using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Program
    {
        static void Main(string[] args)
        {
           // Piemeri piem = new Piemeri();
            //piem.SkaitluMasivs();
            //Console.ReadLine();

            SarakstaPiemeri sar = new SarakstaPiemeri(); // uztaisam objektu, no saraksta piemeri
            sar.SarakstaPiemers();  //no objekta izsaucam funkciju sarakstapiemers
            Console.ReadLine();
        }
    }
}
