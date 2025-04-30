using modul10_103022330036;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using modul10_103022330036;
using System.Net.NetworkInformation;
using System.Security.Cryptography.Xml;

namespace MahasiswaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {
        // Static list untuk menyimpan data Mahasiswa
        private static List<Movie> movies = new List<Movie>
        {
            new Movie("The ShawHank  Redemption", "Frank Darabont", ["Bob Gunton", "Morgan Freeman", "Tim Robbins"] , "A banker convicted of uxoricide" +
                " forms a friendship over a quarter century with a hardened convict, while maintaining his innocence and trying to remain hopeful through simple compassion."),
            new Movie("The GodFather", "Francis Ford Coppola", ["Marlon Brando", "Al Pacino", "James Caan"] , "The aging patriarch of an organized crime dynasty" +
                " transfers control of his clandestine empire to his reluctant son."),
            new Movie("The Dark Jnight", "Christopher Nolan", ["Christopher Nolan", "Heath Ledger", "Christian Bale"], "When a menace known as the Joker wreaks havoc and chaos on the people" +
                " of Gotham, Batman, James Gordon and Harvey Dent must work together to put an end to the madness.")

        };

        // GET: api/mahasiswa
        [HttpGet]
        public ActionResult<List<Movie>> GetAll()
        {
            return movies;
        }

        // GET: api/movie/{index}
        [HttpGet("{index}")]
        public ActionResult<Movie> GetByIndex(int index)
        {
            if (index < 0 || index >= movies.Count)
            {
                return NotFound();
            }
            return movies[index];
        }

        // POST: api/movie
        [HttpPost]
        public ActionResult<List<Movie>> AddMahasiswa([FromBody] Movie moviee)
        {
            movies.Add(moviee);
            return movies;
        }

        // DELETE: api/movie/{index}
        [HttpDelete("{index}")]
        public ActionResult<List<Movie>> DeleteMovie(int index)
        {
            if (index < 0 || index >= movies.Count)
            {
                return NotFound();
            }
            movies.RemoveAt(index);
            return movies;
        }
    }
}