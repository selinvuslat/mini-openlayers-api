using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Npgsql;

namespace StajApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private static List<Location> _Locations = new List<Location>();


        [HttpGet]
        public List<Location> GetAll()
        {
            return _Locations;
        }

        [HttpGet("{id}")]
        public Location Get(int id)
        {
            var location = _Locations.FirstOrDefault(x => x.Id == id);  
            return location;    
        }


        [HttpPost]
        public Location Add(Location _location)
        {
            _location.Id = new Random().Next();
            _Locations.Add(_location);
            return _location;
                                                                      
        }
        

        [HttpPut]
        public Location Put([FromBody] Location location)
        {
            var editedLocation = _Locations.FirstOrDefault(x=>x.Id==location.Id);
            editedLocation.Name = location.Name;   
            editedLocation.X = location.X;  
            editedLocation.Y = location.Y;  
            return location;
        }

       [HttpDelete]
        public void Delete(int id)
        {
            var deletedLocation = _Locations.FirstOrDefault(x=>x.Id==id);  
            _Locations.Remove(deletedLocation);
         
        }
    }
}

