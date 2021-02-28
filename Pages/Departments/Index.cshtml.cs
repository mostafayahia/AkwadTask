using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AkwadTask.Data;
using AkwadTask.Models;

namespace AkwadTask.Pages.Departments
{
    public class IndexModel : PageModel
    {
        private readonly AkwadTask.Data.AkwadTaskContext _context;

        public IndexModel(AkwadTask.Data.AkwadTaskContext context)
        {
            _context = context;
        }

        public IList<Department> Department { get;set; }

        public async Task OnGetAsync()
        {
            Department = await _context.Department.ToListAsync();
        }
    }
}
