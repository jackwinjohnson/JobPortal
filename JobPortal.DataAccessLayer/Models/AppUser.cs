
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.DataAccess.Models
{
    public class AppUser: IdentityUser
    {
        //in   .net    core    identyuser  is   used    to  manage   authentication   and  authorization    in  our   application
        //identyuser  is  a  built-in   class   provided   by  .netcore that  reperesents   a  user account in  already contains    username,password,email   and  other  properties
        public string FirstName { get; set; }
        public  string LastName { get; set; }
        public  string ProfiilePicture { get; set; }

        public  string  Role { get; set; }


    }


}
