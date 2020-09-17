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
        /// Get a list of all budgets
        /// </summary>
        /// <returns></returns>

        [Route("GetAllBudgets")]
        public async Task<IHttpActionResult> GetAllBudgets()
        {
            var json = JsonConvert.SerializeObject(await db.GetAllBudgets());
            return Ok(json);
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
        /// <param name="Id"></param>
        /// <returns></returns>
        [Route("UpdateBudgetDataById")]
        public async Task<IHttpActionResult> UpdateBudgetDataById(int Id)
        {
            var json = JsonConvert.SerializeObject(await db.UpdateBudgetDataById(Id));
            return Ok(json);
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
