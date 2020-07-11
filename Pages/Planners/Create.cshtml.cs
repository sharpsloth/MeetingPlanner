using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MeetingPlanner.Data;
using MeetingPlanner.Models;

namespace MeetingPlanner.Pages.Planners
{
    public class CreateModel : PageModel
    {
        private readonly MeetingPlanner.Data.SacramentContext _context;

        public CreateModel(MeetingPlanner.Data.SacramentContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Planner Planner { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            var emptyPlanner = new Planner();
            if (await TryUpdateModelAsync<Planner>(
                emptyPlanner,
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
                _context.Planners.Add(emptyPlanner);
                await _context.SaveChangesAsync();
                return RedirectToPage("/Index");
            }

            return Page();
        }
    }
}
