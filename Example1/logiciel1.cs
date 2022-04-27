using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    public class logiciel1
    {

        public static void Main(String[] args)
        {
        
        String prenom;
        int age;

        Console.WriteLine("Tapez le prénom: ");
        prenom=Console.ReadLine();

        Console.WriteLine("Tapez l\'agê de la personne: ");
        age=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Salut {prenom} ton agê est {age}");

        Console.ReadKey();
        }
    }
}
