using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace DAL.Models
{
    public class User : IdentityUser
    {
       
        
    }

    public class RolesCollectionModel
    {
        public IEnumerable<IdentityRole> AwailableRoles { get; set; }
        public IEnumerable<IdentityRole> SelectedRoles { get; set; }
    }
   
}
