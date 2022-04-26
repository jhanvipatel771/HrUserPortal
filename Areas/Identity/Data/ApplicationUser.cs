using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace HrUserPortal.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string FirstName { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string BloodGroup { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Nationality { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public DateTime Birthday { get; set; }


        //[PersonalData]
        //[Column(TypeName = "nvarchar(100)")]
        //public DateTime Doj { get; set; }


        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string HomeAddress { get; set; }


        [PersonalData]
        public byte[] ProfilePicture { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string personalEmail { get; set; }

       [PersonalData]
       [Column(TypeName = "nvarchar(100)")]
       public string Designation { get; set; }

    }
}
