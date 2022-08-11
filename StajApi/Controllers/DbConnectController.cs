using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Data;
using Npgsql;
using EFCoreTutorial.Data.Context;
using EFCoreTutorial.Data.Models;
using Microsoft.AspNetCore.Cors;

namespace StajApi.Controllers
{
     [Route("api/[controller]")]
     [ApiController]

   
    public class DbConnectController : Controller
    {
        private readonly ApplicationDbContext context;
        public DbConnectController(ApplicationDbContext context)
        {
            this.context = context;
        }

        //private static List<Location> _Locations = new List<Location>();


        //NpgsqlConnection baglanti = new NpgsqlConnection("Server=localHost; Port=5432; Database=Dbstaj;  User Id=postgres; Password=1016");

        //private const string TABLE_NAME = "location";
        [EnableCors("_myAllowSpecificOrigins")]
        [HttpGet]
        public IActionResult GetAll()
        {
            var location = context.Locations.Select(u => new LocationView
            {
                Id = u.Id,
                Name = u.Name,
                X = u.X,
                Y = u.Y,
            });

            return Ok(location);
        }
       

        [HttpGet("Id")]
        public IActionResult Get(int id)
        {
            var location = this.context.Locations.Find(id);
            if (location == null)
            {
                return BadRequest("location not found");
            }
           return Ok(location);
        }

        [HttpPut]
        public IActionResult Update(Location location)
        {
            var loc = this.context.Locations.Find(location.Id);

            if(loc!=null)
            {
                //updating new values
                loc.Name = location.Name;
                loc.X = location.X;
                loc.Y = location.Y;

                this.context.Update(loc);
                this.context.SaveChanges();
            }
            return  Ok("updated succesfully");

        }

        [HttpDelete]
        
        public IActionResult Delete(int id)
        {
            var location = this.context.Locations.Find(id);
            if(location == null)
            {
                return BadRequest("location not found");
            }
            this.context.Remove(location);
            this.context.SaveChanges();
            return Ok("delete succesfully");
        }

        [EnableCors("_myAllowSpecificOrigins")]
        [HttpPost("Add")]
        public IActionResult Add(LocationView location)
        {
            
            this.context.Locations.Add(location);
            this.context.SaveChanges();
           

            return Ok("added succesfully");    
        }
    }
}
 

