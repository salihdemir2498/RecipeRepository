using Microsoft.AspNetCore.Identity;
using SalihRecipes.webui.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalihRecipes.webui.Models
{
    public class RoleModel
    {
        [Required]
        public string Name { get; set; }
    }
    public class RoleDetails
    {
        public IdentityRole Role { get; set; } // tek bir rolün bilgisi
        public IEnumerable<User> Members { get; set; } //ilgili kullanıcılar gelecek
        public IEnumerable<User> NonMembers { get; set; } //o role ait olmayan kullanıcılar
    }

    public class RoleEditModel
    {
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public string[] IdsToAdd { get; set; }
        public string[] IdsToDelete { get; set; }
    }
}
