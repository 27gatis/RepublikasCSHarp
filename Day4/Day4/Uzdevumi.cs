using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    
    class Uzdevumi
    {
        public void PirmaisUzd()
        {
            Console.WriteLine("Ievadiet masiva garumu");
            int garums = Convert.ToInt16(Console.ReadLine());

            int[] skaitluMasivs = new int[garums];

            for (int i = 0; i < skaitluMasivs.Length; i++)
            {
                skaitluMasivs[i] = i + 2;
                Console.Write(skaitluMasivs[i] + " ");
            }
        }


        public void OtraisUzd()
        {
            Console.WriteLine("Ievadiet masiva garumu");
            int garums = Convert.ToInt16(Console.ReadLine());

            int[] skaitluMasivs = new int[garums];
            int summa = 0;

            for (int i = 0; i < skaitluMasivs.Length; i++)

            {
                Console.WriteLine("Ievadiet masiva " + i + "." + " elementu");
                skaitluMasivs[i] = Convert.ToInt16(Console.ReadLine()); // parkonverte ievadito vertibu uz int (masiva vertibu)
                summa += skaitluMasivs[i]; // summa + skaitluMAsivs[i];

            }
            
            //int sum = skaitluMasivs.Sum(); /// Iebuveta funkcija sum
            //int average = sum / skaitluMasivs.Length;
            Console.WriteLine("Videjais masiva ir" + " " + (summa / skaitluMasivs.Length));

        }

        public void Meklesana()
        {
            Console.WriteLine("Ievadiet masiva garumu");
            int garums = Convert.ToInt16(Console.ReadLine());

            int[] skaitluMasivs = new int[garums];
            

            for (int i = 0; i < skaitluMasivs.Length; i++)

            {
                Console.WriteLine("Ievadiet masiva " + i + "." + " elementu");
                skaitluMasivs[i] = Convert.ToInt16(Console.ReadLine()); // parkonverte ievadito vertibu uz int (masiva vertibu)

            }
            

        }
}
