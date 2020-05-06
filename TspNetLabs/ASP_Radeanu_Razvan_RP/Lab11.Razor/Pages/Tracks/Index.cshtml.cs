using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lab11.Razor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lab11.Razor.Pages.Tracks
{
    public class IndexModel : PageModel
    {
        private readonly Data.Lab11RazorContext _context;

        public IndexModel(Data.Lab11RazorContext context)
        {
            _context = context;
        }

        public IList<Track> Tracks { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Artists { get; set; }
        [BindProperty(SupportsGet = true)]
        public string TrackArtist { get; set; }

        public async Task OnGetAsync()
        {
            var query = _context.Track.AsQueryable();
            if (!string.IsNullOrEmpty(TrackArtist?.Trim()))
            {
                query = query.Where(t => t.Artist == TrackArtist);
            }

            if (!string.IsNullOrEmpty(SearchString?.Trim()))
            {
                var lower = SearchString.ToLower();
                query = query.Where(t => t.Artist.Contains(lower) || t.Title.Contains(lower));
            }

            var artists = await _context.Track.Select(t => t.Artist).Distinct().ToListAsync();
            
            Artists = new SelectList(artists);
            Tracks = await query.ToListAsync();
        }
    }
}
