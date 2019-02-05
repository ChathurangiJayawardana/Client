using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MCMS.Common.MCMS.Common.DataModel.Models;

namespace MCMS.Pages.Appointment
{
    public class CreateModel : PageModel
    {
        private readonly MCMS.Common.MCMS.Common.DataModel.Models.medicalcenterContext _context;

        public CreateModel(MCMS.Common.MCMS.Common.DataModel.Models.medicalcenterContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ClinicId"] = new SelectList(_context.Clinics, "Id", "Address");
        ViewData["CreatedBy"] = new SelectList(_context.Users, "Id", "Email");
        ViewData["DoctorId"] = new SelectList(_context.Doctors, "Id", "Phone");
        ViewData["PatientId"] = new SelectList(_context.Patients, "Id", "Address");
        ViewData["SessionId"] = new SelectList(_context.Sessions, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Appointments Appointments { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Appointments.Add(Appointments);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}