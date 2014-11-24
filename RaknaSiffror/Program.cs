using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaknaSiffror
{
    class Program
    {
        static void Main(string[] args)
        {
            int Zeroes = 0;
            int Evens = 0;
            int Odds = 0;

            Console.WriteLine("Ange några tal(Sammanhängande tack!)");
            string Userinfo = Console.ReadLine();
            foreach (char digit in Userinfo)
                try
                {
                    if (int.Parse(digit.ToString()) == 0)
                    {
                        Zeroes++;
                    }
                    if (int.Parse(digit.ToString()) % 2 == 0 && int.Parse(digit.ToString()) != 0)
                    {
                        Evens++;
                    }
                    if (int.Parse(digit.ToString()) % 3 == 0 && int.Parse(digit.ToString()) != 1)
                    {
                        Odds++;
                    }
                }
                catch
                {
                    Console.WriteLine("bara tal och inga mellanslag!");
                }
            Console.WriteLine("Antal 0:or {0}, Antal Jämna {1}, Antal ojämna {2}", Zeroes, Evens, Odds);
        }
    }
}
