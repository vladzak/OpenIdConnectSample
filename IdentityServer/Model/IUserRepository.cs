using IdentityServer.Model.Entities;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IdentityServer.Model
{
    public interface IUserRepository
    {
        Task<UserEntity> FindAsync(string email);

        Task<UserEntity> FindAsync(long id);
        UserEntity FindByExternalProvider(string provider, string userId);
        UserEntity AutoProvisionUser(string provider, string userId, List<Claim> claims);
    }
}