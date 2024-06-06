using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CURDAPP.Model;

namespace CURDAPP.Data
{
    public class CURDAPPContext : DbContext
    {
        public CURDAPPContext (DbContextOptions<CURDAPPContext> options)
            : base(options)
        {
        }

        public DbSet<CURDAPP.Model.User> User { get; set; } = default!;
    }
}
