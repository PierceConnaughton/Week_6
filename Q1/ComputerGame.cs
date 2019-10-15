using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    public class ComputerGame : Game
        /*Extend the game class to a ComputerGame class.  
         * Add a PEGI rating property.  Update the ToString() method to display PEGI rating.   
         * Add a method called GetDiscountPrice in the ComputerGame class
         * 
         * Override this method in the ComputerGame class.  
         * In addition to the behaviour of the base class this overridden method must 
         * also write to the console that it is updating the price from the ComputerGame class.  
         * Why will it not allow you to override, what needs to be changed?
         */
    {
        #region Properties
        public string PEGI_Rating { get; set; }

        #endregion Properties

        #region Constructors
        public ComputerGame(string _name, decimal _price, DateTime _relaseDate,string _pegi) : base(_name,_price,_relaseDate)
        {
            PEGI_Rating = _pegi;
        }

        #endregion Constructors

        //sub class method for discount price
        public decimal GetDiscountPrice()
        {
            return Price * .9m;
        }

        //sub class method for update price
        public override void UpdatePrice(decimal percentageIncrease)
        {
            Price *= (1 + percentageIncrease);
            Console.WriteLine("Updating Price from computer Game Class");
        }

        //sub class to string
        public override string ToString()
        {
          return  string.Format($"{Name,-15}{Price,-15}{RealeaseDate,-25}{PEGI_Rating,-15}");
        }


    }
    }
