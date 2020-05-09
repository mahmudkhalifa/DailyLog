using System.Threading.Tasks;
using DailyLog.Core;
using Data.DailyLog.DatabaseSpecific;
using Data.DailyLog.EntityClasses;
using Data.DailyLog.FactoryClasses;
using Data.DailyLog.HelperClasses;
using Microsoft.AspNetCore.Identity;
using SD.LLBLGen.Pro.QuerySpec;
using SD.LLBLGen.Pro.QuerySpec.Adapter;

namespace DailyLog.Services
{
    public class UserService:IUserService
    {
        public async Task<EntityCollection<UserEntity>> GetUsers()
        {
            var users = new EntityCollection<UserEntity>();
            using var adapter = new DataAccessAdapter();
            var qf = new QueryFactory();
            var q = qf.User;

            return await adapter.FetchQueryAsync(q, users);
        }
        public async Task AddUser(User user)
        {
            var hasher = new PasswordHasher<string>();
            var hashedPassword = hasher.HashPassword(null, user.Password);
            user.Password = hashedPassword;

            using var adapter = new DataAccessAdapter();
            await adapter.SaveEntityAsync(user.ToEntity(), true);
        }
        public async Task<UserEntity> GetUserByEmail(string email)
        {
            using var adapter = new DataAccessAdapter();
            var qf = new QueryFactory();
            var q = qf.User.Where(UserFields.Email == email);

             return await adapter.FetchSingleAsync(q);
        }
    }
}

