using BAL.managers;
using BAL.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace TaskDEPIAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentManager _studentManager;

        public StudentController(IStudentManager studentManager)
        {
            _studentManager = studentManager;
        }

        [HttpGet]
        public ActionResult<List<StudentReadVm>> GetAllStudents()
        {
            var students = _studentManager.GetStudentsList();
            return Ok(students);
        }

        [HttpGet("{id}")]
        public ActionResult<StudentReadVm> GetStudentById(Guid id)
        {
            var student = _studentManager.GetStudentById(id);
            if (student == null)
                return NotFound();

            return Ok(student);
        }

        [HttpPost]
        public ActionResult<StudentReadVm> AddStudent([FromBody] StudentAddVm student)
        {
            var addedStudent = _studentManager.AddStudent(student);
            return CreatedAtAction(nameof(GetStudentById), new { id = addedStudent.Id }, addedStudent);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateStudent(Guid id, [FromBody] StudentUpdateVm student)
        {
            if (id != student.Id)
                return BadRequest();

            var updated = _studentManager.UpdateStudent(student);
            if (!updated)
                return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteStudent(Guid id)
        {
            _studentManager.DeleteStudent(id);
            return NoContent();
        }
    }
}
