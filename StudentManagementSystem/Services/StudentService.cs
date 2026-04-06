using StudentManagementSystem.Models;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _repo;

    public StudentService(IStudentRepository repo)
    {
        _repo = repo;
    }

    public IEnumerable<Student> GetStudents() => _repo.GetAll();

    public Student GetStudent(int id) => _repo.GetById(id);

    public void CreateStudent(Student student)
    {
        student.CreatedDate = DateTime.Now;
        _repo.Add(student);
        _repo.Save();
    }

    public void UpdateStudent(Student student)
    {
        _repo.Update(student);
        _repo.Save();
    }

    public void DeleteStudent(int id)
    {
        _repo.Delete(id);
        _repo.Save();
    }
}