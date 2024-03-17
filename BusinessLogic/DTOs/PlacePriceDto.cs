using BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs
{
    public class PlacePriceDto
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public bool isReserved { get; set; }
        public int SessionId { get; set; }
        public string? SessionName { get; set; }
        public int PlaceId { get; set; }
        public string? PlaceNumber { get; set; }
    }
}
