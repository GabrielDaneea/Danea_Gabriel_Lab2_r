using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Danea_Gabriel_Lab2_r.Data;
using Danea_Gabriel_Lab2_r.Models;

namespace Danea_Gabriel_Lab2_r.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Danea_Gabriel_Lab2_r.Data.Danea_Gabriel_Lab2_rContext _context;

        public IndexModel(Danea_Gabriel_Lab2_r.Data.Danea_Gabriel_Lab2_rContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Book != null)
            {
                Book = await _context.Book.Include(b=>b.Publisher).ToListAsync();
            }
        }
    }
}
