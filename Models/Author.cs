namespace SQLiteDemoApp.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        // navigation properties
        public List<Book>? Books { get; set; }
    }
}