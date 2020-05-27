using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;

namespace Vehicles
{
    /*public class Class
    {
        public int Id { get; set; }
        public string Vin { get; set; }
        public string model { get; set; }
        public string style { get; set; }
        public string make { get; set; }
        public string year { get; set; }
        public string mase_in { get; set; }
    }*/
    /*public class Veh2
    {
        [JsonProperty("succes")]
        public bool succes { get; set; }
        
        [JsonProperty("vin")]
        public string vin { get; set; }
        
        [JsonProperty("year")]
        public string year { get; set; }
        
        [JsonProperty("make")]
        public string make { get; set; }
        
    }*/
        /*public string model { get; set; }
        public string trim_level { get; set; }
        public string engine { get; set; }
        public string style { get; set; }
        public string made_in { get; set; }
        public string steering_type { get; set; }
        public string anti_brake_system { get; set; }
        public string tank_size { get; set; }
        public string overall_height { get; set; }
        public string overall_length { get; set; }
        public string overall_width { get; set; }
        public string standard_seating { get; set; }
        public string optional_seating { get; set; }
        public string highway_mileage { get; set; }
        public string city_mileage { get; set; }*/
    
        //public string vin { get; set; }
    
    public class specification1 
        { 
        public string vin{ get; set; }
        public string year{ get; set; }
        public string make{ get; set; }
        public string model { get; set; }
        public string trim_level { get; set; }
        public string engine { get; set; }
        public string style { get; set; }
        public string made_in { get; set; }
        public string steering_type { get; set; }
        public string anti_brake_system { get; set; }
        public string tank_size { get; set; }
        public string overall_height { get; set; }
        public string overall_length { get; set; }
        public string overall_width { get; set; }
        public string standard_seating { get; set; }
        public string optional_seating { get; set; }
        public string highway_mileage { get; set; }
        public string city_mileage { get; set; }
    }
    /*public class Veh1
    {
        public class Message 
        {
            public string message { get; set; }
        }
        public class data {
            public string year { get; set; }
            public string make { get; set; }
            public string model { get; set; }
            public string manufacturer { get; set; }
            public string engine { get; set; }
            public string trim{ get; set; }
            public string transmission{ get; set; }
}
}*/
    public class Vehinfo 
    { 
        
        public  Veh.specification GetVehs <specification>(string id)
        {
            
                var client = new RestClient("https://vindecoder.p.rapidapi.com/decode_vin?vin=");
                var request = new RestRequest(Method.GET);
                request.AddHeader("x-rapidapi-host", "vindecoder.p.rapidapi.com");
                request.AddHeader("x-rapidapi-key", "f062bf2c6amsh4aa50361666f2dap198188jsna5efd2466b49");
                request.AddHeader("x-rapidapi-vin",id);
                IRestResponse response = client.Execute(request);// RequestBody
                //return (response);
                string res = Convert.ToString(response.Content);
                Veh.specification spec = JsonConvert.DeserializeObject<Veh.specification>(response.Content);
                return spec;
            //Veh veh = JsonConvert.DeserializeObject<Veh>(response.Content);
            //return veh;
        }
        public Veh GetVeh<Veh>(string id)
        {

            var client = new RestClient("https://docs.rapidapi.com/docs/keys?f062bf2c6amsh4aa50361666f2dap198188jsna5efd2466b49=4F2YU09161KM33122");
            var request = new RestRequest(Method.GET);
            /*request.AddHeader("x-rapidapi-host", "vindecoder.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "f062bf2c6amsh4aa50361666f2dap198188jsna5efd2466b49");
            request.AddHeader("x-rapidapi-vin", id);*/
            IRestResponse response = client.Execute(request);// RequestBody
                                                             //return (response);
            string res = Convert.ToString(response.Content);
            Veh veh = JsonConvert.DeserializeObject<Veh>(response.Content);
            return veh;
        }
    }
}
