using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NastStorsta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange dom 10 numrerna som ska numreras");
            int Numbersinuse = 10;

            int Highest = 0;
            int SecondHighest = 0;
            int Userinput;
            int i = 0;
            int a = 1;
            do
            {
                try
                {
                    Console.WriteLine("Ange tal nr{0}: ",a++ ,i++);
                    Userinput = int.Parse(Console.ReadLine());
                    if (i == 1) 
                    {
                        Highest = Userinput; // Om 1 tal har matats in är näst största = största
                        SecondHighest = Userinput; 
                    }
                    else
                    {
                        if (Userinput > Highest) //Om användaren matar in ett tal som är större än det nuvarande största talet.
                        {
                            SecondHighest = Highest; // 2ndhighest blir vad highest var
                            Highest = Userinput; // Nya inmatade talet blir det nya högsta värdet
                        }
                        if(Userinput == SecondHighest && Userinput <Highest) //Om man matar in ett tal som redan är det som är näst störst.
                        {
                            SecondHighest = Userinput;
                        } 
                        else if (Userinput > SecondHighest && Userinput < Highest || SecondHighest > Highest && Userinput < Highest || Userinput == Highest && Userinput != SecondHighest && Userinput !=Highest)
                        //Om det inmatade är större än näststörsta och mindre än det högsta eller om näststörsta är större än högsta och inmatade är mindre än högsta eller om inmatade är lika med det högsta och inmatade inte är lika med
                            {                                                                                                          //det näst största och det inmatade inte är lika med det högsta.
                                SecondHighest = Userinput; //Näststörsta blir det inmatade
                            }
                        }
                    if(i==10) // OM vi har matat 10 tal
                    {
                        if(Highest==SecondHighest) // och det inte finns ngt näststörsta
                        {
                            Console.WriteLine("finns ingen näst störst");
                        }
                        else // Annars skriv ut näststörsta
                            Console.WriteLine("{0} är näst störst!",SecondHighest);
                    }
                }
                catch //Felmeddenade om du inte matar in heltal
                {
                    Console.WriteLine("Giltigt tal tack!");
                }
            } while (i < Numbersinuse); //Loopar så länge som i <10
        }
    }
}
