using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirPort_API.Entities
{
    public class Passanger
    {
        [Key] public int IdPassanger { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string IdNum { get; set; }
        public int Phone { get; set; }
        public int FlightID { get; set; }
        public Flight Flight { get; set; }
    }
}
