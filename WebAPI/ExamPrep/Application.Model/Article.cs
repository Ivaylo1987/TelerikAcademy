namespace Application.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Article
    {
        public Article()
        {
            this.Categories = new HashSet<Category>();
            this.Tags = new HashSet<Tag>();
            this.Comments = new HashSet<Comment>();
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime DateCreate { get; set; }

        public User Author { get; set; }

        public string Content { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
