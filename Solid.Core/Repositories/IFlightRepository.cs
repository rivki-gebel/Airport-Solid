using AirPort_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public interface IFlightRepository
    {
        IEnumerable<Flight> GetFlights();
        Flight GetFlightById(int id);
        void UpdateFlightCost(int id, double cost);
        void DeleteFlight(int id);
        void AddFlight(Flight flight);
    }
}
