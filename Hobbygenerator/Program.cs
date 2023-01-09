using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hobbygenerator
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            string[] hobbies = { "Nintendo-spiller", "buseplukker", "strikker", "tåfis-lukter" };
            string randomHobby = hobbies[rand.Next(hobbies.Length)];
            Console.WriteLine("Hvem skal få en ny hobby?");
            string person = Console.ReadLine();
            Console.WriteLine("Hei " + person + " du har nå blitt en " + randomHobby);
            Console.ReadLine();
        }
    }
}
