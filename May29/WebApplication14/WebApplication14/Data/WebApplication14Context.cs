using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication14.Models;

namespace WebApplication14.Data
{
    public class WebApplication14Context : DbContext
    {
        public WebApplication14Context (DbContextOptions<WebApplication14Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplication14.Models.Employee> Employee { get; set; } = default!;
        public DbSet<WebApplication14.Models.Contact> Contact { get; set; } = default!;
    }
}
