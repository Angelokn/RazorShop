using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorShop.Data;
using RazorShop.Models;

namespace RazorShop.Pages.Categories
{
    public class DeleteModel : PageModel
    {
        public Category Category { get; set; }

        private readonly ApplicationDbContext _db;
        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost(int id)
        {
            var categoryId = _db.Categories.FirstOrDefault(u => u.Id == id);

            if (ModelState.IsValid)
            {
                _db.Categories.Remove(categoryId);
                _db.SaveChanges();

                return RedirectToPage("Index");
            }

            return Page();
        }
    }
}
