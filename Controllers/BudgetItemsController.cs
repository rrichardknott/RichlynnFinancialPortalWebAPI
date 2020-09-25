using Newtonsoft.Json;
using RichlynnFinancialPortalWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;


namespace RichlynnFinancialPortalWebAPI.Controllers
{
    /// <summary>
    /// Budget Items Controller
    /// </summary>
    [RoutePrefix("api/BudgetItems")]
    public class BudgetItemsController : ApiController
    {
        private ApiDbContext db = new ApiDbContext();

        /// <summary>
        /// Create a Budget Item
        /// </summary>
        /// <param name="budgetId"></param>
        /// <param name="created"></param>
        /// <param name="itemName"></param>
        /// <param name="targetAmount"></param>
        /// <param name="currentAmount"></param>
        /// <param name="isDeleted"></param>
        /// <returns></returns>
        [Route("CreateBudgetItem"), HttpPost]        
        public async Task<int> CreateBudgetItem
        (
            int budgetId,               
            DateTime created,
            string itemName,
            decimal targetAmount,
            decimal currentAmount,
            bool isDeleted
        )
        {
            return await db.CreateBudgetItem
                (
                    budgetId,
                    created = DateTime.Now,
                    itemName,
                    targetAmount,
                    currentAmount,
                    isDeleted
                );
        }

        /// <summary>
        /// List of Budget Items
        /// </summary>
        /// <returns></returns>
        /// 

        [Route("GetAllBudgetItemData"), HttpGet]
        public async Task<List<BudgetItem>> GetAllBudgetItemData()
        {
            return await db.GetAllBudgetItemData();
            //var json = JsonConvert.SerializeObject(await db.GetAllBankAccounts());
            //return Ok(json);
        }

        /// <summary>
        /// List of Budget Items in json
        /// </summary>
        /// <returns></returns>
        /// 
        [Route("GetAllBudgetItemData/json")]
        public async Task<IHttpActionResult> GetAllBudgetItemDatajson()
        {
            var json = JsonConvert.SerializeObject(await db.GetAllBudgetItemData());
            return Ok(json);
        }

        /// <summary>
        /// Budget Items by Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [Route("GetAllBudgetItemDataById")]
        public async Task<IHttpActionResult> GetAllBudgetItemDataById(int Id)
        {
            var json = JsonConvert.SerializeObject(await db.GetAllBudgetItemDataById(Id));
            return Ok(json);
        }

        /// <summary>
        /// Update Budget Items
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>

        [Route("UpdateBudgetItemDataById"), HttpPut]
        public async Task<IHttpActionResult> UpdateBudgetItemDataById(int Id)
        {
            var json = JsonConvert.SerializeObject(await db.UpdateBudgetItemDataById(Id));
            return Ok(json);
        }



        /// <summary>
        /// Delete Budget Items
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [Route("DeleteBudgetItemDataById")]
        public async Task<IHttpActionResult> DeleteBudgetItemDataById(int Id)
        {
            var json = JsonConvert.SerializeObject(await db.DeleteBudgetItemDataById(Id));
            return Ok(json);
        }

    }
}
