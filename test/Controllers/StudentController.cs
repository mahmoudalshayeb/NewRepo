using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using test.core.IRepositpry;
using test.core.model;

namespace test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IUnitRep UnitRep;
        public StudentController(IUnitRep unitRep)
        {
            UnitRep = unitRep;
        }

        [HttpPost("Create")]
        public IActionResult CreateStudent(Student student)
        {
            try
            {
                UnitRep.StudentRep.Create(student);
                UnitRep.Complite();
                return Ok();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


        [HttpGet("GetStudents")]
        public IActionResult GetStudents()
        {
            try
            {
                var students = UnitRep.StudentRep.GetAll();
                if (students.IsNullOrEmpty())
                {
                    return NoContent();
                }
                return Ok(students);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
