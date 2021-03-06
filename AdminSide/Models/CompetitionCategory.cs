﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdminSide.Models
{
    public class CompetitionCategory
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }

        public int CompetitionID { get; set; }

        public ICollection<Challenge> Challenges { get; set; }
    }
}
