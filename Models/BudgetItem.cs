using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RichlynnFinancialPortalWebAPI.Models
{
    /// <summary>
    /// Budget Item Information
    /// </summary>
    public class BudgetItem
    {


        /// <summary>
        /// Budget Item Id
        /// </summary>        
        public int Id { get; set; }


        /// <summary>
        /// Budget Item Id
        /// </summary>
        public int BudgetId { get; set; }


        /// <summary>
        /// Budget Item Created
        /// </summary>
        public DateTime Created { get; set; }


        /// <summary>
        /// Budget Item Name
        /// </summary>
        public string ItemName { get; set; }


        /// <summary>
        /// Budget Item Target Amount
        /// </summary>
        public decimal TargetAmount { get; set; }


        /// <summary>
        /// Budget Item Current Amount
        /// </summary>
        public decimal CurrentAmount { get; set; }


        /// <summary>
        /// Budget Item Soft-Delete
        /// </summary>
        public bool IsDeleted { get; set; }

    }
}