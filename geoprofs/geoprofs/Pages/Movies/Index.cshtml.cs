using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using geoprofs.Data;
using geoprofs.Models;

namespace geoprofs.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly geoprofs.Data.geoprofsContext _context;

        public IndexModel(geoprofs.Data.geoprofsContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
