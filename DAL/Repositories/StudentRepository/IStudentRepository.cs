using DAL.Repositories.model;

namespace Demo2G1.DAL;

public interface IStudentRepository : IGenericRepository<Student>
{
    List<Student> GetStudentByPerformance(double phone);

    Student GetById(Guid id);       
    void AddStudent(Student student); 
    void UpdateStudent(Student student); 
    void DeleteStudent(Guid id);      
}
