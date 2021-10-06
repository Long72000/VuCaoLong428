using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VuCaoLong428.Models;

namespace VuCaoLong428.Data
{
    public class VuCaoLong428Context : DbContext
    {
        public VuCaoLong428Context (DbContextOptions<VuCaoLong428Context> options)
            : base(options)
        {
        }

        public DbSet<VuCaoLong428.Models.VCL428> VCL428 { get; set; }
    }
}
