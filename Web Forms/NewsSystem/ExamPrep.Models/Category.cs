namespace ExamPrep.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class Category
    {
        public Category()
        {
            this.Articles = new HashSet<Article>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
    }
}
