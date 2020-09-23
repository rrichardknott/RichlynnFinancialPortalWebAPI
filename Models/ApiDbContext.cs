using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using RichlynnFinancialPortalWebAPI.Enums;

namespace RichlynnFinancialPortalWebAPI.Models
{

    /// <summary>
    /// ApiDbContext inherits from DbContext
    /// </summary>
    public class ApiDbContext : DbContext
    {
        /// <summary>
        /// ApiDbContext is provided the connection string to talk to the database
        /// </summary>
        public ApiDbContext()
        
            :base("DefaultConnection")
        {
        
        
        }


        #region
        //BankAccount========================================================  
        /// <summary>
        /// ApiDbContext - Creating a bank account
        /// </summary>       
        /// <returns></returns>
        public async Task<int> CreateBankAccount
            (int HouseholdId, 
            string OwnerId, 
            string AccountName, 
            DateTime Created,
            decimal StartingBalance,
            decimal CurrentBalance,
            decimal WarningBalance,
            bool IsDeleted,
            AccountType AccountType
            )
        {      

            return await Database.ExecuteSqlCommandAsync("CreateBankAccount @HouseholdId, @OwnerId, @AccountName, @Created, @StartingBalance, @CurrentBalance, @WarningBalance, @IsDeleted, @AccountType",
                new SqlParameter("HouseholdId", HouseholdId),
                new SqlParameter("OwnerId", OwnerId),
                new SqlParameter("AccountName", AccountName),
                new SqlParameter("Created", Created),
                new SqlParameter("StartingBalance", StartingBalance),
                new SqlParameter("CurrentBalance", CurrentBalance),
                new SqlParameter("WarningBalance", WarningBalance),
                new SqlParameter("IsDeleted", IsDeleted),
                new SqlParameter("AccountType", AccountType)
                );          


        }



        /// <summary>
        /// ApiDbContext - Get all bank accounts
        /// </summary>
        /// <returns></returns>
        public async Task<List<BankAccount>> GetAllBankAccounts()
        {
            return await Database.SqlQuery<BankAccount>("GetAllBankAccounts").ToListAsync();
        }

        /// <summary>
        /// ApiDbContext - Get all bank accounts by Id
        /// </summary>
        /// <returns></returns>
        public async Task<BankAccount> GetAllBankDataById(int Id)
        {
            return await Database.SqlQuery<BankAccount>("GetAllBankDataById @Id", new SqlParameter("Id", Id)).FirstOrDefaultAsync();
        }

        /// <summary>
        /// ApiDbContext - Get bank and transaction data
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<BankAccount> GetBankAndTransactionDataById(int Id)
        {
            return await Database.SqlQuery<BankAccount>("GetBankAndTransactionDataById @Id", new SqlParameter("Id", Id)).FirstOrDefaultAsync();
        }



        /// <summary>
        /// ApiDbContext - Update bank account
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        /// 

        public async Task<int> UpdateBankAccountDataById
            (int Id,            
            decimal StartingBalance,
            decimal CurrentBalance,
            decimal WarningBalance,            
            AccountType AccountType
            )
        {


            return await Database.ExecuteSqlCommandAsync("UpdateBankAccountDataById @Id, @StartingBalance, @CurrentBalance, @WarningBalance, @AccountType",
                new SqlParameter("Id", Id),                
                new SqlParameter("StartingBalance", StartingBalance),
                new SqlParameter("CurrentBalance", CurrentBalance),
                new SqlParameter("WarningBalance", WarningBalance),                
                new SqlParameter("AccountType", AccountType)
                );


        }

        //public async Task<BankAccount> UpdateBankAccountDataById(int Id)
        //{
        //    return await Database.SqlQuery<BankAccount>("UpdateBankAccountDataById @Id", new SqlParameter("Id", Id)).FirstOrDefaultAsync();
        //}


        /// <summary>
        /// ApiDbContext - Delete bank account
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>

        public async Task<BankAccount> DeleteBankAccountDataById(int Id)
        {
            return await Database.SqlQuery<BankAccount>("DeleteBankAccountDataById @Id", new SqlParameter("Id", Id)).FirstOrDefaultAsync();
        }

        #endregion //BankAccount ends





        #region
        //Budget begins==============================================================
        /// <summary>
        /// ApiDbContext - Get all budgets
        /// </summary>
        /// <returns></returns>
        public async Task<List<Budget>> GetAllBudgets()
        {
            return await Database.SqlQuery<Budget>("GetAllBudgets").ToListAsync();
        }



        /// <summary>
        /// ApiDbContext - Get all budgets by Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<Budget> GetAllBudgetDataById(int Id)
        {
            return await Database.SqlQuery<Budget>("GetAllBudgetDataById @Id", new SqlParameter("Id", Id)).FirstOrDefaultAsync();
        }


        /// <summary>
        /// ApiDbContext - Get budget and budget item data
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>

        public async Task<Budget> GetBudgetAndBudgetItemDataById(int Id)
        {
            return await Database.SqlQuery<Budget>("GetBudgetAndBudgetItemDataById @Id", new SqlParameter("Id", Id)).FirstOrDefaultAsync();
        }



        /// <summary>
        /// ApiDbContext - Update budget data
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<Budget> UpdateBudgetDataById(int Id)
        {
            return await Database.SqlQuery<Budget>("UpdateBudgetDataById @Id", new SqlParameter("Id", Id)).FirstOrDefaultAsync();
        }



