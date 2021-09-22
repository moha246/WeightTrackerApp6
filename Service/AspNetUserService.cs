using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using WeightTrackerApp6.IService;
using WeightTrackerApp6.Models;

namespace WeightTrackerApp6.Service
{
    public class AspNetUserService : IAspNetUserService
    {
        readonly WeightTrackerContext _entity = new WeightTrackerContext();
        
        public string AddAspNetUser(AspNetUsers aspNetUsers)
        {
            _entity.AspNetUsers.Add(aspNetUsers);
            _entity.SaveChanges();

            return aspNetUsers.Id;
        }

        public void Delete(string id)
        {
            _entity.Remove(_entity.AspNetUsers.FirstOrDefault(e => e.Id == id));
            _entity.SaveChanges();
        }

        public AspNetUsers GetAspNetUser(string id)
        {
            return _entity.AspNetUsers.FirstOrDefault(e => e.Id == id);
        }

        public IQueryable<AspNetUsers> GetAspNetUsers()
        {
            return _entity.AspNetUsers.AsQueryable();
        }

        public void Update(AspNetUsers aspNetUser)
        {
            var old = _entity.AspNetUsers.FirstOrDefault(e => e.Id == aspNetUser.Id);
            _entity.Entry(old).CurrentValues.SetValues(aspNetUser);
            _entity.SaveChanges();
        }
    }
}
