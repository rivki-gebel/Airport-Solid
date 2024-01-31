using AirPort_API.Entities;
using Airport_solidApi.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Solid.Core.Dto_s;
using Solid.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Airport_solidApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        private readonly IFlightService _flightService;
        private readonly IMapper _mapper;
        public FlightController(IFlightService flightService, IMapper mapper)
        {
            _flightService = flightService;
            _mapper = mapper;
        }
        // GET: api/<FlightController>
        [HttpGet]
        public ActionResult Get()
        {
            var flightsList = _flightService.GetFlights();
            var flightsDtoList = _mapper.Map<IEnumerable<FlightDto>>(flightsList);
            return Ok(flightsDtoList);
        }

        // GET api/<FlightController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var flight = _flightService.GetFlightById(id);
            var flightDto= _mapper.Map<FlightDto>(flight); 
            return Ok(flightDto);
        }

        // POST api/<FlightController>
        [HttpPost]
        public void Post([FromBody] FlightPostModel flight)
        {
            var flightToAdd = (new Flight
            {
                Destination = flight.Destination,
                SourceLand = flight.SourceLand,
                Cost = flight.Cost,
                TakeingOffTime= flight.TakeingOffTime,
                AirplaneID= flight.AirplaneID,
            });
            _flightService.AddFlight(flightToAdd);
        }

        // PUT api/<FlightController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] double cost)
        {
            _flightService.UpdateFlightCost(id, cost);
        }

        // DELETE api/<FlightController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _flightService.DeleteFlight(id);
        }
    }
}
