using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using WeightTrackerApp6.Models;

namespace WeightTrackerApp6.IService
{
    public interface IAspNetUserService
    {
        string AddAspNetUser(AspNetUsers aspNetUsers);
        AspNetUsers GetAspNetUser(string id);
        IQueryable<AspNetUsers> GetAspNetUsers();
        void Update(AspNetUsers aspNetUsers);
        void Delete(string id);
    }
}
