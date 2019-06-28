using IdentityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IdentityServer.Model.Entities
{
    public static class UserEntityExt
    {
        /// <summary>
        /// build claims array from user data
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static Claim[] GetClaims(this UserEntity user)
        {
            return new Claim[]
            {
            new Claim("user_id", user.Id.ToString() ?? ""),
            new Claim(JwtClaimTypes.Name, user.Email),
            new Claim(JwtClaimTypes.GivenName, user.Firstname  ?? ""),
            new Claim(JwtClaimTypes.FamilyName, user.Lastname  ?? ""),
            new Claim(JwtClaimTypes.Email, user.Email  ?? ""),
            //new Claim("some_claim_you_want_to_see", user.Some_Data_From_User ?? ""),

            //roles
            new Claim(JwtClaimTypes.Role, user.Role)
            };
        }
    }
}
