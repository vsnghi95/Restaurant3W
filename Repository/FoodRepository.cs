using BussinessObject;
using DataAcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class FoodRepository : IFoodRepository
    {
        public void DeleteFood(Food p) => FoodDAO.DeleteFood(p);


        public List<FoodCategory> GetCategories() => FoodCategoryDAO.GetCategories();



        public Food GetFoodById(int id) => FoodDAO.GetFoodById(id);

        public Food GetFoodByIndex(int index) => FoodDAO.GetFoodByIndex(index);
       
        public List<Food> GetFoods() => FoodDAO.GetFood();

       

      
        public void SaveFood(Food p) => FoodDAO.SaveFood
            (p);


        public void UpdateFood(Food p) => FoodDAO.UpdateFood(p);
        
    }
}
