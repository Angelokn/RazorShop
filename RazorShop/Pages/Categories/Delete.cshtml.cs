using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorShop.Data;
using RazorShop.Models;

namespace RazorShop.Pages.Categories
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        public Category Category { get; set; }

        private readonly ApplicationDbContext _db;
        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet(int id)
        {
            if (id != null && id != 0)
            {
                Category = _db.Categories.Find(id);
            }
        }

        public IActionResult OnPost(int id)
        {
            Category categoryId = _db.Categories.FirstOrDefault(u => u.Id == id);

            if(categoryId == null)
            {
                return NotFound();
            }

            _db.Categories.Remove(categoryId);
            _db.SaveChanges();

            return RedirectToPage("Index");
        }
    }
}
