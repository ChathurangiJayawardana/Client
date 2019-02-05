using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MCMS.Common.MCMS.Common.DataModel.Models;

namespace MCMS.Pages.Inventory
{
    public class IndexModel : PageModel
    {
        private readonly MCMS.Common.MCMS.Common.DataModel.Models.medicalcenterContext _context;

        public IndexModel(MCMS.Common.MCMS.Common.DataModel.Models.medicalcenterContext context)
        {
            _context = context;
        }

        public IList<Inventories> Inventories { get;set; }

        public async Task OnGetAsync()
        {
            Inventories = await _context.Inventories
                .Include(i => i.AddedByNavigation)
                .Include(i => i.Clinic).ToListAsync();
        }
    }
}
