using BussinessObject2;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess
{
    public class OrderDetailDAO
    {
        public static List<OrderDetail> GetOrderDetails()
        {
            List<OrderDetail> listOrd = new List<OrderDetail>();
            try
            {
                using (var context = new restaurant2Context())
                {
                    listOrd = context.OrderDetails.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listOrd;
        }

        public static void AddOrderDetial(OrderDetail orderDetail)
        {

            try
            {
                using (var context = new restaurant2Context())
                {
                    context.OrderDetails.Add(orderDetail);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /*public static void AddOrderDetial(OrderDetail orderDetail)
        {
            try
            {
                using (var connection = new SqlConnection(GetConnectionString()))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO OrderDetail (Odid, Fid, Quantity, AmountOfFood) VALUES (@Odid ,@Fid, @Quantity, @AmountOfFood)";
                    using (var command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Odid", orderDetail.Odid);
                        command.Parameters.AddWithValue("@Fid", orderDetail.Fid);
                        command.Parameters.AddWithValue("@Quantity", orderDetail.Quantity);
                        command.Parameters.AddWithValue("@AmountOfFood", orderDetail.AmountOfFood);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }*/
    }
}
