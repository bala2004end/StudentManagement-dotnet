using Microsoft.AspNetCore.Mvc;
using StudentManagement.Models;

namespace StudentManagement.Controllers;


[ApiController]
[Route("api/[controller]")]
public class StudentsController : ControllerBase
{
  [HttpGet("{id}")]//GET API Request
  public IActionResult GetStudents(int id)
  {
    var students = new List<Student>
    {
      new Student
      {
        Id =1,
        Name = "Bala",
        Email = "bala@gmail.com",
        Course = "CSE"

      },
      new Student 
      {
        Id =2,
        Name = "Asus",
        Email = "bala@gmail.com",
        Course = "Civil"

      }
    };

    var student =students.FirstOrDefault(s => s.Id == id);

    if (student == null)
    {
      return NotFound("Student not there");
    }
    return Ok(student); 
  }
[HttpPost]//POST Request
public IActionResult AddStudent(Student student)
  {
   return Ok(student); 
  }

}