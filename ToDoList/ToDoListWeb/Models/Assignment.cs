using ToDoListWeb;

namespace ToDoListWeb.Models
{
    public class Assignment
    {
        public int Id { get; set; }

        public string Name { get; set; } = "Unnamed";

        public string Text { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
