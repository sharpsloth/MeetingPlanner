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
    public class IndexModel : PageModel
    {
        private readonly MeetingPlanner.Data.SacramentContext _context;

        public IndexModel(MeetingPlanner.Data.SacramentContext context)
        {
            _context = context;
        }

        public IList<Planner> Planner { get;set; }

        public async Task OnGetAsync()
        {
            Planner = await _context.Planners.ToListAsync();
        }
    }
}
