using Microsoft.AspNetCore.Mvc;
using Trips.Data.Contracts;
using Trips.Data.Models;

namespace Trips.Controllers{
    [Route("/api/[controller]")]
    public class TripsController : Controller{
        private readonly ITripService service;

        public TripsController(ITripService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult GetTrips(){
            return Ok(this.service.GetAllTrips());
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteTrip(int id){
            this.service.DeleteTrip(id);
            return Ok("trip has been deleted");
        }

        [HttpPost]
        public IActionResult CreateTrip([FromBody]Trip trip){
            if(trip == null){
                return BadRequest("No valid data provided, trip could not been created");
            }
            Console.WriteLine("Trying to create trip");
            this.service.CreateTrip(trip);
            return Ok("new trip has been created");
        }

        [HttpPut("update/{id}")]
        public IActionResult UpdateTrip(int id, [FromBody]Trip trip){
            this.service.UpdateTrip(id, trip);
            return Ok("Trip has been updated successfully");
        }
    }
}