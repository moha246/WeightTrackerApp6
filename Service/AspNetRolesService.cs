using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using WeightTrackerApp6.IService;
using WeightTrackerApp6.Models;

namespace WeightTrackerApp6.Service
{
    public class AspNetRolesService : IAspNetRolesService
    {

        readonly WeightTrackerContext _entity = new WeightTrackerContext();

        public string AddAspNetRole(AspNetRoles aspNetRoles)
        {
            _entity.AspNetRoles.Add(aspNetRoles);
            _entity.SaveChanges();

            return aspNetRoles.Id;
        }

        public void Delete(string id)
        {
            _entity.Remove(_entity.AspNetRoles.FirstOrDefault(e => e.Id == id));

        }

        public AspNetRoles GetAspNetRole(string id)
        {
           return _entity.AspNetRoles.FirstOrDefault(e => e.Id == id);
        }

        public IQueryable<AspNetRoles> GetAspNetRoles()
        {
           return _entity.AspNetRoles.AsQueryable();
        }

        public void Update(AspNetRoles aspNetRoles)
        {
            var old = _entity.AspNetRoles.FirstOrDefault(e => e.Id == aspNetRoles.Id);
            _entity.Entry(old).CurrentValues.SetValues(aspNetRoles);
            _entity.SaveChanges();
        }
    }
}
