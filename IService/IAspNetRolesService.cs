using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using WeightTrackerApp6.Models;

namespace WeightTrackerApp6.IService
{
    public interface IAspNetRolesService
    {
        string AddAspNetRole(AspNetRoles aspNetRoles);
        AspNetRoles GetAspNetRole(string id);
        IQueryable<AspNetRoles> GetAspNetRoles();
        void Update(AspNetRoles aspNetRoles);
        void Delete(string id);
    }
}
