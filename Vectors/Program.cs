using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create two instances to the vector class
            Vector v1 = new Vector(1, 2,3);
            Vector v2 = new Vector(3, 3,3);

           
            //Output the addition and subtraction of the two instances of the vector class
            Console.WriteLine(v1+v2);
            Console.WriteLine(v1-v2);

            //Change the direction of a vector
            Vector v3 = new Vector(2,0,-4);
            Console.WriteLine(-v3);

            //Multiply a vector
            Vector v4 = new Vector(1,2,3);
            Console.WriteLine(v4 * 4);

            //Divide a vector
            Vector v5 = new Vector(2,4,6);
            Console.WriteLine(v5/2);
        }
    }
}
