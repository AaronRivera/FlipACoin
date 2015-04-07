using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        //Creates a Random number
        static Random rnd = new Random();
        //Creates two static global variables accesible from anywhere
        static int headsCounter = 0;
        static  int tailCounter = 0;

        static void Main(string[] args)
        {

            //Creates a loop that calls the function FlipACoin 1000 times
            for (int i = 0 ; i< 1000 ; i++)
            {
                Console.WriteLine(FlipACoin());
            }

            //At the end it displays the number of tails and heads that were genarated
            Console.WriteLine("Number of heads : " + headsCounter);
            Console.WriteLine("Number of tails : " + tailCounter);
            Console.ReadKey();
        }

        public static string FlipACoin()
        {
            //Compares if the genarated number is a head or a tail and returns the result heads=0 tails=1 and increases the counter

            if (rnd.Next(2) == 0){
                headsCounter++;
                return "Head";
            }
            else
            {
                tailCounter++;
                return "Tails";
            }

           
        }

    }
}
