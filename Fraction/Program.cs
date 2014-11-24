using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            int d;

            int choice = menu();
            if(choice == 0)
            {
                return;
            }

            a = userInput("Ange första bråkets täljare");
            b = userInput("Ange första bråkets nämnare");
            Fraction fractionOne = new Fraction(a, b);
            c = userInput("Ange andra bråkets täljare");
            d = userInput("Ange andra bråkets nämnare");
            Fraction fractionTwo = new Fraction(c, d);

            switch (choice)
            {
                case 1:
                    Fraction addResult = fractionOne.add(fractionTwo);
                    viewResult(string.Format("{0} + {1} är:", fractionOne, fractionTwo), addResult);
                    break;
                case 2:
                    Fraction MultiplyResult = fractionOne.multiply(fractionTwo);
                    viewResult(string.Format("{0}*{1} är:", fractionOne, fractionTwo), MultiplyResult);
                    break;
                case 3:
                    bool result = fractionOne.isEqualTo(fractionTwo);
                    if (result)
                    {
                        Console.WriteLine("{0},{1} är lika", fractionOne, fractionTwo);
                        break;
                    }
                    else
                        Console.WriteLine("{0},{1} är inte lika", fractionOne, fractionTwo);
                    break;
            }

        }
        static int userInput(string prompt)
        {
            Console.WriteLine(prompt);
            return int.Parse(Console.ReadLine());
        }
        static int menu()
        {
            Console.WriteLine("0: avsluta");
            Console.WriteLine("1:Addera Bråk");
            Console.WriteLine("2:Multiplicera bråk");
            Console.WriteLine("3:Jämför bråktal");
            int userChoice = int.Parse(Console.ReadLine());
            if (userChoice < 0 || userChoice > 3)
            {
                Console.WriteLine("Du valde inget alternativ inom intervallet");
                Console.WriteLine("Stänger av, starta om om du vill och välj något inom intervallet");
                return 0;
            }
            else
                return userChoice;
        }
        static void viewResult(string prompt, Fraction a)
        {
            Console.WriteLine("{0},{1}",prompt,a.ToString());
        }
    }
}
