using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IEnsure.Models;

namespace IEnsure.Data
{
    public class IEnsureContext : DbContext
    {
        public IEnsureContext (DbContextOptions<IEnsureContext> options)
            : base(options)
        {
        }

        public DbSet<IEnsure.Models.Country> Country { get; set; }
    }
}
