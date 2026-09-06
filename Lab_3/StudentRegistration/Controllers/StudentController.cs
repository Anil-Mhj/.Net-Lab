using Microsoft.AspNetCore.Mvc;
using StudentRegistration.Models;

namespace StudentRegistration.Controllers;

public class StudentController : Controller
{
    private static List<Student> _students = new()
    {
        new Student { StudentId = 1, Name = "John Doe", Faculty = "Computer Science", Email = "john@example.com" },
        new Student { StudentId = 2, Name = "Jane Smith", Faculty = "Mathematics", Email = "jane@example.com" }
    };

    private static int _nextId = 3;

    public IActionResult Index()
    {
        return View(_students);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Student student)
    {
        if (ModelState.IsValid)
        {
            student.StudentId = _nextId++;
            student.EnrollmentDate = DateTime.Now;
            _students.Add(student);
            return RedirectToAction(nameof(Index));
        }
        return View(student);
    }

    public IActionResult Edit(int id)
    {
        var student = _students.FirstOrDefault(s => s.StudentId == id);
        if (student is null) return NotFound();
        return View(student);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(Student student)
    {
        if (ModelState.IsValid)
        {
            var existing = _students.FirstOrDefault(s => s.StudentId == student.StudentId);
            if (existing is not null)
            {
                existing.Name = student.Name;
                existing.Faculty = student.Faculty;
                existing.Email = student.Email;
            }
            return RedirectToAction(nameof(Index));
        }
        return View(student);
    }

    public IActionResult Details(int id)
    {
        var student = _students.FirstOrDefault(s => s.StudentId == id);
        if (student is null) return NotFound();
        return View(student);
    }

    public IActionResult Delete(int id)
    {
        var student = _students.FirstOrDefault(s => s.StudentId == id);
        if (student is null) return NotFound();
        return View(student);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
        var student = _students.FirstOrDefault(s => s.StudentId == id);
        if (student is not null)
        {
            _students.Remove(student);
        }
        return RedirectToAction(nameof(Index));
    }
}