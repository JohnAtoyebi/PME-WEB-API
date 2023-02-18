using Microsoft.EntityFrameworkCore;
using PME.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PME.Data
{
    public class PMEDbContext : DbContext
    {
        public PMEDbContext(DbContextOptions<PMEDbContext> options) : base(options)
        {

        }

        public DbSet<PersonalDetails> PersonalDetails { get; set; }
    }
}
