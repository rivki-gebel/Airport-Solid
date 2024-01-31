using AirPort_API.Entities;
using Solid.Core.Repositories;
using Solid.Core.Services;
using Solid.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Services
{
    public class FlightService : IFlightService
    {
        private readonly IFlightRepository _flightRepository;
        public FlightService(IFlightRepository flightRepository)
        {
            _flightRepository=flightRepository;
        }
        public void AddFlight(Flight flight)
        {
            _flightRepository.AddFlight(flight);
        }

        public void DeleteFlight(int id)
        {
            _flightRepository.DeleteFlight(id);
        }

        public Flight GetFlightById(int id)
        {
           return _flightRepository.GetFlightById(id);
        }

        public IEnumerable<Flight> GetFlights()
        {
            return _flightRepository.GetFlights();
        }

        public void UpdateFlightCost(int id, double cost)
        {
            _flightRepository.UpdateFlightCost(id, cost);
        }
    }
}