        /// <summary>
        /// ApiDbContext - Delete budget data
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<Budget> DeleteBudgetDataById(int Id)
        {
            return await Database.SqlQuery<Budget>("DeleteBudgetDataById @Id", new SqlParameter("Id", Id)).FirstOrDefaultAsync();
        }
        #endregion //Budget ends






        #region
        //Budget Item begins=================================================================


        /// <summary>
        /// ApiDbContext - Budget Items
        /// </summary>
        /// <returns></returns>
        public async Task<List<BudgetItem>> GetAllBudgetItemData()
        {
            return await Database.SqlQuery<BudgetItem>("GetAllBudgetItemData").ToListAsync();
        }



        /// <summary>
        /// ApiDbContext - Budget Items by Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<BudgetItem> GetAllBudgetItemDataById(int Id)
        {
            return await Database.SqlQuery<BudgetItem>("GetAllBudgetItemDataById @Id", new SqlParameter("Id", Id)).FirstOrDefaultAsync();
        }



        /// <summary>
        /// ApiDbContext - Budget Items Update
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<BudgetItem> UpdateBudgetItemDataById(int Id)
        {
            return await Database.SqlQuery<BudgetItem>("UpdateBudgetItemDataById @Id", new SqlParameter("Id", Id)).FirstOrDefaultAsync();
        }



        /// <summary>
        /// ApiDbContext - Budget Items Delete
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<BudgetItem> DeleteBudgetItemDataById(int Id)
        {
            return await Database.SqlQuery<BudgetItem>("DeleteBudgetItemDataById @Id", new SqlParameter("Id", Id)).FirstOrDefaultAsync();
        }

        #endregion //Budget Item ends



        #region 
        //Household========================================================================


        /// <summary>
        /// ApiDbContext - Household create
        /// </summary>
        /// <param name="householdName"></param>
        /// <param name="greeting"></param>
        /// <returns></returns>
        public async Task<int> CreateHousehold(string householdName, string greeting)
        {
            return await Database.ExecuteSqlCommandAsync("CreateHousehold @HouseholdName, @Greeting",
                new SqlParameter("HouseholdName", householdName),
                new SqlParameter("Greeting", greeting));

        }



        /// <summary>
        /// ApiDbContext - Get all households
        /// </summary>
        /// <returns></returns>
        public async Task<List<Household>> GetAllHouseholds()
        {
            //<Household> is the type of list returned.  'GetAllHouseholdData' is name of stored proc
            return await Database.SqlQuery<Household>("GetAllHouseholds").ToListAsync();
        }




        /// <summary>
        /// ApiDbContext - Household by Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<Household> GetAllHouseholdDataById(int Id)
        {
            return await Database.SqlQuery<Household>("GetAllHouseholdDataById @Id", new SqlParameter("Id", Id)).FirstOrDefaultAsync();
        }

        /// <summary>
        /// ApiDbContext - Household and related data
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<Household> GetAllHouseholdAndRelatedDataById(int Id)
        {
            return await Database.SqlQuery<Household>("GetAllHouseholdAndRelatedDataById @Id", new SqlParameter("Id", Id)).FirstOrDefaultAsync();
        }

        /// <summary>
        /// ApiDbContext - Household data
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<Household> GetAllDataForHouseholdById(int Id)
        {
            return await Database.SqlQuery<Household>("GetAllDataForHouseholdById @Id", new SqlParameter("Id", Id)).FirstOrDefaultAsync();
        }


        /// <summary>
        /// ApiDbContext - Household Update
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<Household> UpdateHouseholdDataById(int Id)
        {
                return await Database.SqlQuery<Household>("UpdateHouseholdDataById @Id", new SqlParameter("Id", Id)).FirstOrDefaultAsync();
        }

        /// <summary>
        /// ApiDbContext - Household Delete
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<int> DeleteHouseholdDataById(int Id)
        {
            return await Database.ExecuteSqlCommandAsync("DeleteHouseholdDataById @Id", new SqlParameter("Id", Id));
        }

        #endregion //Household ends



        #region
        //Transaction begins=======================================================================

        /// <summary>
        /// ApiDbContext - Transactions
        /// </summary>
        /// <returns></returns>
        public async Task<List<Transaction>> GetAllTransactions()
        {
            return await Database.SqlQuery<Transaction>("GetAllTransactions").ToListAsync();
        }
        /// <summary>
        /// ApiDbContext - Transactions by Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<Transaction> GetAllTransactionDataById(int Id)
        {
            return await Database.SqlQuery<Transaction>("GetAllTransactionDataById @Id", new SqlParameter("Id", Id)).FirstOrDefaultAsync();
        }



        /// <summary>
        /// ApiDbContext - Transaction Updates
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<Transaction> UpdateTransactionDataById(int Id)
        {
            return await Database.SqlQuery<Transaction>("UpdateTransactionDataById @Id", new SqlParameter("Id", Id)).FirstOrDefaultAsync();
        }



        /// <summary>
        /// ApiDbContext - Transaction Deletes
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<Transaction> DeleteTransactionDataById(int Id)
        {
            return await Database.SqlQuery<Transaction>("DeleteTransactionDataById @Id", new SqlParameter("Id", Id)).FirstOrDefaultAsync();
        }

        #endregion// Transaction ends


    }
}