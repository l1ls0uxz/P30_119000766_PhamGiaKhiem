#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace P30_119000766_PhamGiaKhiem.Pages_News
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesMovieContext _context;

        public DeleteModel(RazorPagesMovieContext context)
        {
            _context = context;
        }

        [BindProperty]
        public News News { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            News = await _context.News.FirstOrDefaultAsync(m => m.ID == id);

            if (News == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            News = await _context.News.FindAsync(id);

            if (News != null)
            {
                _context.News.Remove(News);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
