using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace RichlynnFinancialPortalWebAPI.Models
{
    /// <summary>
    /// Budget Information
    /// </summary>
    public class Budget
    {

        /// <summary>
        /// ApiDbContext db
        /// </summary>
        private ApiDbContext db = new ApiDbContext();

        /// <summary>
        /// Budget Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Budget Household Id
        /// </summary>
        public int HouseholdId { get; set; }
         

        /// <summary>
        /// Budget Owner Id
        /// </summary>
        public string OwnerId { get; set; }
         


        /// <summary>
        /// Budget Created Date
        /// </summary>
        public DateTime Created { get; set; }
        


        /// <summary>
        /// Budget Name
        /// </summary>
        public string BudgetName { get; set; }
        


        /// <summary>
        /// Budget Current Amount
        /// </summary>
        public decimal CurrentAmount { get; set; }
        


        /// <summary>
        /// Budget Target Amount
        /// </summary>
        public decimal TargetAmount
        {
            get; set;
            //get
            //{
            //    var target = db.BudgetItems.Where(bI => bI.BudgetId == Id).Count();
            //    return target != 0 ? db.BudgetItems.Where(bI => bI.BudgetId == Id).Sum(s => s.TargetAmount) : 0;
            //}
        }


        /// <summary>
        /// High level coding going on here
        /// </summary>
        /// <param name="isTrue"></param>       
        public Budget(bool isTrue) { }
        public Budget()
        {
            
            Created = DateTime.Now;            
            CurrentAmount = 0;

        }

    }
}