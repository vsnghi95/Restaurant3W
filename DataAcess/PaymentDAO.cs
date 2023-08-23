using BussinessObject2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess
{
    public class PaymentDAO
    {
        public static List<DepositCate> GetDepositCates()
        {
            List<DepositCate> listPay = new List<DepositCate>();
            try
            {
                using (var context = new restaurant2Context())
                {
                    listPay = context.DepositCates.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listPay;
        }

        
    }
}
