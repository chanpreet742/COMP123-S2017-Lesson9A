﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: chanpreet mudhar
 * Date: July 11, 2017
 * Description: This is the SperHuman subcass 
 * Version: 0.3 Added public AddPower method 
 */
namespace COMP123_S2017_Lesson9A
{
    /// <summary>
/// This is the superhuman subclass.
/// It inherits from the human Superclass
/// </summary>
    class SuperHuman : Human
    {
        //PRIVATE FIELDS
        private List<Power> _powers;

        //PUBLIC PROPERTIES
        public List<Power> Powers
        {
            get
            {
                return this._powers;//returns a reference to the powers list          
            }
        }

        //CONSTRUCTORS
        public SuperHuman(string name)
            :base(name)
        {
            this._initialize();
        }
        //PRIVATE METHODS
        /// <summary>
        /// This method initializes and assigns default values
        /// </summary>
        private void _initialize()
        {
            this._powers = new List<Power>();
        }
        //PUBLIC METHODS
        /// <summary>
        /// This method adds a power to the power list.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public void AddPower(string name, int rank)
        {
            this.Powers.Add(new Power(name, rank));
        }

        public void DisplayPowers()
        {
            foreach(var power in Powers)
            {
                Console.WriteLine("Name: " + power.Name + "Rank: " +power.Rank);
            }
        }
    }
}
