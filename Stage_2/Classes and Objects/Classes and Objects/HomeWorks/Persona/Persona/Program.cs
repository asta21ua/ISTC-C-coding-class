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
        //   ա.Առանձին մեթոդներով տպել բորլոր վերը թվարկածները: 
        //    բ.Առանձին մեթոդներով փոփոխել վերը թվարկածները: 
        // 5. Class-ը պետք է ունենա կոնստրուկտոր, որը ինիցիալիզացնի բոլոր վերը նշված field-ները:


        static void Main(string[] args)
        {
            var persona1 = new Persona("Elizabeth", "Black", "female", 24, 68, 165);
            
            //var persona2 = new Persona("Tom", "Smith");

            //"male", 19, 75, 172);

            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", persona1.GivenName, persona1.FamilyName, persona1.Gender, persona1.Age, persona1.Weight, persona1.Height);      
            //Console.WriteLine();

            Console.ReadKey();

        }


    }

}
