namespace ExamPrep.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class Article
    {
        public Article()
        {
            this.Likes = new HashSet<Like>();
        }

        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public virtual ApplicationUser Author { get; set; }

        public DateTime DateCreated { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<Like> Likes { get; set; }
    }
}
