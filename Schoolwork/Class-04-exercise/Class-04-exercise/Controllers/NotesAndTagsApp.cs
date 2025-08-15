using Class_04_exercise.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Class_04_exercise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesAndTagsApp : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<NoteDto>> GetAll()
        {
            try
            {
                var notesDb = StaticDb.Notes;
                var notesDto = notesDb.Select(x => new NoteDto
                {
                    Priority = x.Priority,
                    Text = x.Text,
                    User = $"{x.User.FirstName} {x.User.LastName}",
                    Tags = x.Tags.Select(t => t.Name).ToList()
                });
                return Ok(notesDto);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred!");
            }
        }
        [HttpGet("{id}")]
        public ActionResult<NoteDto> GetById(int id)
        {
            try
            {
                if (id < 0)
                {
                    return BadRequest("The Id cannot be negative");
                }
                var noteDb = StaticDb.Notes.SingleOrDefault(x => x.Id == id);
                if (noteDb == null)
                {
                    return NotFound($"Note with Id {id} not found");
                }
                var notesDto = new NoteDto
                {
                    Priority = noteDb.Priority,
                    Text = noteDb.Text,
                    User = $"{noteDb.User.FirstName} {noteDb.User.LastName}",
                    Tags = noteDb.Tags.Select(t => t.Name).ToList()
                };
                return Ok(notesDto);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "an error exploderd!111!11");
            }
        }
        [HttpGet("findById")]
        public ActionResult<NoteDto> FindById(int id)
        {
            try
            {

            }
            catch
            {

            }
        }
    }
}
