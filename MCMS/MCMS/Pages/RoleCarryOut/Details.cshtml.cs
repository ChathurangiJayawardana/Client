using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MCMS.Common.MCMS.Common.DataModel.Models;

namespace MCMS.Pages.RoleCarryOut
{
    public class DetailsModel : PageModel
    {
        private readonly MCMS.Common.MCMS.Common.DataModel.Models.medicalcenterContext _context;

        public DetailsModel(MCMS.Common.MCMS.Common.DataModel.Models.medicalcenterContext context)
        {
            _context = context;
        }

        public RoleCarryOuts RoleCarryOuts { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            RoleCarryOuts = await _context.RoleCarryOuts
                .Include(r => r.Role)
                .Include(r => r.RoleGroup).FirstOrDefaultAsync(m => m.RoleGroupId == id);

            if (RoleCarryOuts == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
