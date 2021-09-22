  using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WeightTrackerApp6.Models
{
    public class Users
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int Postal_code { get; set; }
        public string About_me { get; set; }
        public string aspNetUsersId { get; set; }


        public virtual ICollection<WeightDetails> weight_details { get; set; }
        public virtual ICollection<CalorieCounter> calorie_counter { get; set; }
        public virtual ICollection<BMI> bmi { get; set; }
        
        //FK from the aspnetusers table
        public virtual AspNetUsers aspNetUsers { get; set; }
    }
}
