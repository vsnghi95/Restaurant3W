using BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess
{
    public class FoodCategoryDAO
    {

        public static List<FoodCategory> GetCategories()
        {
            List<FoodCategory> listCategories = new List<FoodCategory>();
            try
            {
                using (var context = new restaurant2Context())
                {
                    listCategories = context.FoodCategories.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listCategories;

        }
    }
}
