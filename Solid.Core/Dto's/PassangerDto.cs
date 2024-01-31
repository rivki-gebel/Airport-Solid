using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Dto_s
{
    public class PassangerDto
    {
        public int IdPassanger { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string IdNum { get; set; }
        public int Phone { get; set; }
        public FlightToPassangerDto Flight { get; set; }
    }
}
