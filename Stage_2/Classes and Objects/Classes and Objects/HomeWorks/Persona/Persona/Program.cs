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
            var persona1 = new Persona("Elizabeth", "Black", "female", 24, 68, 165);
            persona1.DiscribeYourself();

            Console.ReadKey();

        }


    }

}
