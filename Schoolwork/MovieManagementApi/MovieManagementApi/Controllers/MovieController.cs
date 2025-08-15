using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieManagementApi.DTO;
using MovieManagementApi.Models;
using MovieManagementApi.Models.Enums;

namespace MovieManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Movie>> GetAll()
        {
            try
            {
                var moviesDb = StaticDb.Movies;
                var movieDto = moviesDb.Select(x => new MovieDto
                {
                    Title = x.Title,
                    Description = x.Description,
                    Genre = x.Genre
                }).ToList();

                return Ok(movieDto);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "An error occured, contact admin!");
            }
     
        }
        [HttpPost("createMovie")]
        public IActionResult AddMovie([FromBody] CreateMovieDto createMovieDto)
        {
            try
            {
                if (string.IsNullOrEmpty(createMovieDto.Title))
                {
                    return BadRequest("Title is a required field");
                }                  

                var newMovie = new Movie
                {
                    Id = StaticDb.Movies.Count + 1,
                    Title = createMovieDto.Title,
                    Description = createMovieDto.Description,
                    Year = createMovieDto.Year,
                    Genre = createMovieDto.Genre
                };

                StaticDb.Movies.Add(newMovie);
                return StatusCode(StatusCodes.Status201Created,
                    "Note created!");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "An error occured, contact admin!");
            }
        }
        [HttpGet("{id}")]
        public ActionResult<MovieDto> GetById(int id)
        {
            try
            {
                if (id < 0)
                {
                    return BadRequest("The Id cannot be negative.");
                }

                var movieDb = StaticDb.Movies.SingleOrDefault(x => x.Id == id);
                if (movieDb == null)
                {
                    return NotFound($"Note with id: {id} does not exist!");
                }


                var movieDto = new MovieDto
                {
                    Title = movieDb.Title,
                    Description = movieDb.Description,
                    Year = movieDb.Year,
                    Genre = movieDb.Genre
                };
                return Ok(movieDto);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "An error occured, contact admin!");
            }
        }
        [HttpPut]
        [HttpPut]
        public IActionResult Put([FromBody] UpdateMovieDto updateMovieDto)
        {
            try
            {
                
                var movieDb = StaticDb.Movies.FirstOrDefault(x => x.Id == updateMovieDto.Id);
                if (movieDb == null)
                {
                    return NotFound($"Movie with id: {updateMovieDto.Id} was not found");
                }
 
                if (string.IsNullOrEmpty(updateMovieDto.Title))
                {
                    return BadRequest("Title is a required field");
                }
 
                movieDb.Title = updateMovieDto.Title;
                movieDb.Description = updateMovieDto.Description;
                movieDb.Year = updateMovieDto.Year;
                movieDb.Genre = updateMovieDto.Genre;
                 
                return NoContent();  
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "An error occurred while updating the movie.");
            }
        }
        [HttpGet("filter")]
        public IActionResult FilterMovies(
        [FromQuery] string? genre,   
        [FromQuery] int? year)
        {
            try
            {
                var movies = StaticDb.Movies.AsQueryable();

                if (!string.IsNullOrEmpty(genre))
                {
                    if (Enum.TryParse<Genre>(genre, ignoreCase: true, out var genreFilter))
                    {
                        movies = movies.Where(m => m.Genre == genreFilter);
                    }
                    else
                    {
                        return BadRequest($"Invalid genre. Valid options: {string.Join(", ", Enum.GetNames(typeof(Genre)))}");
                    }
                }

                if (year.HasValue)
                {
                    movies = movies.Where(m => m.Year.Year == year.Value);
                }

                var result = movies.Select(m => new
                {
                    m.Id,
                    m.Title,
                    m.Description,
                    Year = m.Year.Year,
                    Genre = m.Genre.ToString()
                }).ToList();

                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error occurred while filtering movies.");
            }
        }
        [HttpDelete("delete-from-route/{id}")]
        public IActionResult DeleteFromRoute(int id)
        {
            try
            {
                
                var movieDb = StaticDb.Movies.FirstOrDefault(x => x.Id == id);
                if (movieDb == null)
                {
                    return NotFound($"Movie with id: {id} was not found");
                }
                 
                StaticDb.Movies.Remove(movieDb);

              
                return NoContent();
            }
            catch (Exception)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    "An error occurred while deleting the movie."
                );
            }
        }
    }
}
