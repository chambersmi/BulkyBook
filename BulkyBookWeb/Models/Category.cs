﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models {
    public class Category {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = "";
        [DisplayName("Display Order")]
        [Range(1,99,ErrorMessage="Must be between 1 and 3")]
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;


    }
}
