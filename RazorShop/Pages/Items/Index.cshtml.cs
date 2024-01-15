using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorShop.Data;
using RazorShop.Models;

namespace RazorShop.Pages.Items
{
    public class IndexModel : PageModel
    {
        public List<Item> ItemList { get; set; }
        public List<Category> CategoryList { get; set; }

        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
            ItemList = _db.Items.ToList();
            CategoryList = _db.Categories.ToList();
        }
    }
}
