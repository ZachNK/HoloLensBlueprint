using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HoloBlueprint.Sensors.WebAPI.Models
{
    public class Wing
    {
        public string WingName { get; set; }
        public List<Floor> Floors { get; set; }
    }
}