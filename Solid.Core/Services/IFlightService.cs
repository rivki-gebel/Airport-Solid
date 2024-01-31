using AirPort_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IFlightService
    {
        IEnumerable<Flight> GetFlights();
        Flight GetFlightById(int id);
        void UpdateFlightCost(int id, double cost);
        void DeleteFlight(int id);
        void AddFlight(Flight flight);
    }
}
