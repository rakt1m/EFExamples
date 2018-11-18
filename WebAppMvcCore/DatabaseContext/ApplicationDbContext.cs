using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppMvcCore.Models;

namespace WebAppMvcCore.DatabaseContext
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext()
        {
            
        }

        public ApplicationDbContext(DbContextOptions options):base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("Server=RAKTIM-PC;Database=TrainingCenter;Trusted_Connrction=True");
        }

        public DbSet<Course> TrainingCenter { get; set; }
    }
}
