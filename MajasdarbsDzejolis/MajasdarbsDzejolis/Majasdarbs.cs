using System;
using System.Collections.Generic;
using System.Text;

namespace Day7_8
{
    class Majasdarbs
    {
        public void DzejolisNolasit()
        {
            String[] lines = System.IO.File.ReadAllLines(@"D:\VisualPiemeri\dzejolis.txt"); // nolasa

            for (int i = 0; i < lines.Length; i++) // izvada
            {
                Console.WriteLine(lines[i]);
            }

            Console.WriteLine();

            String[] reverseLines = new String[lines.Length]; // apgriez

            for (int i = 0; i < lines.Length; i++)
            {
                reverseLines[i] = lines[lines.Length - 1 - i]; // 1. 4-1-0(1. ir pedeja rinda)
                Console.WriteLine(reverseLines[i]);
            }

            Console.WriteLine();

            using (System.IO.StreamWriter file =  
            new System.IO.StreamWriter(@"D:\VisualPiemeri\dzejolis2.txt"))
            {
                for (int i = 0; i < lines.Length; i++) // ieraksta, izveido
                {
                    file.WriteLine(reverseLines[i]);
                }
            }
        }

    }
}