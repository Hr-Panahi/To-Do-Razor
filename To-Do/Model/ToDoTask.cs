using System.ComponentModel.DataAnnotations;

namespace To_Do.Model
{
    public class ToDoTask
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool Status { get; set; }

    }
}
