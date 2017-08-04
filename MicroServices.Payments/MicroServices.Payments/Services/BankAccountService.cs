﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using MicroServices.Payments.Models;

namespace MicroServices.Payments.Services
{
    public class BankAccountService
    {
        public static async Task<List<BankAccount>> GetBankAccountsForAccount(int accountId)
        {
            return await Task.Run(() => GetBankAccount(accountId)).ConfigureAwait(false);
        }

        private static List<BankAccount> GetBankAccount(int accountId)
        {
            return new List<BankAccount>()
            {
                new BankAccount()
                {
                    AccountNumber = "This is not really an account number",
                    Id = 1,
                    RoutingNumber = "123"
                }
            };
        }
    }
}