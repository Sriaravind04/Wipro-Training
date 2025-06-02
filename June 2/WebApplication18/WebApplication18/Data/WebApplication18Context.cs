using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication18.Models;

namespace WebApplication18.Data
{
    public class WebApplication18Context : DbContext
    {
        public WebApplication18Context (DbContextOptions<WebApplication18Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplication18.Models.Employee> Employee { get; set; } = default!;
    }
}
