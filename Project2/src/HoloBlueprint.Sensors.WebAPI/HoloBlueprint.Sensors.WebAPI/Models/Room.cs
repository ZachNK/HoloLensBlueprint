using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HoloBlueprint.Sensors.WebAPI.Models
{
    public class Room
    {
        public string Number { get; set; }
        public int Temperature { get; set; }
        public bool IsSmoke { get; set; }
        public bool IsFire { get; set; }
    }
}