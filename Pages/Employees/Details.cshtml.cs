using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagementRazor.Models;
using EmployeeManagementRazor.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeeManagementRazor.Pages.Employees
{
    public class DetailsModel : PageModel
    {
        private readonly IEmployeeRepository employeeRepository;

        public DetailsModel(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        [BindProperty(SupportsGet = true)]
        public string Message { get; set; }

        public Employee Employee { get; private set; }
       
        //[BindProperty(SupportsGet =true)]
        //public int Id { get; set; }
     
        public IActionResult OnGet(int id = 1)
        {
            Employee = employeeRepository.GetEmployee(id);
            if(Employee == null)
            {
                return RedirectToPage("/NotFound");
            }
            return Page();
        }
    }
}