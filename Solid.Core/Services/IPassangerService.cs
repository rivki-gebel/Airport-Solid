using AirPort_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IPassangerService
    {
        IEnumerable<Passanger> GetPassangers();
        Passanger GetPassangerById(int id);
        void UpdatePassanger(int id, Passanger passenger);
        void DeletePassanger(int id);
        void AddPassanger(Passanger passenger);
    }
}
