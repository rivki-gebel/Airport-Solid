using AirPort_API.Entities;
using System.ComponentModel.DataAnnotations;

namespace Airport_solidApi.Models
{
    public class PassangerPostPutModel
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public string IdNum { get; set; }
        public int Phone { get; set; }
        public int FlightID { get; set; }
    }
}
