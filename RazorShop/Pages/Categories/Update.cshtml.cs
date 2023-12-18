using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorShop.Data;
using RazorShop.Models;

namespace RazorShop.Pages.Categories
{
    [BindProperties]
    public class UpdateModel : PageModel
    {
        public Category Category { get; set; }

        private readonly ApplicationDbContext _db;

        public UpdateModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int id)
        {
            if(id!=null && id != 0)
            {
                Category = _db.Categories.Find(id);
            }
        }

        public IActionResult OnPost()
        {

            if (ModelState.IsValid)
            {
                _db.Categories.Update(Category);
                _db.SaveChanges();

                return RedirectToPage("Index");

            }
            
            return Page();
        }
    }
}
