using AirPort_API;
using AirPort_API.Entities;
using Solid.Core.Repositories;
namespace Solid.Data.Repositories
{
    public class AirplaneRepository:IAirplaneRepository
    {
        private readonly DataContext _context;

        public AirplaneRepository(DataContext context)
        {
            _context = context;
        }
        IEnumerable<AirPlane> IAirplaneRepository.GetAirplanes()
        {
            return _context.airplaneList;
        }
        AirPlane IAirplaneRepository.GetAirPlaneById(int id)
        {
            return _context.airplaneList.Find(id);
        }
        AirPlane IAirplaneRepository.UpdateAirplaneProperty(int id, bool isProper)
        {
            var plane = _context.airplaneList.Find(id);
            plane.IsProper = isProper;
            _context.SaveChanges();
            return plane;
        }
        void IAirplaneRepository.DeleteAirplane(int id)
        {
            var plane = _context.airplaneList.Find(id);
            _context.airplaneList.Remove(plane);
            _context.SaveChanges();
        }
        AirPlane IAirplaneRepository.AddAirplane(AirPlane airPlane)
        {
            _context.airplaneList.Add(new AirPlane
            {
                //AirplaneId = airPlane.AirplaneId,
                Company = airPlane.Company,
                NumSeats = airPlane.NumSeats,
                IsProper = airPlane.IsProper
            });
            _context.SaveChanges();
            return airPlane;
        }

    }
}
