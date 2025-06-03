using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication19.Models;

namespace WebApplication19.Data
{
    public class WebApplication19Context : DbContext
    {
        public WebApplication19Context (DbContextOptions<WebApplication19Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplication19.Models.Product> Product { get; set; } = default!;
    }
}
