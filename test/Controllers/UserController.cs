using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using test.core.IRepositpry;
using test.core.model;
using test.infra.Repository;

namespace test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUnitRep UnitRep;
        public UserController( IUnitRep unitRep)
        {
            UnitRep = unitRep;
        }

        [HttpPost("Create")]
        public IActionResult CreateUser(User user)
        {
            try
            {
                UnitRep.UserRep.Create(user);
                
                UnitRep.Complite();
                return Ok();
            }
            catch(Exception ex) 
            {

                throw new Exception(ex.Message);
            }
        }


        [HttpGet("GetUsers")]
        public IActionResult GetUsers()
        {
            try
            {
               var users = UnitRep.UserRep.GetAll();
                if (users.IsNullOrEmpty())
                {
                    return NoContent();
                }
                return Ok(users);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
