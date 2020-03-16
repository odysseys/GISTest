using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SSO2.Models;

namespace SSO2.Data
{
    public class SSO2Context : DbContext
    {
        public SSO2Context (DbContextOptions<SSO2Context> options)
            : base(options)
        {
        }

        public DbSet<SSO2.Models.Account> Account { get; set; }
        public DbSet<SSO2.Models.Place> Place { get; set; }
    }
}
