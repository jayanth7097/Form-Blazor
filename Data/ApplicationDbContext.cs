using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Form.Models;
using Microsoft.EntityFrameworkCore;

namespace Form.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<UserDetails> UserDetails { get; set; }
        
    }
}