using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_2_9_10__autoproperties
{
    class Program
    {

        //string name; 
        public class Author //using auto properties get, set
        {
            //public string name
            //{
                //get { return name; }
                //
                //set
                //{
                //    if (value != "Fool")
                //        name = value;
                //
                //}
            //}

            public string Name { get; set; }
            public string Book { get; set; }

        }

        static void Main(string[] args)
        {
            Author author1 = new Author() // initializer block
            {
                Name = "Jeffrey Richter",
                Book = "CLR via C#"

            };

            Author author2 = new Author
            {
                Name = "Joanne Rowling",
                Book = "Harry Potter and the prisoner of Azkaban"
            };

            Console.WriteLine("Name:{0}, Book: {1}", author1.Name, author1.Book);
            Console.WriteLine("Name:{0}, Book: {1}", author2.Name, author2.Book);

            Console.ReadKey();
        }
    }
}
