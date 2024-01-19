using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorShop.Data;
using RazorShop.Models;

namespace RazorShop.Pages.Items
{
    public class DeleteModel : PageModel
    {
        public Item Item { get; set; }

        private readonly ApplicationDbContext _db;

        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int id)
        {
            Item = _db.Items.Find(id);
        }

        public IActionResult OnPost(Item item)
        {
            _db.Items.Remove(item);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
