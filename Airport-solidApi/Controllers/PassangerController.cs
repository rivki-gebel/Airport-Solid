using AirPort_API.Entities;
using Airport_solidApi.Models;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Solid.Core.Dto_s;
using Solid.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Airport_solidApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PassangerController : ControllerBase
    {
        private readonly IPassangerService _passangerService;
        private readonly IMapper _mapper;
        public PassangerController(IPassangerService passangerService, IMapper mapper)
        {
            _passangerService = passangerService;
            _mapper = mapper;
        }

        // GET: api/<PassangerController>
        [HttpGet]
        public ActionResult Get()
        {
            var passangerslist = _passangerService.GetPassangers();
            var passangersDtolist = _mapper.Map<IEnumerable<PassangerDto>>(passangerslist);
            return Ok(passangersDtolist);
        }

        // GET api/<PassangerController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var passanger = _passangerService.GetPassangerById(id);
            var passangerDto=_mapper.Map<PassangerDto>(passanger);
            return Ok(passangerDto);
        }

        // POST api/<PassangerController>
        [HttpPost]
        public void Post([FromBody] PassangerPostPutModel passenger)
        {
            var passToAdd=(new Passanger 
            { 
                Name= passenger.Name,
                IdNum=passenger.IdNum,
                Adress=passenger.Adress,
                Phone=passenger.Phone,
                FlightID=passenger.FlightID,
            });
            _passangerService.AddPassanger(passToAdd);
        }

        // PUT api/<PassangerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] PassangerPostPutModel passenger)
        {
            var passToUpdate = (new Passanger
            {
                Name = passenger.Name,
                IdNum = passenger.IdNum,
                Adress = passenger.Adress,
                Phone = passenger.Phone,
                FlightID = passenger.FlightID,
            });
            _passangerService.UpdatePassanger(id, passToUpdate);
        }

        // DELETE api/<PassangerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _passangerService.DeletePassanger(id);
        }
    }
}
