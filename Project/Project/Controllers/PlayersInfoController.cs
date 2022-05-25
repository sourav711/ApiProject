using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Models;
using Project.RequestModels;

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors(origins: "https://localhost:44330/api/PlayersInfo", headers: "*", methods: "*")]
    public class PlayersInfoController : ControllerBase
    {
        private readonly ProjectContext _projectcontext;
        public PlayersInfoController(ProjectContext project)
            {
            _projectcontext=project;
            }

        // GET: api/PlayersInfo
        [HttpGet]
        public IActionResult Get()
        {
            var getInfo = _projectcontext.PlayersInfo.ToList();
            return Ok(getInfo);
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            try
            {
                var result = _projectcontext.PlayersInfo.First(obj=>obj.PlayerId==id);

                if (result == null) return NotFound();

                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }


        // POST: api/PlayersInfo
        [HttpPost]
        public void Post([FromBody] PlayerRequest value)
        {
            PlayersInfo obj = new PlayersInfo();
            obj.PlayerName = value.PlayerName;
            obj.PlayerAge = value.PlayerAge;
            obj.PlayerRole = value.PlayerRole;
            obj.PlayerMatches = value.PlayerMatches;
            _projectcontext.PlayersInfo.Add(obj);
            _projectcontext.SaveChanges();


        }
        [HttpGet("{value}")]
        public IActionResult Get(string value)
        {

            var result = _projectcontext.PlayersInfo.Where(obj => obj.PlayerName.Contains(value));
            return Ok(result);



        }

        // PUT: api/PlayersInfo/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
