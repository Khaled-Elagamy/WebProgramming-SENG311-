using LAB6.Data;
using LAB6.Models;
using Microsoft.AspNetCore.Mvc;

namespace LAB6.Controllers
{
    public class CompanyController : Controller
    {
        private readonly EmployeeContext _context;

        public CompanyController(EmployeeContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.Layout = "_Lab2Layout";
            var companyDetailsList = _context.Companies
                .Select(c => new CompanyDetailsDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    FullAddress = $"{c.City}, {c.Country}",
                    NumberOfEmployees = c.Employees.Count()
                })
                .ToList();
            return View(companyDetailsList);
        }
    }
}
