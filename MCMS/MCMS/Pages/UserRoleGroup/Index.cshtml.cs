using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MCMS.Common.MCMS.Common.DataModel.Models;

namespace MCMS.Pages.UserRoleGroup
{
    public class IndexModel : PageModel
    {
        private readonly MCMS.Common.MCMS.Common.DataModel.Models.medicalcenterContext _context;

        public IndexModel(MCMS.Common.MCMS.Common.DataModel.Models.medicalcenterContext context)
        {
            _context = context;
        }

        public IList<UserRoleGroups> UserRoleGroups { get;set; }

        public async Task OnGetAsync()
        {
            UserRoleGroups = await _context.UserRoleGroups
                .Include(u => u.RoleGroup)
                .Include(u => u.User).ToListAsync();
        }
    }
}
