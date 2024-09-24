using DAL.Repositories.applicationDBcontext;
using DAL.Repositories.model;
using System;

namespace Demo2G1.DAL;

public class StudentRepository : GenericRepository<Student>, IStudentRepository
{
    private readonly ApplicationDbContext _appContext;

    public StudentRepository(ApplicationDbContext appContext) : base(appContext)
    {
        _appContext = appContext;
    }

    public List<Student> GetStudentByPerformance(double phone)
    {
        return _appContext.Students.Where(x => x.Phone >= phone).ToList();
    }

    public Student GetById(Guid id)
    {
        return _appContext.Students.Find(id); 
    }

    public void AddStudent(Student student)
    {
        Add(student); 
        SaveChanges(); 
    }

    public void UpdateStudent(Student student)
    {
        Update(student); 
        SaveChanges(); 
    }

    public void DeleteStudent(Guid id)
    {
        Delete(id); 
        SaveChanges(); 
    }
}
