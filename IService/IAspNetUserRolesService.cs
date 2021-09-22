using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using WeightTrackerApp6.Models;

namespace WeightTrackerApp6.IService
{
    public interface IAspNetUserRolesService
    {
        string AddAspNetUserRoles(AspNetUserRoles aspNetUserRoles);
        IQueryable<AspNetUserRoles> GetAspNetUserRoles();
        IQueryable<AspNetUsers> GetAspNetUsers(string Id);
        IQueryable<AspNetRoles> GetAspNetRoles(string Id);


    }
}
