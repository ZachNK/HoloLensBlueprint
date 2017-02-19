using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HoloBlueprint.Sensors.WebAPI.Models
{
    public class Building
    {
        public string BuildingName { get; set; }
        public string Id { get; set; }
        public string Address { get; set; }
        public List<Wing> Wings { get; set; }
    }
}