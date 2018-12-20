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

        public void PirmaisMajasdarbs()
        {
            ///atrast masiva lielako skaitli 


            int[] skaitluMasivs = { 1, 2, 3, 7, 9, 11, 19 };

            int lielakaisSkaitlis = skaitluMasivs[0];

            for (int i = 1; i < skaitluMasivs.Length; i++)
            {
                if (skaitluMasivs[i] > lielakaisSkaitlis)
                {
                    lielakaisSkaitlis = skaitluMasivs[i];
                }
            }

            Console.WriteLine("Lielakais skaitlis ir " + lielakaisSkaitlis);
        }


        public void OtraisMajasdarbs()
        {
            ///samainit masivus otradi??

            int[] skaitluMasivs = { 1, 2, 3, 7, 9, 11, 19 };

            int[] masivsSkaitlu = new int[skaitluMasivs.Length];

            for (int i = 0; i < skaitluMasivs.Length; i++)
            {
                masivsSkaitlu[i] = skaitluMasivs[skaitluMasivs.Length - i - 1];
                Console.WriteLine(masivsSkaitlu[i] + " ");
            }
        }
    }
}
