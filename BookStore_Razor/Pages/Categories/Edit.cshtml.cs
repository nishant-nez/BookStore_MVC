using BookStore_Razor.Data;
using BookStore_Razor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace BookStore_Razor.Pages.Categories
{
    [BindProperties] // bind all properties automatically
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        // [BindProperty] // bind the form data to the Category object on post
        public Category Category { get; set; }
        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int? id)
        {
            if (id != null | id != 0)
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
                TempData["success"] = "Category updated successfully";
                Console.WriteLine(TempData["success"]);
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
