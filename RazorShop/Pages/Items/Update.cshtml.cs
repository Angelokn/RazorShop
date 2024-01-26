using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorShop.Data;
using RazorShop.Models;

namespace RazorShop.Pages.Items
{
    public class UpdateModel : PageModel
    {
        public Item Item { get; set; }
        private readonly ApplicationDbContext _db;
        public UpdateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet(int id)
        {
            if(id!=null && id!=0)
            {
                Item = _db.Items.Find(id);
            }

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
            if(ModelState.IsValid)
            {
                _db.Items.Update(item);
                _db.SaveChanges();
                TempData["success"] = "Item updated successfully";
            }

            return RedirectToPage("Index");
        }
    }
}
