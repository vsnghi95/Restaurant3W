using BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public  interface IFoodRepository
    {

        void SaveFood(Food p);
        void DeleteFood(Food p);
        void UpdateFood(Food p);
        List<FoodCategory> GetCategories();
        List<Food> GetFoods();
        Food GetFoodById(int id);

        Food GetFoodByIndex(int index);
    }
}
