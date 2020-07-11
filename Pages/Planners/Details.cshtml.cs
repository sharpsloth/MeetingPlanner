using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MeetingPlanner.Data;
using MeetingPlanner.Models;

namespace MeetingPlanner.Pages.Planners
{
    public class DetailsModel : PageModel
    {
        private readonly MeetingPlanner.Data.SacramentContext _context;

        public DetailsModel(MeetingPlanner.Data.SacramentContext context)
        {
            _context = context;
        }

        public Planner Planner { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Planner = await _context.Planners
                .Include(p => p.Talks)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);

            if (Planner == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
