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
    /// Transaction Controller
    /// </summary>
    [RoutePrefix("api/Transactions")]    
    public class TransactionsController : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        private ApiDbContext db = new ApiDbContext();



        /// <summary>
        /// Get all transactions
        /// </summary>
        /// <returns></returns>
        [Route("GetAllTransactions")]
        public async Task<IHttpActionResult> GetAllTransactions()
        {
            var json = JsonConvert.SerializeObject(await db.GetAllTransactions());
            return Ok(json);
        }



        /// <summary>
        /// Get a transaction by Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [Route("GetAllTransactionsById")]
        public async Task<IHttpActionResult> GetAllTransactionDataById(int Id)
        {
            var json = JsonConvert.SerializeObject(await db.GetAllTransactionDataById(Id));
            return Ok(json);
        }


        /// <summary>
        /// Update a transaction
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>

        [Route("UpdateTransactionDataById")]
        public async Task<IHttpActionResult> UpdateTransactionDataById(int Id)
        {
            var json = JsonConvert.SerializeObject(await db.UpdateTransactionDataById(Id));
            return Ok(json);
        }



        /// <summary>
        /// Delete a transaction
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [Route("DeleteTransactionDataById")]
        public async Task<IHttpActionResult> DeleteTransactionDataById(int Id)
        {
            var json = JsonConvert.SerializeObject(await db.DeleteTransactionDataById(Id));
            return Ok(json);
        }
    }
}
