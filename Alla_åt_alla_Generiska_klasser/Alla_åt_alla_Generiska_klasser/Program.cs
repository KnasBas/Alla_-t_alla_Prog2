using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alla_åt_alla_Generiska_klasser
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy e1 = new Enemy(); //Utforskar hur man kan skapa generiska klasser med listor eftersom jag tidigare inte riktigt greppat deras funktion.

            List<Enemy> enemylist = new List<Enemy>();

            Console.WriteLine("Hur många enemies?");
            string amount = Console.ReadLine();
            int j = 0;
            bool result = int.TryParse(amount, out j);

            for (int i = 0; i < j; i++)
            {
                enemylist.Add(e1);
                Console.WriteLine(e1.GetHp());
            }

            Console.ReadLine();          
        }
    }
}
