﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly EmployeeManagementRazor.Services.AppDbContext _context;

        public DetailsModel(EmployeeManagementRazor.Services.AppDbContext context)
        {
            _context = context;
        }

        public Employee Employee { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Employee = await _context.Employees.FirstOrDefaultAsync(m => m.Id == id);

            if (Employee == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
