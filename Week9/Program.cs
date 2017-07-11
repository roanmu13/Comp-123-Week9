using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Rosa Munguia
 Date: July 11 2017
 Description: Demo for Lesson 9
 Version: 0.2- Instantiated a new object of type SuperHuman
 */
namespace Week9
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHuman superHuman = new SuperHuman("Super Dude");
            superHuman.Powers.Add(new Power("Spider Climbing", 50));
        }
    }
}
