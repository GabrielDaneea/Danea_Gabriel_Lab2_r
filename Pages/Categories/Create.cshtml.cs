using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Danea_Gabriel_Lab2_r.Data;
using Danea_Gabriel_Lab2_r.Models;

namespace Danea_Gabriel_Lab2_r.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly Danea_Gabriel_Lab2_r.Data.Danea_Gabriel_Lab2_rContext _context;

        public CreateModel(Danea_Gabriel_Lab2_r.Data.Danea_Gabriel_Lab2_rContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Category Category { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Category.Add(Category);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
