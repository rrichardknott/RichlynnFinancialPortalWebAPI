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
        /// Create a Transaction
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="budgetItemId"></param>
        /// <param name="transactionType"></param>
        /// <param name="ownerId"></param>
        /// <param name="created"></param>
        /// <param name="amount"></param>
        /// <param name="memo"></param>
        /// <param name="isDeleted"></param>
        /// <returns></returns>

        [Route("CreateTransaction"), HttpPost]
        public async Task<int> CreateTransaction
            (
                int accountId,
                int budgetItemId,
                int transactionType,
                string ownerId,
                DateTime created,
                decimal amount,
                string memo,
                bool isDeleted
            )
        {
            return await db.CreateTransaction
                (
                    accountId,
                    budgetItemId,
                    transactionType,
                    ownerId,
                    created = DateTime.Now,
                    amount,
                    memo,
                    isDeleted

                );
        }




        /// <summary>
        /// Get all transactions
        /// </summary>
        /// <returns></returns>
        [Route("GetAllTransactions")]
        public async Task<List<Transaction>> GetAllTransactions()
        {
            return await db.GetAllTransactions();
            
        }

        /// <summary>
        /// Get all transactions in json
        /// </summary>
        /// <returns></returns>
        [Route("GetAllTransactions/json")]
        public async Task<IHttpActionResult> GetAllTransactionsjson()
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
        /// <param name="id"></param>
        /// <param name="transactionType"></param>
        /// <param name="amount"></param>
        /// <param name="memo"></param>
        /// <returns></returns>

        [Route("UpdateTransactionDataById"), HttpPut]
        public async Task<int> UpdateTransactionDataById
            (
                int id,
                int transactionType,
                decimal amount,
                string memo

             )
        {
            return await db.UpdateTransactionDataById
                (
                    id,
                    transactionType,
                    amount,
                    memo
                    
                 );
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
