using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace resala.core.Domain.Models
{
   public enum Gender : byte
    {
        [Description("M")]
        Male = 1,

        [Description("F")]
        Female = 2
    }
}
