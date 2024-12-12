using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TuneTracks.Data;
using TuneTracks.Models;

namespace TuneTracks.Pages.Songs
{
    public class IndexModel : PageModel
    {
        private readonly TuneTracks.Data.TuneTracksContext _context;

        public IndexModel(TuneTracks.Data.TuneTracksContext context)
        {
            _context = context;
        }

        public IList<Song> Song { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Song = await _context.Songs
                .Include(s => s.Album)
                .Include(s => s.Artist).ToListAsync();
        }
    }
}
