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
    public class DetailsModel : PageModel
    {
        private readonly AkwadTask.Data.AkwadTaskContext _context;

        public DetailsModel(AkwadTask.Data.AkwadTaskContext context)
        {
            _context = context;
        }

        public Department Department { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Department = await _context.Department.FirstOrDefaultAsync(m => m.ID == id);

            if (Department == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
