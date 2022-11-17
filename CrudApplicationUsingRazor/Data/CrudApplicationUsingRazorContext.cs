using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CrudApplicationUsingRazor.Model;

namespace CrudApplicationUsingRazor.Data
{
    public class CrudApplicationUsingRazorContext : DbContext
    {
        public CrudApplicationUsingRazorContext (DbContextOptions<CrudApplicationUsingRazorContext> options)
            : base(options)
        {
        }

        public DbSet<CrudApplicationUsingRazor.Model.Student> Student { get; set; } = default!;
    }
}
