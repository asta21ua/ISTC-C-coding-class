using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_3_learning
{
    class Animal
    {
        //class variables
        //understending the static filed
        public static int Count = 0;

        public string name;
        public int age;
        public float happiness;

        //class constructors

        public Animal()
        {
            name = "Jako";
            age = 5;
            happiness = 0.5f;

            Count++;

        }

        public Animal(string _name, int _age, int v, float _happiness)
        {

            name = _name;
            age = _age;
            happiness = _happiness;

            Count++;

        }


        // class method
        public void Print()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Happiness: " + happiness);
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Animal ("Jako", 5, 0,4);

            //Console.WriteLine(dog.name);
            dog.Print();
            
            Animal cat = new Animal ("Mr.Snow", 3, 0,7);
            cat.Print();

            //Animale.Count += 2;

            Console.WriteLine();

            Console.WriteLine("Number of Animals" + Animal.Count);


            //Console.WriteLine(Animale.Count);



            Console.ReadKey();

        }
    }
}
