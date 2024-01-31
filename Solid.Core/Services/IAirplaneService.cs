using AirPort_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IAirplaneService
    {
        IEnumerable<AirPlane> GetAirplanes();
        AirPlane GetAirPlaneById(int id);
        AirPlane UpdateAirplaneProperty(int id, bool isProper);
        void DeleteAirplane(int id);
        AirPlane AddAirplane(AirPlane airPlane);
    }
}
