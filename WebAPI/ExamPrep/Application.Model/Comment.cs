using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public virtual Article Article { get; set; }

        public DateTime DateCreated { get; set; }

        public virtual User Author { get; set; }
    }
}
