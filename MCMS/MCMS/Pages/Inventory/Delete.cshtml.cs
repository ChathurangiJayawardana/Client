﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MCMS.Common.MCMS.Common.DataModel.Models;

namespace MCMS.Pages.Inventory
{
    public class DeleteModel : PageModel
    {
        private readonly MCMS.Common.MCMS.Common.DataModel.Models.medicalcenterContext _context;

        public DeleteModel(MCMS.Common.MCMS.Common.DataModel.Models.medicalcenterContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Inventories Inventories { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Inventories = await _context.Inventories
                .Include(i => i.AddedByNavigation)
                .Include(i => i.Clinic).FirstOrDefaultAsync(m => m.Id == id);

            if (Inventories == null)
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

            Inventories = await _context.Inventories.FindAsync(id);

            if (Inventories != null)
            {
                _context.Inventories.Remove(Inventories);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
