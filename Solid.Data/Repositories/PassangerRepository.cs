using AirPort_API;
using AirPort_API.Entities;
using Microsoft.EntityFrameworkCore;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class PassangerRepository : IPassangerRepository
    {
        private readonly DataContext _context;

        public PassangerRepository(DataContext context)
        {
            _context = context;
        }
        void IPassangerRepository.AddPassanger(Passanger passanger)
        {
            _context.passangersList.Add(new Passanger {
                IdNum=passanger.IdNum,
                Name = passanger.Name,
                Adress = passanger.Adress,
                FlightID= passanger.FlightID,
                Phone= passanger.Phone,
            });
            _context.SaveChanges();
        }

        void IPassangerRepository.DeletePassanger(int id)
        {
            var pass = _context.passangersList.Find(id);
            _context.passangersList.Remove(pass);
            _context.SaveChanges();
        }

        Passanger IPassangerRepository.GetPassangerById(int id)
        {
            return _context.passangersList.Find(id);
        }

        IEnumerable<Passanger> IPassangerRepository.GetPassangers()
        {
            return _context.passangersList.Include(p=>p.Flight);
        }

        void IPassangerRepository.UpdatePassanger(int id, Passanger passanger)
        {
            var pass = _context.passangersList.Find(id);
            pass.Adress = passanger.Adress;
            pass.Name = passanger.Name;
            pass.IdNum=passanger.IdNum; 
            pass.FlightID = passanger.FlightID;
            pass.Phone=passanger.Phone;
            _context.SaveChanges();
        }
    }
}
