using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;
using Com.Framework.Data;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Com.Framework.Models
{
    public class AspNetUser : IdentityUser, IBaseEntity
    {
        [StringLength(128)]
        [Required()]
        public virtual string Discriminator { get; set; }

        [StringLength(500)]
        public virtual string LastName { get; set; }

        [StringLength(500)]
        public virtual string FirstName { get; set; }

        public virtual IList<AspNetUserLogin> AspNetLogins { get; set; }

        public virtual IList<AspNetUserClaim> AspNetClaims { get; set; }

        public virtual IList<AspNetUserRole> AspNetRoles { get; set; }

        public EntityState EntityState { get; set; }
    }
}
