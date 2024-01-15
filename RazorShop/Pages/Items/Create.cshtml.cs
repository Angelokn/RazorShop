using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorShop.Data;
using RazorShop.Models;

namespace RazorShop.Pages.Items
{
    public class CreateModel : PageModel
    {
        public Item Item { get; set; }

        private readonly ApplicationDbContext _db;

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            _db.Items.Add(Item);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
