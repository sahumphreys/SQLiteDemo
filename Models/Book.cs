namespace SQLiteDemoApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int AuthorId { get; set; }

        // navigation properties
        public Author? Author { get; set; }
    }
}