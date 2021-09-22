using System;
using System.Linq;
using WeightTrackerApp6.Models;

namespace WeightTrackerApp6.IService
{
    public interface IUsersService
    {
       Guid AddUser(Users users);
        Users GetAUser(Guid Id);
        IQueryable<Users> GetAllUsers();
        void Update(Users users);
        void Delete(Guid Id);
        Users GetDetailByUserId(string user_id); 
    }
}
