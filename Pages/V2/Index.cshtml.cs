using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EmployeeManagementRazor.Models;
using EmployeeManagementRazor.Services;

namespace EmployeeManagementRazor.Pages.V2
{
    public class IndexModel : PageModel
    {
        private readonly EmployeeManagementRazor.Services.AppDbContext _context;

        public IndexModel(EmployeeManagementRazor.Services.AppDbContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; }

        public async Task OnGetAsync()
        {
            Employee = await _context.Employees.ToListAsync();
        }
    }
}
