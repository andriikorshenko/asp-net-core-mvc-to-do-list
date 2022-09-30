namespace ToDoListWeb.Models
{
    public class Assignment
    {
        public uint Id { get; set; }
        public string? Text { get; set; }
        public uint DisplayOrder { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
