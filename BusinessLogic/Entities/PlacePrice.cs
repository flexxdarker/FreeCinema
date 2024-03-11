﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Entities
{
    public class PlacePrice
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public bool isReserved { get; set; }
        public int SessionId { get; set; }
        public Session? Session { get; set; }
        public int PlaceId { get; set; }
        public Place? Place { get; set; }
    }
}
