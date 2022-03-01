using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movieshop.API.ResponseModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Movieshop.API.Controller
{
    [Route("movie")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        //[Route("all-movies")]
        //[HttpGet]
        //public List <string> Get() {
        //    return new List<string> { "Rush Hour", "Die Hard"};
        //}

        //[Route("getonemovie")]
        //[HttpGet]
        //public string GetMovie()
        //{
        //    return "Die Hard";
        //}

        //[Route("get/{id:min(1):max(200)}")] // using dynamics
        //public string GetByID(int id) {
        //    return "Movie = " + id;
        //}

        //[Route("getbyname/{name:alpha:length(10)}")] //alpha filter will only allow alphabets
        //// any chars less than or more than 10 will not work
        //public string GetByName(string name) {
        //    return "Movie: " + name;
        //}

        List<MovieResponseModel> lst;
        public MovieController()
        {
            lst = new List<MovieResponseModel>()
            {
                new MovieResponseModel { Id = 1, Name="Die Hard", Ratings = 3},
                new MovieResponseModel { Id = 2, Name="Fast and Furious", Ratings = 5},
                new MovieResponseModel { Id = 3, Name="Rush Hour", Ratings = 7.5f},
            };
        }
        [Route("list")]
        public IActionResult Get()
        {
            return Ok(lst);
        }

        [Route("id/{id:int}")]
        public IActionResult Get(int id) {
            if (id < 1) 
                return BadRequest();
            return Ok(lst.Where(x => x.Id == id).FirstOrDefault());
        }

        [Route("name/{name:alpha}")]
        public IActionResult GetByName(string name) {
            if (string.IsNullOrEmpty(name))
                return NoContent();
            return Ok(lst.Where(x => x.Name == name).FirstOrDefault());
        }

    }
}

