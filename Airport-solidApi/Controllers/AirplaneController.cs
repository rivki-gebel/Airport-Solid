using AirPort_API.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Solid.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Airport_solidApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirplaneController : ControllerBase
    {
        private readonly IAirplaneService _airplaneService;
      
        public AirplaneController(IAirplaneService airplaneService)
        {
            _airplaneService= airplaneService;
        }

        // GET: api/<AirplaneController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_airplaneService.GetAirplanes());
        }

        // GET api/<AirplaneController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(_airplaneService.GetAirPlaneById(id));
        }

        // POST api/<AirplaneController>
        [HttpPost]
        public ActionResult Post([FromBody] AirPlane airPlane)
        {
            return Ok(_airplaneService.AddAirplane(airPlane));
        }

        // PUT api/<AirplaneController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] bool isProper)
        {
           return Ok( _airplaneService.UpdateAirplaneProperty(id, isProper));
        }

        // DELETE api/<AirplaneController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {           
            var airplane = _airplaneService.GetAirPlaneById(id);
            if (airplane is null)
            {
                return NotFound();
            }
            _airplaneService.DeleteAirplane(id);
            return NoContent();
        }
    }
}
