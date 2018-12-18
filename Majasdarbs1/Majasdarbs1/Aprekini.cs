using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majasdarbs1
{
    class Aprekini
    {
        // +- kapinat
        public static int Kapinat(int baze, int pakape) /// public - nozime, ka ir pieeja no citam klasem
                                                        /// ja butu PRIVATE - varetu izsaukt tikai no sis klases
        {

            int result = 1;
            for (int i = 0; i < pakape; i++)
            {
                result = result * baze;
            }
            return result;

        }
        public static int Saskaitit(int a, int b)
        {
            return a + b;
        }
        public static int Atnemt(int a, int b)
        {
            return a - b;
        }
    }
}
