using LAB7.ViewComponents;
using Microsoft.AspNetCore.Mvc;
public class LeftNavigation : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        var links = new List<NavLink>
        {
            new NavLink("Home", "Index","Home"),
            new NavLink("Employee", "Index","Employees"),
            new NavLink("Employee", "SalaryDetails","SalaryDetails"),
            new NavLink("Company", "Index","Companies"),
            new NavLink("Home", "Privacy","Privacy"),

        };

        return View(links);
    }
}
