using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InfoDisplayWeb.Models
{
    public class ApplicationUser : IdentityUser
    {
        [MaxLength(50)]
        public string DisplayName { get; set; }
        public Boolean IsDisplayUser { get; set; }

    }
}
