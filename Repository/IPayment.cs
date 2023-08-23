using BussinessObject2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IPayment
    {
        public List<DepositCate> GetDepositCates();
    }
}
