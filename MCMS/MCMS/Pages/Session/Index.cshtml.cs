﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MCMS.Common.MCMS.Common.DataModel.Models;

namespace MCMS.Pages.Session
{
    public class IndexModel : PageModel
    {
        private readonly MCMS.Common.MCMS.Common.DataModel.Models.medicalcenterContext _context;

        public IndexModel(MCMS.Common.MCMS.Common.DataModel.Models.medicalcenterContext context)
        {
            _context = context;
        }

        public IList<Sessions> Sessions { get;set; }

        public async Task OnGetAsync()
        {
            Sessions = await _context.Sessions
                .Include(s => s.Clinic)
                .Include(s => s.Doctor).ToListAsync();
        }
    }
}
