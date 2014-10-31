namespace ExamPrep.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Like
    {
        public int Id { get; set; }

        public int Value { get; set; }

        public virtual Article Article { get; set; }
    }
}
