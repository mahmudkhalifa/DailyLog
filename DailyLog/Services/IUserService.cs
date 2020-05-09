using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DailyLog.Core;
using Data.DailyLog.EntityClasses;
using Data.DailyLog.HelperClasses;

namespace DailyLog.Services
{
    public interface IUserService
    {
        Task<EntityCollection<UserEntity>> GetUsers();
        Task AddUser(User user);
        Task<UserEntity>GetUserByEmail(string email);
    }
}
