using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bugfixapp
{
    public interface IUserRepository
    {
        Task<List<DbUser>> GetUsers();
        Task<List<DbValue>> GetValues();
        Task<DbUser> GetUser(Guid userId);
        Task UpdateUserValues(Guid userId, List<Guid> values);
    }
}