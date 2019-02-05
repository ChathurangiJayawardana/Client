﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MCMS.Common.MCMS.Common.DataModel.Models;

namespace MCMS.Pages.Prescription
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
        ViewData["AppointmentId"] = new SelectList(_context.Appointments, "Id", "Id");
        ViewData["InventoryId"] = new SelectList(_context.Inventories, "Id", "BrandName");
            return Page();
        }

        [BindProperty]
        public Prescriptions Prescriptions { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Prescriptions.Add(Prescriptions);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}