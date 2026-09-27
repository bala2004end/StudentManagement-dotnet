using Microsoft.AspNetCore.Mvc;
using StudentManagement.Models;

namespace StudentManagement.Controllers;


[ApiController]
[Route("api/[controller]")]
public class StudentsController : ControllerBase
{
  [HttpGet]//GET API Request
  public IActionResult GetStudents()
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
    return Ok(students); 
  }
[HttpPost]//POST Request
public IActionResult AddStudent(Student student)
  {
   return Ok(student); 
  }

}