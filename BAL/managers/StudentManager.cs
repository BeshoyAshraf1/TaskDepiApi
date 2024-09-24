using AutoMapper;
using BAL.ViewModel;
using DAL.Repositories.model;
using Demo2G1.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.managers
{
    public class StudentManager : IStudentManager
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public StudentManager(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        public List<StudentReadVm> GetStudentsList()
        {
            var students = _studentRepository.GetAll();
            return _mapper.Map<List<StudentReadVm>>(students);
        }

        public StudentReadVm? GetStudentById(Guid id)
        {
            var student = _studentRepository.GetById(id);
            return student == null ? null : _mapper.Map<StudentReadVm>(student);
        }

        public StudentReadVm AddStudent(StudentAddVm student)
        {
            var studentDb = _mapper.Map<Student>(student);
            studentDb.Id = Guid.NewGuid();

            _studentRepository.AddStudent(studentDb);
            return _mapper.Map<StudentReadVm>(studentDb);
        }

        public bool UpdateStudent(StudentUpdateVm student)
        {
            var studentDb = _studentRepository.GetById(student.Id);
            if (studentDb == null)
                return false;

            _mapper.Map(student, studentDb);
            _studentRepository.UpdateStudent(studentDb);
            return true;
        }

        public void DeleteStudent(Guid id)
        {
            var student = _studentRepository.GetById(id);
            if (student == null)
                return;

            _studentRepository.DeleteStudent(id);
        }
    }
}
