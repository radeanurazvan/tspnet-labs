using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lab11.Razor.Data;
using Lab11.Razor.Models;

namespace Lab11.Razor.Pages.Tracks
{
    public class DetailsModel : PageModel
    {
        private readonly Lab11.Razor.Data.Lab11RazorContext _context;

        public DetailsModel(Lab11.Razor.Data.Lab11RazorContext context)
        {
            _context = context;
        }

        public Track Track { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Track = await _context.Track.FirstOrDefaultAsync(m => m.Id == id);

            if (Track == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
