using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: chanpreet mudhar
 * Date: July 11, 2017
 * Description: This is the new power data type
 * derive from
 * Version: 0.2 Add a custom constructor to add name and rank
 */
namespace COMP123_S2017_Lesson9A
{
    /// <summary>
    /// The power class contains the data and structure of each superclass
    /// </summary>
    public class Power
    {
        // Public Properties
        public string Name { get; set; }
        public int Rank { get; set; }
        //CONSTRUCTORS ---------------------
        /// <summary>
        /// This is the power constructor. Takes two parameters- name(string) and rank (int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public Power(string name,int rank)
        {
            this.Name = name;
            this.Rank = rank;
        }
    }
}