using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaknaA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Var vänlig och skriv en textsträng:");
            string Userwrote = Console.ReadLine();
            int BigA = 0;
            int Smalla = 0;
            foreach(char a  in Userwrote)
            {
                if (a == 'A')
                {
                    BigA++;
                }
                if (a == 'a')
                {
                    Smalla++;
                }
            }
            Console.WriteLine("Antal stora A var {0}, Antal små a var {1}", BigA, Smalla);
        }
    }
}
