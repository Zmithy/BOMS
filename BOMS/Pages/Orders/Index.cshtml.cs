using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BOMS.Data;
using BOMS.Models;

namespace BOMS.Pages.Orders
{
    public class IndexModel : PageModel
    {
        private readonly BOMS.Data.BOMSContext _context;

        public IndexModel(BOMS.Data.BOMSContext context)
        {
            _context = context;
        }

        public IList<Order> Order { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Order != null)
            {
                Order = await _context.Order.ToListAsync();
            }
        }
    }
}
