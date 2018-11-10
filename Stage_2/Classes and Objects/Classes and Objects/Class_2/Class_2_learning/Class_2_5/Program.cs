using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_2_5
{ // Creating a Class with a single entrance property  
    class Constants
    {
        private double pi = 3.14D;
        private double e = 2.7D;

        public double Pi //Write-Only property
        {
            set { pi = value; }
        }

        public double E // Read_Only property 
        {
            get { return e; }
        }



        class Program
        {
            static void Main(string[] args)
            {
                Constants constants = new Constants();
                constants.Pi = 3.14159265D;
                //constants.E = 2.7D; there is only getter and it's impossible to set the value for e

                //Console.WriteLine(constants.Pi); for pi the setter was used and it's impossible to cool Pi value
                Console.WriteLine(constants.E);

                Console.ReadKey();


            }
        }
    }
}
