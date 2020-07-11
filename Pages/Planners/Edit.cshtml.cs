using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MeetingPlanner.Data;
using MeetingPlanner.Models;

namespace MeetingPlanner.Pages.Planners
{
    public class EditModel : PageModel
    {
        private readonly MeetingPlanner.Data.SacramentContext _context;

        public EditModel(MeetingPlanner.Data.SacramentContext context)
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

            Planner = await _context.Planners.FindAsync(id);

            if (Planner == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var plannerToUpdate = await _context.Planners.FindAsync(id);

            if (await TryUpdateModelAsync<Planner>(
                plannerToUpdate,
                "planner",  // Prefix for form value.
                p => p.MeetingDate,
                p => p.Conducting,
                p => p.OpeningSong,
                p => p.SacramentHymn,
                p => p.ClosingSong,
                p => p.IntermediateMusic,
                p => p.OpeningPrayer,
                p => p.ClosingPrayer))
            {
         
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }

            return Page();
        }

        private bool PlannerExists(int id)
        {
            return _context.Planners.Any(e => e.ID == id);
        }
    }
}
