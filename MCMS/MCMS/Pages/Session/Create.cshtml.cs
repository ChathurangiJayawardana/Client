﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MCMS.Common.MCMS.Common.DataModel.Models;

namespace MCMS.Pages.Session
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
        ViewData["DoctorId"] = new SelectList(_context.Doctors, "Id", "Phone");
            return Page();
        }

        [BindProperty]
        public Sessions Sessions { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Sessions.Add(Sessions);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}