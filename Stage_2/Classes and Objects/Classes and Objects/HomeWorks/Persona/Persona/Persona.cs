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

        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public float Weight { get; set; }
        public float Height { get; set; }



        // using this statement
        // whan using this statement must!!! create default constructor like following

        public Persona()
        {

        }

        public Persona(string GivenName, string FamilyName, string Gender, int Age, float Weight, float Height)
        {

            givenname = GivenName;
            familyname = FamilyName;
            gender = Gender;
            age = Age;
            weight = Weight;
            height = Height;

        }

        public void DiscribeYourself()
        {
            Console.WriteLine($"Hi I'm {GivenName} {FamilyName} {Gender} I'm {Age} years old My weight is {Weight} and height {Height}");
        }


    }
}
