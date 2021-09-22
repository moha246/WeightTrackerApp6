using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeightTrackerApp6.Models
{
    public partial class AspNetRoles
    {
        
        public string Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AspNetUserRoles> aspNetUserRoles { get; set; }
       
    }
}
