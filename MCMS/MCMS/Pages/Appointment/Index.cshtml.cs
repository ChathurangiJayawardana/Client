﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MCMS.Common.MCMS.Common.DataModel.Models;

namespace MCMS.Pages.Appointment
{
    public class IndexModel : PageModel
    {
        private readonly MCMS.Common.MCMS.Common.DataModel.Models.medicalcenterContext _context;

        public IndexModel(MCMS.Common.MCMS.Common.DataModel.Models.medicalcenterContext context)
        {
            _context = context;
        }

        public IList<Appointments> Appointments { get;set; }

        public async Task OnGetAsync()
        {
            Appointments = await _context.Appointments
                .Include(a => a.Clinic)
                .Include(a => a.CreatedByNavigation)
                .Include(a => a.Doctor)
                .Include(a => a.Patient)
                .Include(a => a.Session).ToListAsync();
        }
    }
}
