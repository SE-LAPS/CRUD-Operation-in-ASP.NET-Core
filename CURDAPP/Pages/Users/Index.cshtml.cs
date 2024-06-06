using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CURDAPP.Data;
using CURDAPP.Model;

namespace CURDAPP.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly CURDAPP.Data.CURDAPPContext _context;

        public IndexModel(CURDAPP.Data.CURDAPPContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.User != null)
            {
                User = await _context.User.ToListAsync();
            }
        }
    }
}
