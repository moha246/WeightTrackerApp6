using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeightTrackerApp6.Models
{
    public class FoodCategory
    {
        public int Id { get; set; }
        public string FoodName { get; set; }

        //public List<FoodType> foodTypes { get; set; }

    }

    public class FoodType
    {
        public int Id { get; set; }
        public string FoodTypeName { get; set; }
        public string FoodTypeMeasurement { get; set; }
        public string CalorieSize { get; set; }
        public int FoodCategorieId { get; set; }
    }
}
