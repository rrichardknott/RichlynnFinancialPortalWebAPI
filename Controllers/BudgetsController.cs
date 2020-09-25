using Newtonsoft.Json;
using RichlynnFinancialPortalWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace RichlynnFinancialPortalWebAPI.Controllers
{
    /// <summary>
    /// Budgets Controller
    /// </summary>
    [RoutePrefix("api/Budgets")]
    public class BudgetsController : ApiController
    {
        private ApiDbContext db = new ApiDbContext();


        /// <summary>
        /// Create a Budget
        /// </summary>
        /// <param name="householdId"></param>
        /// <param name="ownerId"></param>
        /// <param name="created"></param>
        /// <param name="budgetName"></param>
        /// <param name="currentAmount"></param>
        /// <returns></returns>
        [Route("CreateBudget"), HttpPost]
        public async Task<int> CreateBudget
            (
                int householdId,
                string ownerId,               
                DateTime created,
                string budgetName,
                decimal currentAmount
            )
        {
            return await db.CreateBudget
                (
                    householdId,
                    ownerId,                   
                    created = DateTime.Now,
                    budgetName,
                    currentAmount

                );
        }




        /// <summary>
        /// Get a list of all budgets
        /// </summary>
        /// <returns></returns>

        [Route("GetAllBudgets"), HttpGet]
        public async Task<List<Budget>> GetAllBudgets()
        {
            return await db.GetAllBudgets();
        }



        /// <summary>
        /// Budget by Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>A Single Budget</returns>
        [Route("GetAllBudgetDataById")]
        public async Task<IHttpActionResult> GetAllBudgetDataById(int Id)
        {
            var json = JsonConvert.SerializeObject(await db.GetAllBudgetDataById(Id));
            return Ok(json);
        }



        /// <summary>
        /// Budget Item by Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [Route("GetBudgetAndBudgetItemDataById")]
        public async Task<IHttpActionResult> GetBudgetAndBudgetItemDataById(int Id)
        {
            var json = JsonConvert.SerializeObject(await db.GetBudgetAndBudgetItemDataById(Id));
            return Ok(json);
        }



        /// <summary>
        /// Update Budget Item
        /// </summary>
        /// <param name="id"></param>
        /// <param name="budgetName"></param>
        /// <returns></returns>
        [Route("UpdateBudgetDataById"), HttpPut]
        public async Task<int> UpdateBudgetDataById
            (
                int id,
                string budgetName
            )
        {
            return await db.UpdateBudgetDataById
                (
                    id,
                    budgetName
                );
        }



        /// <summary>
        /// Delete Budget Item
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [Route("DeleteBudgetDataById")]
        public async Task<IHttpActionResult> DeleteBudgetDataById(int Id)
        {
            var json = JsonConvert.SerializeObject(await db.DeleteBudgetDataById(Id));
            return Ok(json);
        }


    }
}
