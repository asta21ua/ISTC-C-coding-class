using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    class Program
    {
        // 1.Սահմանել մարդ class -ը որի մեջ լինի հետևյալ field-ները Անուն Ազգանուն Տարիք Քաշ Սեռ:
        // 2.Որտեղ բոլորը հասանաելի չեն դրսից (private են) և կարող է կատարել հետևյալ գործողությունները`
        //   ա.Առանձին մեթոդներով տպել բոլրոր վերը թվարկածները: 
        //    բ.Առանձին մեթոդներով փոփոխել վերը թվարկածները: 
        // 5. Class-ը պետք է ունենա կոնստրուկտոր, որը ինիցիալիզացնի բոլոր վերը նշված field-ները:


        static void Main(string[] args)
        {
            Console.WriteLine("************** Fun with Class************");
    

            var persona1 = new Persona("Elizabeth", "Black", "female", 24, 68, 165);
            var person2 = new Persona("Alex", "Smith", "Male", 36, 78, 179);
            persona1.DiscribeYourself();

            Console.WriteLine();

            persona1.Print();

            Console.WriteLine();

            person2.DiscribeYourself();

            person2.Print();


            Console.ReadKey();

        }


    }

}
