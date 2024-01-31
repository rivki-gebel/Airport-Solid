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
    public class PassangerService:IPassangerService
    {
        private readonly IPassangerRepository _passengerRepository;
        public PassangerService(IPassangerRepository passengerRepository)
        {
            _passengerRepository= passengerRepository;
        }

        public Passanger GetPassangerById(int id)
        {
            return _passengerRepository.GetPassangerById(id);
        }

        public IEnumerable<Passanger> GetPassangers()
        {
            return _passengerRepository.GetPassangers();
        }
    
        void IPassangerService.UpdatePassanger(int id, Passanger passenger)
        {
            _passengerRepository.UpdatePassanger(id, passenger);
        }

        void IPassangerService.DeletePassanger(int id)
        {
            _passengerRepository.DeletePassanger(id);
        }

        void IPassangerService.AddPassanger(Passanger passenger)
        {
            _passengerRepository.AddPassanger(passenger);
        }
    }
}
