using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alla_åt_alla_Polymorfism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välj en metod");
            Console.WriteLine("1, 2, 3");
            Console.Write(": ");
            string answer = Console.ReadLine();
            int choice = 0;
            bool result = int.TryParse(answer, out choice);

            switch(choice)
            {
                case 1:
                    Smash();
                    break;

                case 2:
                    Console.WriteLine("Skriv in en siffra för hur många smash som ska skrivas ut");
                    answer = Console.ReadLine();
                    result = int.TryParse(answer, out choice);
                    SmashInt(choice);
                    break;

                case 3:
                    Console.WriteLine("Skriv in vad som ska skrivas ut");
                    Console.Write(": ");
                    answer = Console.ReadLine();
                    Console.WriteLine("Skriv in hur många gånger det ska skrivas ut.");
                    string amount = Console.ReadLine();
                    result = int.TryParse(amount, out choice);
                    SmashMethod(answer, choice);
                    break;
            }
            Console.ReadLine();
        }

        static void Smash()
        {
            Console.WriteLine("Smash!");
        }

        static int SmashInt(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine("Smash!");
            }
            return amount;
        }

        static int SmashMethod (string answer, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine(answer + "!");
            }
            return amount;
        }
    }
}
