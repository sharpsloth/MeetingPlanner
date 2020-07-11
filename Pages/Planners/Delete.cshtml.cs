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
    public class DeleteModel : PageModel
    {
        private readonly MeetingPlanner.Data.SacramentContext _context;

        public DeleteModel(MeetingPlanner.Data.SacramentContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Planner Planner { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Planner = await _context.Planners.FirstOrDefaultAsync(m => m.ID == id);

            if (Planner == null)
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

            Planner = await _context.Planners.FindAsync(id);

            if (Planner != null)
            {
                _context.Planners.Remove(Planner);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
