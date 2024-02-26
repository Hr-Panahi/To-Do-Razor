using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace To_Do.Model
{
    public class ToDoTask
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Description { get; set; }
        public DateTime DueDate { get; set; } = DateTime.Now;
        public TimeSpan DueTime { get; set; }
        public bool Status { get; set; }

    }
}
