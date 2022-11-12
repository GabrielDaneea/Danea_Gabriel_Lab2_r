using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Danea_Gabriel_Lab2_r.Data;
using Danea_Gabriel_Lab2_r.Models;

namespace Danea_Gabriel_Lab2_r.Pages.Categories
{
    public class DetailsModel : PageModel
    {
        private readonly Danea_Gabriel_Lab2_r.Data.Danea_Gabriel_Lab2_rContext _context;

        public DetailsModel(Danea_Gabriel_Lab2_r.Data.Danea_Gabriel_Lab2_rContext context)
        {
            _context = context;
        }

      public Category Category { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Category == null)
            {
                return NotFound();
            }

            var category = await _context.Category.FirstOrDefaultAsync(m => m.ID == id);
            if (category == null)
            {
                return NotFound();
            }
            else 
            {
                Category = category;
            }
            return Page();
        }
    }
}
