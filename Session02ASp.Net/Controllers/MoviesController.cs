using Microsoft.AspNetCore.Mvc;
using Session02ASp.Net.Models;

namespace Session02ASp.Net.Controllers
{
    public class MoviesController : Controller
    {
        public string Index()
        {
            return "Hello From Index";
        }
        #region Exampl01
        //public ContentResult GetMovie(int? id, string name)
        //{
        //    //ContentResult result = new ContentResult();
        //    //result.Content = "Movie With Name: {name} and Id: {id}";
        //    //result.ContentType = "text/html";
        //    //result.StatusCode = 700;
        //    //return result;


        //    //HelperMethod 
        //    return Content($"Movie With Name: {name} and Id: {id}");
        //}
        #endregion

        //public ContentResult GetMovie(int? id, string name)
        //{
        //    ContentResult result = new ContentResult();
        //    result.Content = $"Movie With Name: {name} <br>and Id: {id}";
        //    result.ContentType = "text/html";
        //    result.StatusCode = 700;
        //    return result;
        //}

        public IActionResult GetMovie(int? id, string name)
        {
            // Id = 0 => BadRequest
            // Id < 10 => NotFound
            //Id > 10 => return movie

            if (id == 0)
                return BadRequest();
            else if (id < 10)
                return NotFound();
            else
                return Content($"Movie With Name: {name} and Id: {id}");
        }

        public IActionResult TestRedirectResult()
        {
            return RedirectToAction("GetMovie", "Movies", new { id = 10, name = "Test" });
            //return Redirect("https://localhost:7168/");
        }

        [HttpGet] //Binding Simple Date
        public IActionResult TestModelBinding(int id, string name)
        {
            return Content($"Hello {name} Your Id Is {id}");
        }

        //Binding Complex Data
        //[FromBody]  
        //[FromHeader] => Is Not working For Complex Data
        [HttpPost]
        public IActionResult AddMovie(Movie movie)
        {
            if (movie == null)
                return BadRequest();
            else
                return Content($"Movie = {movie.Title} With id = {movie.Id}");
        }

        [HttpGet]
        public IActionResult AddMovie02(string title, Movie movie, int id, int[] arr)
        {
            if (movie == null)
                return BadRequest();
            else
                return Content($"Movie = {movie.Title} With id = {movie.Id}");
        }



        //[NonAction]
        //public void DeleteMovie()
        //{

        //}


    }
}
