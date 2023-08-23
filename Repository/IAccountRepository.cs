using BussinessObject2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IAccountRepository
    {
        List<Account> GetAccounts();

        Account GetAccountByName(string name);
    }
}
