using Newtonsoft.Json;
using RichlynnFinancialPortalWebAPI.Models;
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
        /// Get a list of all Budget Items
        /// </summary>
        /// <returns></returns>

        [Route("GetAllBudgetItemData")]
        public async Task<IHttpActionResult> GetAllBudgetItemData()
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

        [Route("UpdateBudgetItemDataById")]
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
