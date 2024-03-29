﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace resala.core.Domain.Models
{
    [Table("Committees")]
    public class Committee : BaseModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ushort MaleCapacity { get; set; }
        public ushort FemaleCapacity { get; set; }
        public ushort UniSexCapacity { get; set; }

        public CommitteeType CommitteeType { get; set; }
    }
}
