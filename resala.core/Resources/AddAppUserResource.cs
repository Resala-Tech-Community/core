using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace resala.core.Resources
{
    public class AddAppUserResource
    {
        [DataType(DataType.EmailAddress , ErrorMessage = "Invalid Email")]
        public string Email { get; set; }

        [DataType(DataType.Password , ErrorMessage = "Invalid Password")]
        public string Password { get; set; }
    }
}
