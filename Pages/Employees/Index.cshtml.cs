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
    public class IndexModel : PageModel
    {
        private readonly IEmployeeRepository employeeRepository;
        public IEnumerable<Employee> employees;
        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public IndexModel(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        public void OnGet()
        {
            employees = employeeRepository.Search(SearchTerm);
        }
    }
}