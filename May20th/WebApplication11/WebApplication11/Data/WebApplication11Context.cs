using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication11.Models;

namespace WebApplication11.Data
{
    public class WebApplication11Context : DbContext
    {
        public WebApplication11Context (DbContextOptions<WebApplication11Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplication11.Models.Department> Department { get; set; } = default!;
    }
}
