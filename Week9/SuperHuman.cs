using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*Rosa Munguia
 Date: July 11 2017
 Description: Super Human class that extends abstract human class
 Version: 0.4- Add DisplayPpowers method
 */
namespace Week9
{
    /// <summary>
    /// This is superHuman class
    /// </summary>
    public class SuperHuman : Human
    {
        //Private instance variable(fields)
        private List<Power> _powers;

        //public properties
        public List<Power> Powers
        {
            get
            {
                return this._powers;//this returns a reference
            }
        }

        //constructors
        /// <summary>
        /// main constructor for super human class. It takes one argument: name(string)
        /// </summary>
        /// <param name="name"></param>
        public SuperHuman(string name) :base(name)
        {
            this._initialize();
        }
        //private methods
        /// <summary>
        /// this method initializaes, instantiates and assigns values to class properties
        /// </summary>
        private void _initialize()
        {
            this._powers = new List<Power>();//creates an empty list
        }

        //public methods
        /// <summary>
        /// method ass a power to the powe list
        /// It take two parameters: name(string), rank(int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public void AddPower(string name, int rank)
        {
            this.Powers.Add(new Power(name, rank));
        }
        /// <summary>
        /// This method displays each of the poers stored in the powers list
        /// </summary>
        public void DisplayPowers()
        {
            foreach (Power power in this.Powers)
            {
                Console.WriteLine("Power: " + power + "Rank: " + power.Rank);
            }
        }
    }
}