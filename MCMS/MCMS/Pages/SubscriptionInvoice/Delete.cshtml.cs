using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MCMS.Common.MCMS.Common.DataModel.Models;

namespace MCMS.Pages.SubscriptionInvoice
{
    public class DeleteModel : PageModel
    {
        private readonly MCMS.Common.MCMS.Common.DataModel.Models.medicalcenterContext _context;

        public DeleteModel(MCMS.Common.MCMS.Common.DataModel.Models.medicalcenterContext context)
        {
            _context = context;
        }

        [BindProperty]
        public SubscriptionInvoices SubscriptionInvoices { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SubscriptionInvoices = await _context.SubscriptionInvoices
                .Include(s => s.Clinic).FirstOrDefaultAsync(m => m.Id == id);

            if (SubscriptionInvoices == null)
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

            SubscriptionInvoices = await _context.SubscriptionInvoices.FindAsync(id);

            if (SubscriptionInvoices != null)
            {
                _context.SubscriptionInvoices.Remove(SubscriptionInvoices);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
