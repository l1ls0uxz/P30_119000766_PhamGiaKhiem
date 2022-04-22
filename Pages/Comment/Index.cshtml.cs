#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace P30_119000766_PhamGiaKhiem.Pages_Comment
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovieContext _context;

        public IndexModel(RazorPagesMovieContext context)
        {
            _context = context;
        }

        public IList<Comment> Comment { get;set; }

        public async Task OnGetAsync()
        {
            Comment = await _context.Comment.ToListAsync();
        }
    }
}
