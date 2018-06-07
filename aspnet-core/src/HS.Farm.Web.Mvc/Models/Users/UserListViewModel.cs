using System.Collections.Generic;
using HS.Farm.Roles.Dto;
using HS.Farm.Users.Dto;

namespace HS.Farm.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
