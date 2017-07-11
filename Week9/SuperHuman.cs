using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*Rosa Munguia
 Date: July 11 2017
 Description: Super Human class that extends abstract human class
 Version: 0.2- Added _initialize method
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
    }
}