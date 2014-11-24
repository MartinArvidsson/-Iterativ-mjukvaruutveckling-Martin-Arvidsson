using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv vad du vill ska testas om det är ett palidrom");
            Console.WriteLine("Exempel du kan skriva är bl.a: apa, kajak, ni talar bra latin." );
            string UserInfo = Console.ReadLine().Replace(" ", "").ToLower();
            bool Palindrome = PalindromeInfo(UserInfo);
            if (Palindrome == true)
            {
                Console.WriteLine("Ja det är ett palindrom");
            }
            else // Annars
            {
                Console.WriteLine("Tyvärr ingen palindrom");
            }
        }
        static bool PalindromeInfo(string input) // här testas textsträngen om den är ett palindrom
        {
            int highest = input.Length -1;  //Den sista bokstaven
            int lowest = 0; //Den fösta bokstaven
            for (int i =0; i < input.Length; i++) //Så länge som inte alla bokstäver i strängen har kollat körs loopen
            {
                if (input[highest] != input[lowest]) //Om något inte matchar bryts loopen 
                {
                    return false;
                }
                if (input[highest] == input[lowest]) //Om bokstäverna matchar lägg till ett steg till vänster och minska ett till höger  
                {
                    highest--;
                    lowest++;
                }
            }
            return true; //Om det inmatade går igenom retunera sant!
        }
    }
}
