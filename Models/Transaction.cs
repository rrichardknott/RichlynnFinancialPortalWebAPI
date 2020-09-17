
using RichlynnFinancialPortalWebAPI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace RichlynnFinancialPortalWebAPI.Models
{
    /// <summary>
    /// Transaction Information
    /// </summary>
    public class Transaction
    {

        /// <summary>
        /// Transaction Id
        /// </summary>
        public int Id { get; set; }
        

        /// <summary>
        /// Transaction Account Id
        /// </summary>
        public int AccountId { get; set; }    


        /// <summary>
        /// Transaction Budget Item Id
        /// </summary>
        public int? BudgetItemId { get; set; }      


        /// <summary>
        /// Transaction Type
        /// </summary>
        public TransactionType TransactionType { get; set; }


        /// <summary>
        /// Transaction Owner Id
        /// </summary>
        public string OwnerId { get; set; }       


        /// <summary>
        /// Transaction Created Date
        /// </summary>
        public DateTime Created { get; set; }


        /// <summary>
        /// Transaction Amount
        /// </summary>
        public decimal Amount { get; set; }


        /// <summary>
        /// Transaction Memo
        /// </summary>
        public string Memo { get; set; } // description of transaction       


        /// <summary>
        /// Transaction Soft Delete
        /// </summary>
        public bool IsDeleted { get; set; }

       
    }
}