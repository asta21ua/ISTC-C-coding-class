using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    class Persona
    //Creating private class Human with following  private fields: givenName, familyname,gender, age, weigth and heigth 
    {
        private string givenname;
        private string familyname;
        private string gender;
        private int age;
        private float weight;
        private float height;


        // making of private field into public

        public string GivenName
        {
            get { return givenname; }
        }

        public string FamilyName
        {
            get { return familyname; }

        }

        public string Gender

        {

            get { return gender; }
        }

        public int Age
        {

            get { return age; }

        }

        public float Weight
        {
            get { return weight; }

        }

        public float Height
        {
            get { return height; }

        }

        // using this statement
        // whan using this statement must!!! create default constructor like following

        public Persona()
        {

        }


        public Persona(string GivenName, string FamilyName) 
            //string Gender, int Age, float Weight, float Height)
        {

            this.givenname = GivenName;
            this.familyname = FamilyName;
            this.gender = Gender;
            this.age = Age;
            this.weight = Weight;
            this.height = Height;

            Console.WriteLine("GivenName, FamilyName, Gender, Age, Weight, Height");
        }



    }
}
