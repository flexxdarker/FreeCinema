﻿using BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs
{
    public class PlaceDto
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int Row { get; set; }
        public int CinemaHallId { get; set; }
        public string? CinemaHallName { get; set; }
        public IEnumerable<PlacePrice>? PlacePrices { get; set; }
    }
}
