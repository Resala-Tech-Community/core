﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace resala.core.Domain.Models
{
    [Table("Branches")]
    public class Branch : BaseModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [MaxLength(11)]
        public string Phone { get; set; }

    }
}
