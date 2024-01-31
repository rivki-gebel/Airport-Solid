using AirPort_API.Entities;
using Solid.Core.Repositories;
using Solid.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Services
{
    public class AirplaneService : IAirplaneService
    {
        private readonly IAirplaneRepository _airplaneRepository;

        public AirplaneService(IAirplaneRepository airplaneRepository)
        {
            _airplaneRepository = airplaneRepository;
        }

        public void DeleteAirplane(int id)
        {
            _airplaneRepository.DeleteAirplane(id);
        }

        AirPlane IAirplaneService.AddAirplane(AirPlane airPlane)
        {
             return  _airplaneRepository.AddAirplane(airPlane);
        }

        AirPlane IAirplaneService.GetAirPlaneById(int id)
        {
            return _airplaneRepository.GetAirPlaneById(id);
        }

        IEnumerable<AirPlane> IAirplaneService.GetAirplanes()
        {
            return _airplaneRepository.GetAirplanes();
        }

        AirPlane IAirplaneService.UpdateAirplaneProperty(int id, bool isProper)
        {
            return _airplaneRepository.UpdateAirplaneProperty(id, isProper);
        }
    }
}
