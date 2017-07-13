using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Rosa Munguia
 Date: July 11 2017
 Description: Demo for Lesson 9
 Version: 0.5- Implemented the toString method of the superhuman class
 */
namespace Week9
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHuman superHuman = new SuperHuman("Super Dude");
            superHuman.AddPower("Spider Climbing", 50);
            superHuman.AddPower("Webcasting", 40);
            Console.WriteLine(superHuman.ToString());
        }
    }
}
