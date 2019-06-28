using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IdentityServer.Model.Entities
{
    public class UserEntity
    {
        public int Id { get; internal set; }
        public string Firstname { get; internal set; }
        public string Lastname { get; internal set; }
        public string Email { get; internal set; }
        public string Role { get; internal set; }
        public string Password { get; internal set; }
        public bool IsActive { get; internal set; }

        public string FullName
        {
            get
            {
                return (!string.IsNullOrEmpty(Firstname) && !string.IsNullOrEmpty(Lastname)) ? (Firstname + " " + Lastname) : "";
            }
        }

        public string SubjectId { get { return Id.ToString(); } }
    }
}
