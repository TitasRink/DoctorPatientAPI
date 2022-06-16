﻿using System.ComponentModel.DataAnnotations;

namespace FrameworkData.Model
{
    public class DepartmentModel 
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
     
    }
}
