 using Microsoft.AspNetCore.Mvc;
 using StudentManagement.Models;

// namespace StudentManagement.Controllers;


// [ApiController]
// [Route("api/[controller]")]
// public class StudentsController : ControllerBase
// {
//   [HttpGet("{id}")]//GET API Request
//   public IActionResult GetStudents(int id)
//   {
//     var students = new List<Student>
//     {
//       new Student
//       {
//         Id =1,
//         Name = "Bala",
//         Email = "bala@gmail.com",
//         Course = "CSE"

//       },
//       new Student 
//       {
//         Id =2,
//         Name = "Asus",
//         Email = "bala@gmail.com",
//         Course = "Civil"

//       }
//     };

//     var student =students.FirstOrDefault(s => s.Id == id);

//     if (student == null)
//     {
//       return NotFound("Student not there");
//     }
//     return Ok(student); 
//   }

//   [HttpGet]//GET API Request
//   public IActionResult GetStudents()
//   {
//     var students = new List<Student>
//     {
//       new Student
//       {
//         Id =1,
//         Name = "Bala",
//         Email = "bala@gmail.com",
//         Course = "CSE"

//       },
//       new Student 
//       {
//         Id =2,
//         Name = "Asus",
//         Email = "bala@gmail.com",
//         Course = "Civil"

//       }
      
      
//     };

//     return Ok(students); 
    
//   }
  
// [HttpPost]//POST Request
// public IActionResult AddStudent(Student student)
//   {
//    return Ok(student); 
//   }
// [HttpPut("{id}")]  //PUT Request 
// public IActionResult UpdateStudent(int id ,Student student)
//   {
//     if(id!= student.Id)
//     {
//       return BadRequest("ID mismatch");
//     }
//     return Ok(new
//     {
//       message ="Student updated successfully",
//       data = student 
//     });

//   }

//   [HttpDelete("{id}")]//GET API Request
//   public IActionResult DeleteStudents(int id)
//   {
//     var students = new List<Student>
//     {
//       new Student
//       {
//         Id =1,
//         Name = "Bala",
//         Email = "bala@gmail.com",
//         Course = "CSE"

//       },
//       new Student 
//       {
//         Id =2,
//         Name = "Asus",
//         Email = "bala@gmail.com",
//         Course = "Civil"

//       }
//     };

//     var student =students.FirstOrDefault(s => s.Id == id);

//     if (student == null)
//     {
//       return NotFound("Student not there");
//     }
//     students.Remove(student);
//     return Ok(new
//     {
//       message = "Student delete successfully",
//       data = student
//     }); 
//   }

// }
using Microsoft.EntityFrameworkCore;
using StudentManagement.Models;
using StudentManagement.Data;

namespace StudentManagement.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentsController : ControllerBase
{
    private readonly AppDbContext _context;

    public StudentsController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetStudents()
    {
        var students = await _context.Students.ToListAsync();

        return Ok(students);
    }

    [HttpPost]
public async Task<IActionResult> AddStudent(Student student)
{
    _context.Students.Add(student);

    await _context.SaveChangesAsync();

    return Ok(student);
}
}