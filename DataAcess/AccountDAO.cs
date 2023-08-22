using BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess
{
    public class AccountDAO
    {
        public static List<Account> GetAccounts()
        {
            List<Account> listAcc = new List<Account>();
            try
            {
                using (var context = new restaurant2Context())
                {
                    listAcc = context.Accounts.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listAcc;
        }

        public static Account GetAccountByName(string name)
        {
            Account account = new Account();
            try
            {
                using (var context = new restaurant2Context())
                {
                    account = GetAccounts().FirstOrDefault(x => x.Username == name);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return account;
        }
    }
}
