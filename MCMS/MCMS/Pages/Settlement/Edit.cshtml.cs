using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MCMS.Common.MCMS.Common.DataModel.Models;

namespace MCMS.Pages.Settlement
{
    public class EditModel : PageModel
    {
        private readonly MCMS.Common.MCMS.Common.DataModel.Models.medicalcenterContext _context;

        public EditModel(MCMS.Common.MCMS.Common.DataModel.Models.medicalcenterContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Settlements Settlements { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Settlements = await _context.Settlements
                .Include(s => s.Clinic)
                .Include(s => s.Doctor).FirstOrDefaultAsync(m => m.Id == id);

            if (Settlements == null)
            {
                return NotFound();
            }
           ViewData["ClinicId"] = new SelectList(_context.Clinics, "Id", "Address");
           ViewData["DoctorId"] = new SelectList(_context.Doctors, "Id", "Phone");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Settlements).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SettlementsExists(Settlements.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SettlementsExists(int id)
        {
            return _context.Settlements.Any(e => e.Id == id);
        }
    }
}
