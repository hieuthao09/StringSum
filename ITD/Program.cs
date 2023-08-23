using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITD
{
    class Program
    {
        static void Main(string[] args)
        {
            String s1; 
            String s2;
            String cont = "Y";
            while (cont == "Y")
            {
                Console.WriteLine("Input string 1:");
                s1 = Console.ReadLine();
                Console.WriteLine("Input string 2:");
                s2 = Console.ReadLine();
                MyBigNumber t = new MyBigNumber(s1, s2);
                Console.WriteLine("Sum: {0}", t.sum());
                Console.WriteLine("Continue?? Y/N");
                cont = Console.ReadLine();
            }
        }
         
    }

}
