using Microsoft.AspNetCore.Mvc;
using StudentRegistration.Models;

namespace StudentRegistration.Controllers;

public class StudentController : Controller
{
    private static readonly List<Student> _students = new();
    private static int _nextId = 1;

    public StudentController()
    {
        if (_students.Count == 0)
        {
            _students.Add(new Student
            {
                Id = _nextId++,
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                DateOfBirth = new DateTime(2002, 5, 15),
                Gender = "Male",
                PhoneNumber = "1234567890",
                Address = "123 Main Street",
                Course = "Computer Science",
                EnrollmentDate = DateTime.Today
            });
            _students.Add(new Student
            {
                Id = _nextId++,
                FirstName = "Jane",
                LastName = "Smith",
                Email = "jane.smith@example.com",
                DateOfBirth = new DateTime(2003, 8, 22),
                Gender = "Female",
                PhoneNumber = "0987654321",
                Address = "456 Oak Avenue",
                Course = "Information Technology",
                EnrollmentDate = DateTime.Today
            });
        }
    }

    public IActionResult Index()
    {
        return View(_students);
    }

    public IActionResult Details(int? id)
    {
        if (id == null)
            return NotFound();

        var student = _students.FirstOrDefault(s => s.Id == id);
        if (student == null)
            return NotFound();

        return View(student);
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
            student.Id = _nextId++;
            _students.Add(student);
            return RedirectToAction(nameof(Index));
        }
        return View(student);
    }

    public IActionResult Edit(int? id)
    {
        if (id == null)
            return NotFound();

        var student = _students.FirstOrDefault(s => s.Id == id);
        if (student == null)
            return NotFound();

        return View(student);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(int id, Student student)
    {
        if (id != student.Id)
            return NotFound();

        if (ModelState.IsValid)
        {
            var existingStudent = _students.FirstOrDefault(s => s.Id == id);
            if (existingStudent == null)
                return NotFound();

            existingStudent.FirstName = student.FirstName;
            existingStudent.LastName = student.LastName;
            existingStudent.Email = student.Email;
            existingStudent.DateOfBirth = student.DateOfBirth;
            existingStudent.Gender = student.Gender;
            existingStudent.PhoneNumber = student.PhoneNumber;
            existingStudent.Address = student.Address;
            existingStudent.Course = student.Course;
            existingStudent.EnrollmentDate = student.EnrollmentDate;

            return RedirectToAction(nameof(Index));
        }
        return View(student);
    }

    public IActionResult Delete(int? id)
    {
        if (id == null)
            return NotFound();

        var student = _students.FirstOrDefault(s => s.Id == id);
        if (student == null)
            return NotFound();

        return View(student);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
        var student = _students.FirstOrDefault(s => s.Id == id);
        if (student != null)
            _students.Remove(student);

        return RedirectToAction(nameof(Index));
    }
}
