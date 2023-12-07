using LAB6.Data;
using LAB6.Models;
using Microsoft.AspNetCore.Mvc;

namespace LAB6.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IWebHostEnvironment _hostingEnvironment;

        public EmployeeController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            ViewBag.Layout = "_Lab2Layout";
            using var context = new EmployeeContext();
            var employees = context.Employees.ToList();
            return View(employees);
        }
        public IActionResult Details(int id = 1)
        {
            ViewBag.Layout = "_Lab2Layout";
            using var context = new EmployeeContext();
            var employees = context.Employees.FirstOrDefault(m => m.Id == id);
            return View(employees);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            using var context = new EmployeeContext();
            var employee = context.Employees.FirstOrDefault(m => m.Id == id);
            return View(employee);
        }
        [HttpPost("[controller]/[action]/{id}")]
        public IActionResult Edit(int id, Employee updatedEmployee)
        {
            if (ModelState.IsValid)
            {
                using var context = new EmployeeContext();
                context.Employees.Update(updatedEmployee);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            ModelState.AddModelError("", "Something went wrong");
            return View(updatedEmployee);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();

        }
        [HttpPost("[action]/[controller]")]
        public async Task<IActionResult> Create(Employee employee, IFormFile image)
        {
            if (ModelState.IsValid)
            {
                using var context = new EmployeeContext();

                if (image != null && image.Length > 0)
                {
                    // Generate a unique filename
                    string uniqueFileName = Guid.NewGuid().ToString() + "_" + image.FileName;

                    // Combine the filename with the wwwroot path where to store the images
                    string filePath = Path.Combine(_hostingEnvironment.WebRootPath, "images", uniqueFileName);

                    try
                    {
                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            await image.CopyToAsync(fileStream);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        ModelState.AddModelError("", "Something went wrong");
                    }
                    employee.Image = "/images/" + uniqueFileName;
                }
                context.Employees.Add(employee);
                await context.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Something went wrong");
            return View(employee);
        }

    }
}
