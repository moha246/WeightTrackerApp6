using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeightTrackerApp6.Models;
using WeightTrackerApp6.IService;

namespace WeightTrackerApp6.Service
{
    public class UsersService: IUsersService
    {
        readonly WeightTrackerContext _entity = new WeightTrackerContext();
        public Guid AddUser(Users users)
        {
            _entity.Users.Add(users);
            _entity.SaveChanges();

            return users.Id;
        }

        public void Delete(Guid id)
        {
            _entity.Users.Remove(_entity.Users.FirstOrDefault(e => e.Id == id));
            _entity.SaveChanges();
        }

        public IQueryable<Users> GetAllUsers()
        {
            return _entity.Users.AsQueryable();
        }

        public Users GetAUser(Guid Id)
        {
            return _entity.Users.FirstOrDefault(e => e.Id == Id);
        }
        public Users GetDetailByUserId(string user_id)
        {
            return _entity.Users.FirstOrDefault(e => e.aspNetUsersId == user_id);
        }

        public void Update(Users users)
        {
            var old = _entity.Users.FirstOrDefault(e => e.Id == users.Id);
            _entity.Entry(old).CurrentValues.SetValues(users);
            _entity.SaveChanges();
        }
    }
}
 