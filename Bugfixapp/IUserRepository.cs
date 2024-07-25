using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bugfixapp
{
    public interface IUserRepository
    {
        Task<DbUser> GetUser(Guid userId);
        Task<List<DbUser>> GetUsers();
        Task<List<DbValue>> GetValues();
        Task UpdateUserValues(Guid userId, List<Guid> values);
    }
}
