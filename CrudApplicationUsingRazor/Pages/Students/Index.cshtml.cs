using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CrudApplicationUsingRazor.Data;
using CrudApplicationUsingRazor.Model;

namespace CrudApplicationUsingRazor.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly CrudApplicationUsingRazor.Data.CrudApplicationUsingRazorContext _context;

        public IndexModel(CrudApplicationUsingRazor.Data.CrudApplicationUsingRazorContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Student != null)
            {
                Student = await _context.Student.ToListAsync();
            }
        }
    }
}
