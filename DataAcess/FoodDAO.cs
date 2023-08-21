using BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess
{
    public  class FoodDAO
    {

        public static List<Food> GetFood()
        {
            List<Food> listFood = new List<Food>();
            try
            {
                using (var context = new restaurant2Context())
                {
                    listFood = context.Foods.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listFood;
        }


        public static Food GetFoodById(int id)
        {
            Food food = new Food();
            try
            {
                using (var context = new restaurant2Context())
                {
                  food= context.Foods
                        .SingleOrDefault(m => m.Fid == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return food;
        }

    }
}
