using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication17.Models;

namespace WebApplication17.Data
{
    public class WebApplication17Context : DbContext
    {
        public WebApplication17Context (DbContextOptions<WebApplication17Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplication17.Models.Student> Student { get; set; } = default!;
    }
}
