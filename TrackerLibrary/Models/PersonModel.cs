﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// The unique identifier for the prize.
        /// </summary>
        public int Id { get; set; }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAdress { get; set; }
        public string CellphoneNumber { get; set; }
    }
}