using BussinessObject2;
using DataAcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class AccountRepository : IAccountRepository
    {
        public List<Account> GetAccounts() => AccountDAO.GetAccounts();

        public Account GetAccountByName(string name) => AccountDAO.GetAccountByName(name);

    }
}
