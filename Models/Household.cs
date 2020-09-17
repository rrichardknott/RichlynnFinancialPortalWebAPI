using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RichlynnFinancialPortalWebAPI.Models
{

    /// <summary>
    /// Household Model
    /// </summary>
    public class Household
    {
        /// <summary>
        /// The Primary Key (PK) of the Model
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Household Name
        /// </summary>
        public string HouseholdName { get; set; }
        /// <summary>
        /// Household Greeting
        /// </summary>
        public string Greeting { get; set; }
        /// <summary>
        /// Household Created Date
        /// </summary>
        public DateTime Created { get; set; }     
        
        /// <summary>
        /// Soft delete boolean value
        /// </summary>
        public bool IsDeleted { get; set; }   
        

    }
}