using BAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.managers
{
    public interface IStudentManager
    {
        List<StudentReadVm> GetStudentsList();
        StudentReadVm? GetStudentById(Guid id);
        StudentReadVm AddStudent(StudentAddVm student);
        bool UpdateStudent(StudentUpdateVm student);
        void DeleteStudent(Guid id);
    }
}
