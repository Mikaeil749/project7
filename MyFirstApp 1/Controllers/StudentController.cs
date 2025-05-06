using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace MyFirstApp;

public class StudentController : Controller
{
    public IActionResult Index()
    {
        var students = new List<Student>
        {
            new Student { Id = 1, Name = "Ali", Age = 22 },
            new Student { Id = 2, Name = "Sara", Age = 20 },
            new Student { Id = 3, Name = "Reza", Age = 23 }
        };

        return View(students);
    }
}
