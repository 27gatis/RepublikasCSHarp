using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_8
{
    class FailaRakstisanasPiemers
    {
        public void Rakstit(List<String> lines)
        {
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"D:\VisualPiemeri\WriteLines2.txt"))
            {
                foreach (string line in lines)
                {
                    file.WriteLine(line);
                }
            }
        }

        public void LasitUnSaskaitit()
        {
            //ielasam rindas no faila masiva (ta ka piemera)
            //tas bus string tipa masivs, konvertejam uz int
            //saskaitam a + b
            string[] lines = System.IO.File.ReadAllLines(@"D:\VisualPiemeri\WriteLines2.txt");

            // Display the file contents by using a foreach loop.

            int summa = 0;
            System.Console.WriteLine("Summa = ");
            for (int i = 0; i < lines.Length; i++)
            {
                summa = summa + Convert.ToInt16(lines[i]);
            }

            Console.WriteLine(summa);
            Console.ReadLine();

        }
    }
}

