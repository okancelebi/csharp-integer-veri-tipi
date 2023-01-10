using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_integer_veri_tipi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                //int veri tipi -2.147.483.648 ile 2.147.483.647 arasında değer alabilmektedir.
                int birincidegisken = 150000;
                int ikincidegisken = -500000;
                int maxdeger = int.MaxValue;
                int mindeger = int.MinValue;
                Console.WriteLine(birincidegisken);
                Console.WriteLine(ikincidegisken);
                Console.WriteLine(maxdeger);
                Console.WriteLine(mindeger);
                Console.ReadLine();
            }
        }
    }
}
