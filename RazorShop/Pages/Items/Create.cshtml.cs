using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            List<Item> objItemList = _db.Items.ToList();

            IEnumerable<SelectListItem> CategoryList = _db.Categories.Select(u => new SelectListItem
            {
                Text = u.Name,
                Value = u.Id.ToString()
            });

            ViewData["CategoryList"] = CategoryList;
        }


        public IActionResult OnPost(Item item)
        {
            _db.Items.Add(item);
            _db.SaveChanges();

            return RedirectToPage("Index");
        }
    }
}
