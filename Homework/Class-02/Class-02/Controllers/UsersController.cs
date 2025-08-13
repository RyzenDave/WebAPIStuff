using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Class_02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<string>> GetAll()
        {
            return Ok(StaticDb.Usernames);
        }
        [HttpGet("{index}")]
        public IActionResult GetByIndex(int index)
        {
            try
            {
                if (index < 0)
                {
                    return BadRequest("The index must be positive number");
                    //return StatusCode(StatusCodes.Status400BadRequest, "The index must be positive number");
                }

                if (index > StaticDb.Usernames.Count)
                {
                    //return NotFound($"There is no resource on index {index}");

                    return StatusCode(StatusCodes.Status404NotFound, $"There is no resource on index {index}");
                }
                return Ok(StaticDb.Usernames[index]);

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred. Contact the admin!");
            }
        }
    }
}
