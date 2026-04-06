using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Models;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class StudentController : ControllerBase
{
    private readonly IStudentService _service;

    public StudentController(IStudentService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetAll() => Ok(_service.GetStudents());

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var student = _service.GetStudent(id);
        if (student == null) return NotFound();
        return Ok(student);
    }

    [HttpPost]
    public IActionResult Create(Student student)
    {
        _service.CreateStudent(student);
        return Ok(student);
    }

    [HttpPut]
    public IActionResult Update(Student student)
    {
        _service.UpdateStudent(student);
        return Ok(student);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _service.DeleteStudent(id);
        return Ok();
    }
}