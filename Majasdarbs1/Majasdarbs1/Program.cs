using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majasdarbs1
{
    class Program
    {
        static void Main(string[] args)
        {

            String darbiba = "";
            while(true) //bezgaligais cikls
            {
                Console.WriteLine("Izvelies darbibu- + vai - vai ^, vai rakstat iziet, lai izietu");
                darbiba = Console.ReadLine();  //uztaisam jaunu mainigo, lai parbauditu, kada ir ta mainiga vertiba
                if (darbiba == "iziet") // seit parbauda ciklu - mums galvenais ir partraukt ciklu
                {
                    break;
                }

                int skaitlis1 = Ievade("Ievadiet pirmo skaitli!");
                int skaitlis2 = Ievade("Ievadiet otro skaitli!");



                switch (darbiba) // switch labak neka if, ja parbauda konkretas vertibas
                                 // parbaudam mainigo(darbiba), jeb to kur glabajas cilveku ievade
                {
                    case "+":
                        Console.WriteLine("Rezultats ir " + Aprekini.Saskaitit(skaitlis1, skaitlis2));
                        break;

                    case "-":
                        Console.WriteLine("Rezultats ir " + Aprekini.Atnemt(skaitlis1, skaitlis2));
                        break;

                    case "^":
                        Console.WriteLine("Rezultats ir " + Aprekini.Kapinat(skaitlis1, skaitlis2));
                        break;

                    default:
                        Console.WriteLine("Nepareiza ievade");
                        break;

                }

            
            }

            //Console.ReadLine(); - ja ir cikls, var aizvakt

        }

        static int Ievade(String input)
        {
            Console.WriteLine(input);
            int x = Convert.ToInt32(Console.ReadLine()); // funkcija, kur sagaidam, kada bus ievade
            return x;
        }
    }
}
