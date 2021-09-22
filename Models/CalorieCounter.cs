using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeightTrackerApp6.Models
{
    public partial class CalorieCounter
    {
      public Guid id { get; set; }
      public string Food_Name { get; set; }
      public string Portion_size { get; set; }
      public string Serving_Type { get; set; }
      public int Calorie_Counts { get; set; }
      public Guid UserId { get; set; }


      public virtual Users users { get; set; }
    }
}
