using StudentManagementSystem.Models;

public interface IStudentService
{
    IEnumerable<Student> GetStudents();
    Student GetStudent(int id);
    void CreateStudent(Student student);
    void UpdateStudent(Student student);
    void DeleteStudent(int id);
}