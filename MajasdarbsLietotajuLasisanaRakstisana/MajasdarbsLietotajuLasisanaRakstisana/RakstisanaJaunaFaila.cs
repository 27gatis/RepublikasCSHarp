using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajasdarbsLietotajuLasisanaRakstisana
{
    class RakstisanaJaunaFaila
    {
        public void Rakstit(List<String> lines)
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"D:\VisualPiemeri\lietotajiJAUNS.txt"))
            {
                foreach (string line in lines)
                {
                    file.WriteLine(line);
                    Console.WriteLine("Izveidots jauns fails!");
                   
                }
                
            }
        }
    }
}
