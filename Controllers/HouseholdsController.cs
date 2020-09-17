using Newtonsoft.Json;
using RichlynnFinancialPortalWebAPI.Models;
using System.Threading.Tasks;
using System.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;


namespace RichlynnFinancialPortalWebAPI.Controllers
{

    /// <summary>
    /// Household Controller
    /// </summary>
    [RoutePrefix("api/Households")]
    public class HouseholdsController : ApiController
    {
        private ApiDbContext db = new ApiDbContext();

        /// <summary>
        /// Create a household
        /// </summary>
        /// <param name="name"></param>
        /// <param name="greeting"></param>
        /// <returns></returns>
        [Route("CreateHousehold"), HttpPost]
        public async Task<int> CreateHousehold(string name, string greeting)
        {
            return await db.CreateHousehold(name, greeting);
        }



        /// <summary>
        /// Get a list of Households
        /// </summary>
        /// <returns></returns>
        [Route("GetAllHouseholds"), HttpGet]
        public async Task<List<Household>> GetAllHouseholds()
        {
            return await db.GetAllHouseholds();
        }


        /// <summary>
        /// Household list in Javascript Object Notation (json)
        /// </summary>
        /// <returns></returns>

        [Route("GetAllHouseholds/json"), HttpGet]
        public async Task<IHttpActionResult> GetAllHouseholdsJson()
        {
            var json = JsonConvert.SerializeObject(await db.GetAllHouseholds());
            return Ok(json);
        }       


        /// <summary>
        /// Get household data by Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>

        [Route("GetAllHouseholdDataById")]
        public async Task<Household> GetAllHouseholdDataById(int Id)
        {
            return await db.GetAllHouseholdDataById(Id);
            //var json = JsonConvert.SerializeObject(await db.GetAllHouseholdDataById(Id));
            //return Ok(json);
        }
      


        /// <summary>
        /// Get a lot of household data by Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [Route("GetAllHouseholdAndRelatedDataById")]
        public async Task<Household> GetAllHouseholdAndRelatedDataById(int Id)
        {
            return await db.GetAllHouseholdAndRelatedDataById(Id);
        }


        /// <summary>
        /// Even more ways to get household data
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [Route("GetAllDataForHouseholdById")]
        public async Task<IHttpActionResult> GetAllDataForHouseholdById(int Id)
        {
            var json = JsonConvert.SerializeObject(await db.GetAllDataForHouseholdById(Id));
            return Ok(json);
        }



        /// <summary>
        /// Update household data
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [Route("UpdateHouseholdDataById")]
        public async Task<IHttpActionResult> UpdateHouseholdDataById(int Id)
        {
            var json = JsonConvert.SerializeObject(await db.UpdateHouseholdDataById(Id));
            return Ok(json);
        }

        //[Route("DeleteHouseholdDataById")]
        //public async Task<IHttpActionResult> DeleteHouseholdDataById(int Id)
        //{
        //    var json = JsonConvert.SerializeObject(await db.DeleteHouseholdDataById(Id));
        //    return Ok(json);
        //}



        /// <summary>
        /// Delete household data
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [Route("DeleteHouseholdDataById")]
        public async Task<int> DeleteHouseholdDataById(int Id)
        {
            return await db.DeleteHouseholdDataById(Id);
        }

        //[Route("GetAllHouseholds/json")]
        //public async Task<IHttpActionResult> GetAllHouseholds()
        //{
        //    var json = JsonConvert.SerializeObject(await db.GetAllHouseholds());
        //    return Ok(json);
        //}
    }



}
