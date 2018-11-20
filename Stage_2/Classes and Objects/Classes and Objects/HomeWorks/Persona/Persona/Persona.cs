using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    class Persona
    //Creating private class Human with following  private fields: givenName, familyname, gender, age, weigth and heigth 
    {
        private string givenname;
        private string familyname;
        private string gender;
        private int age;
        private float weight;
        private float height;


        // making of private field into public

        //public string GivenName { get; set; }
        //public string FamilyName { get; set; }
        //public string Gender { get; set; }
        //public int Age { get; set; }
        //public float Weight { get; set; }
        //public float Height { get; set; }



        // using this statement
        // when using this statement must!!! create default constructor like following

        public Persona()
        {

        }

        public Persona(string GivenName, string FamilyName, string Gender, int Age, float Weight, float Height)
        {
        
            this.givenname = GivenName;
            this.familyname = FamilyName;
            this.gender = Gender;
            this.age = Age;
            this.weight = Weight;
            this.height = Height;
        
        }

        public void Print()
        {
            Console.WriteLine("GivenName:" + givenname);
            Console.WriteLine("FamilyName:" + familyname);
            Console.WriteLine("Gender:" +gender);
            Console.WriteLine("Age:"+ age);
            Console.WriteLine("Weight:" + weight);
            Console.WriteLine("Heigh:" + height);


        }

        public void DiscribeYourself()
        {
            Console.WriteLine($"Hi I'm {givenname} {familyname} а {gender}. I'm {age} years old. My weight is {weight} and height {height}.");
        }
        

    }
}
