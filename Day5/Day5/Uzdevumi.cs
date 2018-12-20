using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Uzdevumi
    {
        public void Piemers()
        {
            //NETIEK SIS IZMANTOTS
            Console.WriteLine("Ievadiet masiva garumu");
            int garums = Convert.ToInt16(Console.ReadLine());

            int[] skaitluMasivs = new int[garums];

            for (int i = 0; i < skaitluMasivs.Length; i++)
            {
                Console.WriteLine("Ievadiet skaitli");
                skaitluMasivs[i] = Convert.ToInt16(Console.ReadLine());
            }

        }


        public void PozitivsVaiNegativs()
        {
            ///Dots masivs, kuram ir 10 elementu. Pieskirt visiem pozitiviem masiva elementiem vertibu 1, bet negativiem vertibu 2.


            int[] skaitluMasivs = { 1, -2, 3, -7, 5, -11, 19, -11, - 12, -13 };

           // int lielakaisSkaitlis = skaitluMasivs[0];

            for (int i = 0; i < skaitluMasivs.Length; i++)
            {
                if (skaitluMasivs[i] >= 0)
                {
                    skaitluMasivs[i] = 1;
                    Console.WriteLine(i + "vērtība ir pozitiva");
                }
                if (skaitluMasivs[i] < 0)
                {
                    skaitluMasivs[i] = 2;
                    Console.WriteLine(i + "vērtība ir negatīva");
                }
            }

           // Console.WriteLine("Lielakais skaitlis ir " + lielakaisSkaitlis);
        }


        public void IntervalaParbaude()
        {
            ///Dots masivs, kuram ir 10 elementu. Noskaidrojiet, cik daudz masiva ir elementu, kuri ir lielaki par 0, bet mazaki par 10.


            int[] skaitluMasivs = { 1, -2, 3, -7, 5, -11, 19, -11, -12, -13 };
            int skaits = 0;

            /////SEIT JABUT VEL 
            // int lielakaisSkaitlis = skaitluMasivs[0];

            for (int i = 0; i < skaitluMasivs.Length; i++)
            {
                if (skaitluMasivs[i] >= 1 && skaitluMasivs[i] < 10)
                {
                    skaits++;
                   // Console.WriteLine(i + " " + " derigs");
                }
                
               
            }
            Console.WriteLine("Derigie ir " + skaits);
            
            // Console.WriteLine("Lielakais skaitlis ir " + lielakaisSkaitlis);
        }


        /// parbaudit vai masivs ir augoss
        public void VaiAugosa()
        {
            Console.WriteLine("Ievadiet masiva garumu");
            int garums = Convert.ToInt16(Console.ReadLine());

            int[] skaitluMasivs = new int[garums];

            for (int i = 0; i < skaitluMasivs.Length; i++)
            {
                Console.WriteLine("Ievadiet skaitli");
                skaitluMasivs[i] = Convert.ToInt16(Console.ReadLine());
            }


            bool navAugosa = false;

            for (int i = 0; i < skaitluMasivs.Length - 1; i++)
            {
                if (skaitluMasivs[i + 1] > skaitluMasivs[i])
                {

                    navAugosa = true;
                    break;

                }
                

                if (navAugosa)
                {
                    Console.WriteLine("NAV augosa seciba");
                }
                       
            }
           // Console.WriteLine("IR augosa seciba");

            // if (!skaitlisAtrasts) //(skaitlisAtrasts==false)
            // {
            //   Console.WriteLine("Masiva tada skaitla nav");
            //}
        }
    }
}
