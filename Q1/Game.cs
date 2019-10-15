using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
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
    public abstract class Game
    {
        //Properties
        //name readonly in constructor
        #region Properties
        private readonly string _name;

        public string Name
        {
            get
            {
                return _name;
            }
        }


        public decimal Price { get; set; }

        public DateTime RealeaseDate { get; set; }
        #endregion Properties

        #region Constructors
        //constructors
        public Game(string name, decimal price, DateTime relaseDate)
        {
            _name = name;
            Price = price;
           RealeaseDate = relaseDate;
        }

        public Game(string name, decimal price) : 
            this(name, price, DateTime.Now)
        {

        }

        

        public Game() : this("", 0) { }

        #endregion Constructors

        //to string method
        public override string ToString()
        {

            {
                return string.Format($"{Name,-15}{Price,-15}{RealeaseDate,-25}");
            }
        }

        //update price abstract
        //abstract means that instead of the main class having the method for update price
        //the sub class has it and and the main class takes it from there
        public abstract void UpdatePrice(decimal percentageIncrease);
        //{
           // Price *= (1 + percentageIncrease);
        //}


    }


}
