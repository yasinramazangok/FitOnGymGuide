using System.ComponentModel.DataAnnotations;


namespace EntityLayer.Concretes
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }

        [StringLength(150)]
        public string Title { get; set; }

        [StringLength(200)]
        public string? ImageUrl { get; set; }

        public DateTime Date { get; set; }

        public string Content { get; set; }

        public int CategoryID { get; set; }

        public virtual Category? Category { get; set; }

        public int AuthorID { get; set; }

        public virtual Author? Author { get; set; }

        public ICollection<Comment>? Comments { get; set; }
    }
}
