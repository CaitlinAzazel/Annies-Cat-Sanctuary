using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorSignalRApp.Models;

namespace BlazorSignalRApp.Data
{
    public class BlazorSignalRAppContext : DbContext
    {
        public BlazorSignalRAppContext (DbContextOptions<BlazorSignalRAppContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorSignalRApp.Models.Pet> Pet { get; set; } = default!;
        public DbSet<BlazorSignalRApp.Models.AdoptForm> AdoptForm { get; set; } = default!;
    }
}
