using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using To_Do.Data;
using To_Do.Model;

namespace To_Do.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        //private readonly ILogger<IndexModel> _logger;

        //public IndexModel(ILogger<IndexModel> logger)
        //{
        //    _logger = logger;
        //}
        private readonly ApplicationDbContext _db;
        public IEnumerable<ToDoTask> ToDoTasks { get; set; }
        public ToDoTask NewToDoTask { get; set; }

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
            NewToDoTask = new ToDoTask(); // Initialize NewToDoTask
        }
        public void OnGet(int id)
        {
            ToDoTasks = _db.ToDoTask;
        }

        public async Task<IActionResult> OnPost(ToDoTask newToDoTask)
        {
            if (ModelState.IsValid)
            {
                await _db.ToDoTask.AddAsync(newToDoTask);
                await _db.SaveChangesAsync();
                return RedirectToPage(pageName: "Index"); 
            }
            ToDoTasks = _db.ToDoTask;
            return Page();
        }

        public async Task<IActionResult> OnPostEdit(int id)
        {
            var taskToUpdate = await _db.ToDoTask.FindAsync(id);
            if (taskToUpdate == null)
            {
                return NotFound();
            }

            NewToDoTask = taskToUpdate; // Pre-fill form with task details for editing
            return Page();
        }



        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var taskToDelete = await _db.ToDoTask.FindAsync(id);
            if (taskToDelete == null)
            {
                return NotFound();
            }

            _db.ToDoTask.Remove(taskToDelete);
            await _db.SaveChangesAsync();
            return RedirectToPage();
        }

    }
}
