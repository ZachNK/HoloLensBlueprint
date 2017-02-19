using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HoloBlueprint.Sensors.WebAPI.Models
{
    public class Floor
    {
        public string FloorNumber { get; set; }
        public List<Room> Rooms { get; set; }
    }
}