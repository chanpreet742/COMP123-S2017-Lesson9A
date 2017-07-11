using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: chanpreet mudhar
 * Date: July 11, 2017
 * Description: This is the driver class for my project
 * Version: 0.1 Instantiated an object of the type SuperHuman
 */
namespace COMP123_S2017_Lesson9A
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHuman superHuman = new SuperHuman("Superdude");
            superHuman.Powers.Add(new Power("Teleportation",50)); //Setting up anonymous object
        }
    }
}
