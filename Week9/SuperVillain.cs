using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*Rosa Munguia
 Date: July 13 2017
 Description: Creating superVillain Class
 Version: 0.1- Added superHero child class
 */
namespace Week9 { 
    /// <summary>
    /// This is supervillain class
    /// </summary>
    public class SuperVillain:SuperHuman, IHasMalice
    {
        //Private instance variables
        private int _malice;
        //Public Properties
        public int Malice
        {
            get
            {
                return this._malice;
            }
            set
            {
                this._malice = value;
            }
        }
        //Constructors
        public SuperVillain(string name, int malice)
            :base (name)
        {
            this._malice = malice;
        }
    }
}