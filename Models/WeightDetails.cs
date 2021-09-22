 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeightTrackerApp6.Models
{
    public partial class WeightDetails
    {
        public Guid Id { get; set; }
        public float Waist_size { get; set; }
        public int? Height { get; set; }
        public float Chest_size { get; set; }
        public DateTime Date { get; set; }
        public Guid UserId { get; set; }
        public int? Weights { get; set; }


        public virtual Users users { get; set; }
    }
}
