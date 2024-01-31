using AirPort_API.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Dto_s
{
    public class FlightDto
    {
        public int FlightId { get; set; }
        public string Destination { get; set; }
        public string SourceLand { get; set; }
        public double Cost { get; set; }
        public DateTime TakeingOffTime { get; set; }
        public int AirplaneID { get; set; }
    }
}
