using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        /*1.	Constructor Linking/Constructor Initializers
         * Create a class called Game which has the following properties
         * •	Name:string
         * •	Price:decimal
         * •	ReleaseDate:DateTime
         * Create a constructor which has three parameters, one for each property
         * Through constructor linking create two other constructors which link to this main constructor.  These constructors are shown below.  
         * public Game(string name, decimal price):this(name, price, DateTime.Now)
         * public Game() : this("", 0)
         *Add a ToString() method which displays all properties.
         */

        static void Main(string[] args)
        {
            
            //computer game object created
            ComputerGame g3 = new ComputerGame("Monopoly", 19.99m,DateTime.Now,"18");


            Console.WriteLine("{0,-15}{1,-15}{2,-25}{3,-15}","Name","Price","Release Date","PEGI Rating");
            
            //run display game method for object
            DisplayGame(g3);
            
            //run objcet to string method
            Console.WriteLine(g3.ToString());

            Console.WriteLine();
            Console.Write("Discount Price : ");
            //run Computer Game Discount method
            Console.WriteLine(g3.GetDiscountPrice());

            Console.WriteLine();
            
            //update price of object
            g3.UpdatePrice(12);

            Console.WriteLine();
            Console.WriteLine("{0,-15}{1,-15}{2,-25}{3,-15}", "Name", "Price", "Release Date", "PEGI Rating");
            
            DisplayGame(g3);

           

            


        }
        //method using an object game as an argument
        static void DisplayGame(Game game)
        {
            Console.WriteLine(game);
        }

    }
}
