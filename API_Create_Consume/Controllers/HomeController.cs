using API_Create_Consume.Models;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace API_Create_Consume.Controllers
{
    public class HomeController : Controller
{
public async Task<IActionResult> Index()
        {
            
            List<Reservation> resertionList = new List<Reservation>();
            using var httpClient = new HttpClient();

            using var response = await httpClient.GetAsync("https://localhost:44331/api/Reservation");

            string apiResponse = await response.Content.ReadAsStringAsync();

            resertionList = JsonConvert.DeserializeObject<List<Reservation>>(apiResponse);


            return View(resertionList);
        }

        //public ViewResult GetReservation() => View();

        //[HttpPost]
        public async Task<IActionResult> GetReservation(int id)
        {
            Reservation reservation = new Reservation();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44331/api/Reservation/" + id))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        reservation = JsonConvert.DeserializeObject<Reservation>(apiResponse);
                    }
                    else
                        ViewBag.StatusCode = response.StatusCode;
                }
            }
            return View(reservation);
        }



        public ViewResult AddReservation() => View();

        [HttpPost]
        public async Task<IActionResult> AddReservation_BacckUp(Reservation reservation)
        {
            Reservation receivedReservation = new Reservation();
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(reservation), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("https://localhost:44331/api/Reservation", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    receivedReservation = JsonConvert.DeserializeObject<Reservation>(apiResponse);
               
                }
            }


            // Below method is an alternate for post  

            //using(var client= new HttpClient())
            //{
            //    client.BaseAddress = new Uri("https://localhost:44331/api/Reservation");
            //    var postTask = client.PostAsJsonAsync<Reservation>("Reservation", reservation);
            //    postTask.Wait();

            //    var result = postTask.Result;
            //    if (result.IsSuccessStatusCode)
            //    {
            //        return RedirectToAction("Index");
            //    }
            //}
            return View(receivedReservation);
        }


        //Secure Api
        [HttpPost]
        public async Task<IActionResult> AddReservation(Reservation reservation)
        {
            Reservation receivedReservation = new Reservation();
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("key", "Secret@123");

                StringContent content = new StringContent(JsonConvert.SerializeObject(reservation), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("https://localhost:44331/api/Reservation", content))
                {

                    string apiResponse = await response.Content.ReadAsStringAsync();
                    if(response.StatusCode==System.Net.HttpStatusCode.OK)
                    {

                        receivedReservation = JsonConvert.DeserializeObject<Reservation>(apiResponse);
                    }
                    else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        ViewBag.Result = apiResponse;
                        return View();
                    }

                }
            }


            return View(receivedReservation);
        }


        public async Task<IActionResult> UpdateReservation(int id)
           {
            Reservation reservation = new Reservation();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44331/api/Reservation/" + id))
                {
                    if(response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        reservation = JsonConvert.DeserializeObject<Reservation>(apiResponse);

                    }

                }
            }
            return View(reservation);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateReservation(Reservation reservation)
        {
            Reservation receivedReservation = new Reservation();
            using (var httpClient = new HttpClient())
            {
                var content = new MultipartFormDataContent();
                content.Add(new StringContent(reservation.Id.ToString()), "Id");
                content.Add(new StringContent(reservation.Name), "Name");
                content.Add(new StringContent(reservation.StartLocation), "StartLocation");
                content.Add(new StringContent(reservation.EndLocation), "EndLocation");

                using (var response = await httpClient.PutAsync("https://localhost:44331/api/Reservation", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ViewBag.Result = "Success";
                    receivedReservation = JsonConvert.DeserializeObject<Reservation>(apiResponse);
                }
            }
            return View(receivedReservation);
        }


        public async Task<IActionResult> UpdateReservationPatch(int id)
        {
            Reservation reservation = new Reservation();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44331/api/Reservation/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    reservation = JsonConvert.DeserializeObject<Reservation>(apiResponse);
                }
            }
            return View(reservation);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateReservationPatch(int id, Reservation reservation)
        {
            using (var httpClient = new HttpClient())
            {
                var request = new HttpRequestMessage
                {
                    RequestUri = new Uri("https://localhost:44331/api/Reservation/" + id),
                    Method = new HttpMethod("Patch"),
                    Content = new StringContent("[{ \"op\": \"replace\", \"path\": \"Name\", \"value\": \"" + reservation.Name + "\"},{ \"op\": \"replace\", \"path\": \"StartLocation\", \"value\": \"" + reservation.StartLocation + "\"}]", Encoding.UTF8, "application/json")
                };

                var response = await httpClient.SendAsync(request);
            }
            return RedirectToAction("Index");
        }


        [HttpPost]
        public async Task<IActionResult> DeleteReservation(int ReservationId)
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("https://localhost:44331/api/Reservation/" + ReservationId))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }

            return RedirectToAction("Index");
        }


        public ViewResult AddFile() => View();

        [HttpPost]
        public async Task<IActionResult> AddFile(IFormFile file)
        {
            string apiResponse = "";
            using (var httpClient = new HttpClient())
            {
                var form = new MultipartFormDataContent();
                using (var fileStream = file.OpenReadStream())
                {
                    form.Add(new StreamContent(fileStream), "file", file.FileName);
                    using (var response = await httpClient.PostAsync("https://localhost:44331/api/Reservation/UploadFile", form))
                    {
                        response.EnsureSuccessStatusCode();
                        apiResponse = await response.Content.ReadAsStringAsync();
                    }
                }
            }
            return View((object)apiResponse);
        }

        public ViewResult AddReservationByXml() => View();

        [HttpPost]
        public async Task<IActionResult> AddReservationByXml(Reservation reservation)
        {
            Reservation receivedReservation = new Reservation();

            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(ConvertObjectToXMLString(reservation), Encoding.UTF8, "application/xml");

                using (var response = await httpClient.PostAsync("https://localhost:44324/api/Reservation/PostXml", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    receivedReservation = JsonConvert.DeserializeObject<Reservation>(apiResponse);
                }
            }
            return View(receivedReservation);
        }

        string ConvertObjectToXMLString(object classObject)
        {
            string xmlString = null;
            XmlSerializer xmlSerializer = new XmlSerializer(classObject.GetType());
            using (MemoryStream memoryStream = new MemoryStream())
            {
                xmlSerializer.Serialize(memoryStream, classObject);
                memoryStream.Position = 0;
                xmlString = new StreamReader(memoryStream).ReadToEnd();
            }
            return xmlString;
        }
    }
}
