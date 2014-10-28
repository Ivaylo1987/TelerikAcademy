﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ExamPrep.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        public string ISBN { get; set; }

        public string WebSite { get; set; }

        public string Description { get; set; }

        public virtual Category Category { get; set; }
    }
}
