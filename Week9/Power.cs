using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*Rosa Munguia
 Date: July 11 2017
 Description: Created power class
 Version: 0.1- Created for power class
 */
namespace Week9
{/// <summary>
/// this is the power class which will be used as a data type
/// </summary>
    public class Power
    {
        
        //public properties
        public string Name { get; set; }
        public int Rank { get; set; }
        //constructors

        public SuperHuman(string name) :base(name)
        {

        }
     
    }
}