using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorShop.Data;
using RazorShop.Models;

namespace RazorShop.Pages.Items
{
    // Not using [BindProperty]
    // Not using ViewData to pass data

    public class DeleteModel : PageModel
    {
        public Item Item { get; set; }
        public List<Category> CategoryList { get; set; }
        private readonly ApplicationDbContext _db;

        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int id)
        {
            Item = _db.Items.Find(id);
            CategoryList = _db.Categories.ToList();
        }

        public IActionResult OnPost(Item item)
        {
            if (item.Id == null)
            {
                return NotFound();
            }

            _db.Items.Remove(item);
            _db.SaveChanges();

            return RedirectToPage("Index");
        }
    }
}
