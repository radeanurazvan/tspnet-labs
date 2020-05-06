using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab11.Razor.Models;

namespace Lab11.Razor.Data
{
    public class Lab11RazorContext : DbContext
    {
        public Lab11RazorContext (DbContextOptions<Lab11RazorContext> options)
            : base(options)
        {
        }

        public DbSet<Lab11.Razor.Models.Track> Track { get; set; }
    }
}
