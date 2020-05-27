using System;
using System.Diagnostics;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestSharp;
using System.IO;
using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Routing;

namespace Vehicles.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehiclesController : ControllerBase
    {

        /*[HttpGet]
        
        public ActionResult<string> Get()
        {
            string p = @"https://drive.google.com/file/d/1wlAcggVsyPIZYP2MGOS7IUpAnLsmEtKF/view?usp=sharing";
            StreamReader x = new StreamReader(p);
            string d = "";
            while (true)
            {
                string z = x.ReadLine();

                if (String.IsNullOrEmpty(z))
                {
                    break;
                }
                d+=z+"\n";
            
                
            }
            return d;
        }*/

        [HttpGet("{id}")]
        public ActionResult<string> Get(string id)//
        {

            //Veh veh = new Veh();
            //Vehinfo vehinfo = new Vehinfo();
            //veh=vehinfo.GetVehs<Veh>(id);
            var client = new RestClient("https://vindecoder.p.rapidapi.com/decode_vin?vin=" + id);
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "vindecoder.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "f062bf2c6amsh4aa50361666f2dap198188jsna5efd2466b49");
            //request.AddHeader("x-rapidapi-vin", );
            IRestResponse response = client.Execute(request);// RequestBody
                                                             //return (response);
            /* string res = Convert.ToString(response.Content);
             Veh.specification spec = JsonConvert.DeserializeObject<Veh.specification>(response.Content);

             //Veh.specification specification = veh.;//new Veh.specification();
             //specification.make=
             //veh=veh.GetVeh<Veh>();
             //specification = veh.specification;

             if (spec.make == null) return "404";
             return "2" + spec.make + "1";*/
            string j = response.Content;
            return j;
        }
        [HttpGet("{id}")]
        [Route("model/{id}")]
         public ActionResult<string> Getmodel(string id)
         {

             //Veh veh = new Veh();
             //Vehinfo vehinfo = new Vehinfo();
              //veh=vehinfo.GetVehs<Veh>(id);
             var client = new RestClient("https://vindecoder.p.rapidapi.com/decode_vin?vin="+id);
             var request = new RestRequest(Method.GET);
             request.AddHeader("x-rapidapi-host", "vindecoder.p.rapidapi.com");
             request.AddHeader("x-rapidapi-key", "f062bf2c6amsh4aa50361666f2dap198188jsna5efd2466b49");
             //request.AddHeader("x-rapidapi-vin", );
             IRestResponse response = client.Execute(request);// RequestBody
                                                              //return (response);
             /*string res = Convert.ToString(response.Content);
            Veh2 spec = JsonConvert.DeserializeObject<Veh2>(response.Content);*/
            /* Veh veh = JsonConvert.DeserializeObject<Veh>(response.Content);
            string json = JsonConvert.SerializeObject<Veh.specification>(veh.specification);
            specification1 spec = JsonConvert.DeserializeObject<specification1>(json);*/
            //Veh.specification specification = veh.;//new Veh.specification();
            //specification.make=
            //veh=veh.GetVeh<Veh>();
            //specification = veh.specification;

            //if ( spec.make== null) return "404"; 
            string s = "model";
            string j = response.Content;
            string make = j.Remove(0, j.IndexOf(s) + s.Length+3);
            return make.Substring(0,make.IndexOf("\""));
         }
        [HttpGet("{id}")]
        [Route("style/{id}")]
        public ActionResult<string> Getstyle(string id)
        {
            var client = new RestClient("https://vindecoder.p.rapidapi.com/decode_vin?vin=" + id);
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "vindecoder.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "f062bf2c6amsh4aa50361666f2dap198188jsna5efd2466b49");
            IRestResponse response = client.Execute(request);
            string s = "style";
            string j = response.Content;
            string make = j.Remove(0, j.IndexOf(s) + s.Length + 3);
            return make.Substring(0, make.IndexOf("\""));
        }
        [HttpGet("{id}")]
        [Route("make/{id}")]
        public ActionResult<string> Getmake(string id)
        {
            var client = new RestClient("https://vindecoder.p.rapidapi.com/decode_vin?vin=" + id);
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "vindecoder.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "f062bf2c6amsh4aa50361666f2dap198188jsna5efd2466b49");
            IRestResponse response = client.Execute(request);
            string s = "make";
            string j = response.Content;
            string make = j.Remove(0, j.IndexOf(s) + s.Length + 3);
            return make.Substring(0, make.IndexOf("\""));
        }
        [HttpGet("{id}")]
        [Route("year/{id}")]
        public ActionResult<string> Getyear(string id)
        {
            var client = new RestClient("https://vindecoder.p.rapidapi.com/decode_vin?vin=" + id);
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "vindecoder.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "f062bf2c6amsh4aa50361666f2dap198188jsna5efd2466b49");
            IRestResponse response = client.Execute(request);
            string s = "year";
            string j = response.Content;
            string make = j.Remove(0, j.IndexOf(s) + s.Length + 3);
            return make.Substring(0, make.IndexOf("\""));
        }
        [HttpGet("{id}")]
        [Route("made_in/{id}")]
        public ActionResult<string> Getmade_in(string id)
        {
            var client = new RestClient("https://vindecoder.p.rapidapi.com/decode_vin?vin=" + id);
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "vindecoder.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "f062bf2c6amsh4aa50361666f2dap198188jsna5efd2466b49");
            IRestResponse response = client.Execute(request);
            string s = "made_in";
            string j = response.Content;
            string make = j.Remove(0, j.IndexOf(s) + s.Length + 3);
            return make.Substring(0, make.IndexOf("\""));
        }
        /*[HttpPost("{id}")]
        public StatusCodeResult Post(string id)
        {
            string p = @"https://drive.google.com/file/d/1wlAcggVsyPIZYP2MGOS7IUpAnLsmEtKF/view?usp=sharing";
            StreamWriter x = new StreamWriter(p);
            x.WriteLine(id);
            x.Close();
            return Ok();
        }*/
       
    }
}
