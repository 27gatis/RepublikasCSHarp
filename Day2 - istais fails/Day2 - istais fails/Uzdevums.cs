using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2___istais_fails
{
    class Uzdevums
    {
        public static void Zvaigzne()
        {


            for (int i = 1; i < 5; i++) //pirmais risinajums
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //////////

            String zv = ""; ///2.risinajums
            for (int i = 0; i <4; i++)
            {
                zv += "*"; //zv = zv + "*"
                Console.WriteLine(zv);
            }

            }

        public int Kapinat(int baze, int pakape)
        {
            int result = 1; 
            for (int i = 0; i < pakape; i++)
            {
                result = result * baze;
                
            }

            return result;
            // komandrindas kalkulators, 
            // ar switch, case
            // while // jauna projekta

        }

        
        }
    }

