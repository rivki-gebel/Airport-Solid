using AirPort_API.Entities;
using AirPort_API;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Solid.Data.Repositories
{
    public class FlightRepository : IFlightRepository
    {
        private readonly DataContext _context;

        public FlightRepository(DataContext context)
        {
            _context = context;
        }

        void IFlightRepository.AddFlight(Flight flight)
        {
            _context.flightsList.Add(new Flight
            {
                Destination = flight.Destination,
                SourceLand = flight.SourceLand,
                AirplaneID = flight.AirplaneID,
                Cost = flight.Cost,
                TakeingOffTime = flight.TakeingOffTime
            });
            _context.SaveChanges();
        }
        void IFlightRepository.DeleteFlight(int id)
        {
            var flight = _context.flightsList.Find(id);
            _context.flightsList.Remove(flight);
            _context.SaveChanges();
        }

        Flight IFlightRepository.GetFlightById(int id)
        {
            return _context.flightsList.Find(id);
        }

        IEnumerable<Flight> IFlightRepository.GetFlights()
        {
            return _context.flightsList.Include(f => f.Airplane).Include(f=>f.Passengers);
        }

        void IFlightRepository.UpdateFlightCost(int id, double cost)
        {
            var flight = _context.flightsList.Find(id);
            flight.Cost = cost;
            _context.SaveChanges();
        }
    }
}
