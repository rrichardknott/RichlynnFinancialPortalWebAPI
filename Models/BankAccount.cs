using System;
using System.Collections.Generic;
using RichlynnFinancialPortalWebAPI.Enums;
using System.Linq;
using System.Web;

namespace RichlynnFinancialPortalWebAPI.Models
{
    /// <summary>
    /// Bank Account Information
    /// </summary>
    public class BankAccount
    {
        /// <summary>
        /// Bank Account Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Bank Account's Household Id
        /// </summary>
        public int? HouseholdId { get; set; }
      
        /// <summary>
        /// Bank Account Owner Id
        /// </summary>
        public string OwnerId { get; set; }
       /// <summary>
       /// Bank Account Name
       /// </summary>
        public string AccountName { get; set; }
        /// <summary>
        /// Created Date
        /// </summary>
        public DateTime Created { get; set; }
        
       /// <summary>
       /// Starting Balance
       /// </summary>
        public decimal StartingBalance { get; internal set; }

       /// <summary>
       /// Account Current Balance
       /// </summary>
        public decimal CurrentBalance { get; set; }

       /// <summary>
       /// The amount set to warn if the account is getting too low
       /// </summary>
        public decimal WarningBalance { get; set; }

        /// <summary>
        /// This is a soft delete...recoverable
        /// </summary>
        public bool IsDeleted { get; set; } // considered a soft delete because it can be toggled from true/false
               /// <summary>
               /// Account Type: Checking or Saving
               /// </summary>
        public AccountType AccountType { get; set; }       

    }
}