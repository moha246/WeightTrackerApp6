using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeightTrackerApp6.Models;

namespace WeightTrackerApp6.IService
{
    public interface IFoodTipsService
    {
        FoodTips GetAFoodTip(int Id);
        IQueryable<FoodTips> GetAllFoodTips();
        //FoodTips GetDetailByUserId(string user_id);
    }
}
