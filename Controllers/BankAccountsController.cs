using Newtonsoft.Json;
using RichlynnFinancialPortalWebAPI.Models;
using RichlynnFinancialPortalWebAPI.Enums;
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
    /// Bank Accounts Controller
    /// </summary>
    [RoutePrefix("api/BankAccounts")]

    public class BankAccountsController : ApiController
    {
        private ApiDbContext db = new ApiDbContext();

        /// <summary>
        /// Create a Bank Account
        /// </summary>
        /// <param ownerId="be2b5c28-983d-4522-a284-dada7db71b3d"></param>        
        /// 

        [Route("CreateBankAccount"), HttpPost]
       
        public async Task<int> CreateBankAccount
            (
                int householdId,
                string ownerId,
                string accountName,
                DateTime created,
                decimal startingBalance,
                decimal currentBalance,
                decimal warningBalance,
                bool isDeleted,
                AccountType accountType
            )
        {
            return await db.CreateBankAccount
                (
                    householdId,
                    ownerId,
                    accountName,
                    created = DateTime.Now,
                    startingBalance,
                    currentBalance,
                    warningBalance,
                    isDeleted,
                    accountType

                ); 
        }

        /// <summary>
        /// Get a list of all Bank Accounts
        /// </summary>
        /// <returns></returns>
        /// 
        [Route("GetAllBankAccounts"), HttpGet]
        public async Task<List<BankAccount>> GetAllBankAccounts()
        {
            return await db.GetAllBankAccounts();
            //var json = JsonConvert.SerializeObject(await db.GetAllBankAccounts());
            //return Ok(json);
        }

        /// <summary>
        /// Select a specific account
        /// </summary>        
        /// 
        [Route("GetAllBankAccountDataById"), HttpGet]
        public async Task<BankAccount> GetAllBankAccountDataById(int Id)
        {
            return await db.GetAllBankDataById(Id);
        }

        /// <summary>
        /// Return data in json
        /// </summary>        
        /// 
        [Route("GetAllBankAccountDataById/json"), HttpGet]
        public async Task<IHttpActionResult> GetAllBankDataByIdJson(int Id)
        {
            var json = JsonConvert.SerializeObject(await db.GetAllBankDataById(Id));
            return Ok(json);
        }


        /// <summary>
        /// Transaction information
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        /// 


        [Route("GetBankAndTransactionDataById"), HttpGet]
        public async Task<BankAccount> GetBankAndTransactionDataById(int Id)
        {
            return await db.GetAllBankDataById(Id);
        }


        /// <summary>
        /// Return data in json
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        /// 
        [Route("GetBankAndTransactionDataById/json")]
        public async Task<IHttpActionResult> GetBankAndTransactionDataByIdJson(int Id)
        {
            var json = JsonConvert.SerializeObject(await db.GetBankAndTransactionDataById(Id));
            return Ok(json);
        }

        /// <summary>
        /// Update account information
        /// </summary>        
        /// 
        [Route("UpdateBankAccountDataById"), HttpPut]
        public async Task<int> UpdateBankAccountDataById 
            (
                int id,               
                decimal startingBalance,
                decimal currentBalance,
                decimal warningBalance,                
                AccountType accountType
            )
        {
            return await db.UpdateBankAccountDataById
                (
                    id,                   
                    startingBalance,
                    currentBalance,
                    warningBalance,                   
                    accountType

                );
        }

        /// <summary>
        /// Update account information
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        ///
        //[Route("UpdateBankAccountDataById/json")]
        //public async Task<IHttpActionResult> UpdateBankAccountDataByIdJson(int Id)
        //{
        //    var json = JsonConvert.SerializeObject(await db.UpdateBankAccountDataById(Id));
        //    return Ok(json);
        //}


        /// <summary>
        /// Delete account information
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [Route("DeleteBankAccountDataById")]
        public async Task<IHttpActionResult> DeleteBankAccountDataById(int Id)
        {
            var json = JsonConvert.SerializeObject(await db.DeleteBankAccountDataById(Id));
            return Ok(json);
        }


    }
}
