using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeightTrackerApp6.Models
{
    public partial class BMI
    {
        public Guid id { get; set; }
        public float BMICount { get; set; }
        public Guid UserId { get; set; }
       
       
        
        public virtual Users users { get; set; }


    }
}
