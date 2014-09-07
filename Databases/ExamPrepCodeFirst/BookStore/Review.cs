namespace BookStore.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Review
    {
        public int Id { get; set; }

        [Required]
        public DateTime DateOfCreatiom { get; set; }

        public string Content { get; set; }
        
        public virtual Author Author { get; set; }

        public virtual Book Book { get; set; }
    }
}
