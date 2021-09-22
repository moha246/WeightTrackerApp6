using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace WeightTrackerApp6.Models
{
    public partial class AspNetUserRoles
    {
        [Key]
        public string UserId { get; set; }
        [Key]
        public string RoleId { get; set; }

        public virtual AspNetRoles aspNetRoles { get; set; }
        public virtual AspNetUsers aspNetUsers { get; set; }
    
    }
}
