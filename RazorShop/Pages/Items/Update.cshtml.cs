using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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
        }

        public IActionResult OnPost()
        {
            if(ModelState.IsValid)
            {
                _db.Items.Update(Item);
                _db.SaveChanges();
            }

            return RedirectToPage("Index");
        }
    }
}
