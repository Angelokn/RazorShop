using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorShop.Data;
using RazorShop.Models;

namespace RazorShop.Pages.Categories
{
    public class UpdateModel : PageModel
    {
        [BindProperty]
        public Category Category { get; set; }

        private readonly ApplicationDbContext _db;

        public UpdateModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
        }

        public IActionResult OnUpdate(int id)
        {
            var category = _db.Categories.FirstOrDefault(u => u.Id == id);

            if (category == null || id == 0)
            {
                return NotFound();
            }

            _db.Update(category);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
