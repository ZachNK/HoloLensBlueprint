using HoloBlueprint.Sensors.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HoloBlueprint.Sensors.WebAPI.Controllers
{
    public class BuildingsController : ApiController
    {
        Building[] buildings;

        public IEnumerable<Building> GetAllBuildings()
        {
            LoadBuildingsData();
            return buildings;
        }

        public IHttpActionResult GetBuilding(string id)
        {
            LoadBuildingsData();

            var building = buildings.FirstOrDefault((b) => b.Id == id);
            if(building == null)
            {
                return NotFound();
            }

            return (Ok(building));
        }

        private void LoadBuildingsData()
        {
            Room b1w1f1r1 = new Room { IsFire = false, IsSmoke = false, Number = "B1-W1-101", Temperature = 24 };
            Room b1w1f1r2 = new Room { IsFire = false, IsSmoke = false, Number = "B1-W1-102", Temperature = 24 };
            Room b1w1f2r1 = new Room { IsFire = false, IsSmoke = false, Number = "B1-W1-201", Temperature = 24 };
            Room b1w1f2r2 = new Room { IsFire = false, IsSmoke = true, Number = "B1-W1-202", Temperature = 24 };
            Room b1w1f3r1 = new Room { IsFire = false, IsSmoke = false, Number = "B1-W1-301", Temperature = 24 };
            Room b1w1f3r2 = new Room { IsFire = false, IsSmoke = false, Number = "B1-W1-302", Temperature = 24 };

            Floor b1w1f1 = new Floor { Number = "B1-W1-F1" };
            b1w1f1.Rooms = new List<Room>();
            b1w1f1.Rooms.Add(b1w1f1r1);
            b1w1f1.Rooms.Add(b1w1f1r2);

            Floor b1w1f2 = new Floor { Number = "B1-W1-F2" };
            b1w1f2.Rooms = new List<Room>();
            b1w1f2.Rooms.Add(b1w1f2r1);
            b1w1f2.Rooms.Add(b1w1f2r2);

            Floor b1w1f3 = new Floor { Number = "B1-W1-F3" };
            b1w1f3.Rooms = new List<Room>();
            b1w1f3.Rooms.Add(b1w1f3r1);
            b1w1f3.Rooms.Add(b1w1f3r2);

            Wing b1w1 = new Wing { Name = "B1-W1" };
            b1w1.Floors = new List<Floor>();
            b1w1.Floors.Add(b1w1f1);
            b1w1.Floors.Add(b1w1f2);
            b1w1.Floors.Add(b1w1f3);

            Room b1w2f1r1 = new Room { IsFire = false, IsSmoke = false, Number = "B1-W2-101", Temperature = 24 };
            Room b1w2f1r2 = new Room { IsFire = false, IsSmoke = false, Number = "B1-W2-102", Temperature = 24 };
            Room b1w2f2r1 = new Room { IsFire = false, IsSmoke = false, Number = "B1-W2-201", Temperature = 32 };
            Room b1w2f2r2 = new Room { IsFire = false, IsSmoke = false, Number = "B1-W2-202", Temperature = 24 };

            Floor b1w2f1 = new Floor { Number = "B1-W2-F1" };
            b1w2f1.Rooms = new List<Room>();
            b1w2f1.Rooms.Add(b1w2f1r1);
            b1w2f1.Rooms.Add(b1w2f1r2);

            Floor b1w2f2 = new Floor { Number = "B1-W2-F2" };
            b1w2f2.Rooms = new List<Room>();
            b1w2f2.Rooms.Add(b1w2f2r1);
            b1w2f2.Rooms.Add(b1w2f2r2);

            Wing b1w2 = new Wing { Name = "B1-W2" };
            b1w2.Floors = new List<Floor>();
            b1w2.Floors.Add(b1w2f1);
            b1w2.Floors.Add(b1w2f2);

            Building building = new Building { Id = "12345", Address = "1123, Hitech City, Hyderabad, India - 500032", Name = "XyZ Inc." };
            building.Wings = new List<Wing>();
            building.Wings.Add(b1w1);
            building.Wings.Add(b1w2);

            buildings = new Building[1];
            buildings[0] = building;
        }
    }
}
