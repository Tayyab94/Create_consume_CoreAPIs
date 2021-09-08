using API_Create_Consume.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace API_Create_Consume.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservationController : ControllerBase
    {
        private IRepository repository;
        private IWebHostEnvironment webHostEnvironment;
        public ReservationController(IRepository repo, IWebHostEnvironment webHost)
        {
            this.repository = repo;
            this.webHostEnvironment = webHost;

        }

     
        [HttpGet]
        public IEnumerable<Reservation> Get() => repository.Reservations;

        [HttpGet("{id}")]
        public ActionResult<Reservation> Get(int id)
        {
            if(id==0)
            {
                return BadRequest("value must be pass in the request body");

            }


            return Ok(repository[id]);
        }

        // [HttpPost]
        // public Reservation Post([FromBody] Reservation res) =>
        //  repository.AddReservation(new Reservation
        //{
        //    Name = res.Name,
        //    StartLocation = res.StartLocation,
        //    EndLocation = res.EndLocation
        //});

        // We can Secure Our Api by Passing Secet key
        [HttpPost]
        public IActionResult Post([FromBody] Reservation res)
        {
            if (!Authenticate())
                return Unauthorized();
            return Ok(repository.AddReservation(new Reservation
            {
                Name = res.Name,
                StartLocation = res.StartLocation,
                EndLocation = res.EndLocation
            }));
        }

        [HttpPut]
        public Reservation Put([FromBody] Reservation res) => repository.UpdateReservation(res);

        [HttpPatch("{id}")]
        public StatusCodeResult Patch(int id, [FromBody] JsonPatchDocument<Reservation> patch)
        {
            var res = (Reservation)((OkObjectResult)Get(id).Result).Value;
            if (res != null)
            {
                patch.ApplyTo(res);
                return Ok();
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public void Delete(int id) => repository.DeleteReservation(id);



        // If you want Secure your Api
        bool Authenticate()
        {
            var allowedKeys = new[] { "Secret@123", "Secret#12", "SecretABC" };
            StringValues key = Request.Headers["Key"];
            int count = (from t in allowedKeys where t == key select t).Count();
            return count == 0 ? false : true;
        }

        [HttpPost("UploadFile")]
        public async Task<string> UploadFile([FromForm] IFormFile file)
        {
            string path = Path.Combine(webHostEnvironment.WebRootPath, "Images/" + file.FileName);
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            var url =Convert.ToString(UriHelper.GetEncodedUrl(HttpContext.Request)).Split('/');
            return $"{url[0]}/Images/" + file.FileName;
        }


        [HttpPost("PostXml")]
        [Consumes("application/xml")]
        public Reservation PostXml([FromBody] System.Xml.Linq.XElement res)
        {
            return repository.AddReservation(new Reservation
            {
                Name = res.Element("Name").Value,
                StartLocation = res.Element("StartLocation").Value,
                EndLocation = res.Element("EndLocation").Value
            });
        }
    }
}
