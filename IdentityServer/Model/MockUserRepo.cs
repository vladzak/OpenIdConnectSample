using IdentityServer.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IdentityServer.Model
{
    public class MockUserRepo : IUserRepository
    {

        public Task<UserEntity> FindAsync(string email)
        {
            return Task.FromResult(users.FirstOrDefault(x=>x.Email == email));
        }

        public Task<UserEntity> FindAsync(long id)
        {
            return Task.FromResult(users.FirstOrDefault(x => x.Id == id));
        }

        public UserEntity FindByExternalProvider(string provider, string userId)
        {
            throw new NotImplementedException();
        }

        public UserEntity AutoProvisionUser(string provider, string userId, List<Claim> claims)
        {
            throw new NotImplementedException();
        }

        private static List<UserEntity> users = new List<UserEntity> {
            new UserEntity {
                Id = 1,
                Email = "vladzak@gmail.com",
                Firstname = "Vlad",
                Lastname = "Zak",
                Password = "123qweASD",
                Role = "admin"
            },
            new UserEntity {
                Id = 2,
                Email = "vz@admixer.net",
                Firstname = "Vlad",
                Lastname = "Zak",
                Password = "123qweASD",
                Role = "manager"
            }
        };
    }
}
