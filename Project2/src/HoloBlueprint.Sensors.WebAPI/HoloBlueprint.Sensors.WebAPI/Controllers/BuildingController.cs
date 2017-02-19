using HoloBlueprint.Sensors.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HoloBlueprint.Sensors.WebAPI.Controllers
{
    public class BuildingController : ApiController
    {
        public IHttpActionResult GetBuilding()
        {
            Building building = Data.BuildingCreator.LoadBuildingsData(0);

            if (building == null)
            {
                return NotFound();
            }

            return (Ok(building));
        }

        public IHttpActionResult GetBuilding(int id)
        {
            Building building = Data.BuildingCreator.LoadBuildingsData(id);

            if (building == null)
            {
                return NotFound();
            }

            return (Ok(building));
        }
    }
}
