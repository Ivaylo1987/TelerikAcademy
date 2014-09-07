namespace BookStore.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class Author
    {
        private ICollection<Review> reviews;
        private ICollection<Book> books;

        public Author()
        {
            this.reviews = new HashSet<Review>();
            this.books = new HashSet<Book>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(60)]
        public string Name { get; set; }

        public virtual ICollection<Book> Books
        {
            get { return books; }
            set { books = value; }
        }

        public virtual ICollection<Review> Reviews
        {
            get { return reviews; }
            set { reviews = value; }
        }
    }
}
