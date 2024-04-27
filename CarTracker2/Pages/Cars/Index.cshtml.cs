using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CarTracker2.Data;

namespace CarTracker2.Pages.Cars
{
    public class IndexModel : PageModel
    {
        private readonly CarTracker2.Data.CarTrackerContext _context;

        public IndexModel(CarTracker2.Data.CarTrackerContext context)
        {
            _context = context;
        }

        public IList<Car> Car { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Car = await _context.Car.ToListAsync();
        }
    }
}
