using BussinessObject2;
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
        public List<Food> GetFoods() => FoodDAO.GetFood();

        public Food GetFoodByFid(int id) => FoodDAO.GetFoodById(id);
    }
}
