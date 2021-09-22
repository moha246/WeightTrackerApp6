using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using WeightTrackerApp6.IService;
using WeightTrackerApp6.Models;

namespace WeightTrackerApp6.Service
{
    public class AspNetUserRolesService : IAspNetUserRolesService
    {
        readonly WeightTrackerContext _entity = new WeightTrackerContext();

        public string AddAspNetUserRoles(Models.AspNetUserRoles aspNetUserRoles)
        {
            _entity.AspNetUserRoles.Add(aspNetUserRoles);
            _entity.SaveChanges();

            return aspNetUserRoles.UserId;
        }

        public IQueryable<AspNetRoles> GetAspNetRoles(string Id)
        {
            return _entity.AspNetRoles.Where(e => e.Id == Id);
        }

        public IQueryable<AspNetUserRoles> GetAspNetUserRoles()
        {
            return _entity.AspNetUserRoles.AsQueryable();
        }

        public IQueryable<AspNetUsers> GetAspNetUsers(string Id)
        {
            return _entity.AspNetUsers.Where(e => e.Id == Id);
        }
    }
}
