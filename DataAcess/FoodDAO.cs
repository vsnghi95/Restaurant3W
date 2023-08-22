using BussinessObject;
using Microsoft.EntityFrameworkCore;
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
            List<Food> listFoods = new List<Food>();
            try
            {
                using (var context = new restaurant2Context())
                {
                    listFoods = context.Foods.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listFoods;
        }


        public static Food GetFoodById(int id)
        {
            Food food = new Food();
            try
            {
                using (var context = new restaurant2Context())
                {
                    food = context.Foods
                        .SingleOrDefault(m => m.Fid == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return food;
        }

        public static void SaveFood(Food food)
        {
            try
            {
                using (var context = new restaurant2Context())
                {
                    context.Foods.Add(food);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void DeleteFood(Food food)
        {
            try
            {
                using (var context = new restaurant2Context())
                {
                    var p1 = context.Foods.SingleOrDefault(m => m.Fid == food.Fid);
                    context.Foods.Remove(p1);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void UpdateFood(Food food)
        {
            try
            {
                using (var context = new restaurant2Context())
                {
                    context.Entry<Food>(food).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Food GetFoodByIndex(int index)
        {

            Food food = null;
            try
            {
                using(var context = new restaurant2Context())
                {
                    List<Food> listfood = context.Foods.ToList();
                    food = listfood[index];
                }
                return food;
            }

           
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
