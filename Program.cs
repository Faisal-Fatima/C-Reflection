using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a Car object with sample values
            Car myCar = new Car("Honda", "Accord", "AB20DCE", 2020, 10000.0);

            // Printing the details using the overridden ToString method
            Console.WriteLine(myCar);
        }
    }
}