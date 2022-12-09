using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySaloonWPF.Models
{
    public class ServiceCategoryes
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }


        [JsonProperty("cost")]
        public float Cost { get; set; } 
        

        [JsonProperty("durationInSeconds")]
        public int DurationInSeconds { get; set; } 


        [JsonProperty("description")]
         public string Description { get; set; }

        [JsonProperty("discount")]
        public float Discount { get; set; }

        [JsonProperty("mainImagePath")]
        public string MainImagePath { get; set; }

        [JsonProperty("categoryId")]
        public int CategoryId { get; set; }

        [JsonProperty("category")]
        public object Category { get; set; }

        [JsonProperty("clientServices")]
        public object[] ClientServices { get; set; }

        [JsonProperty("servicePhotos")]
        public object[] ServicePhotos { get; set; }




        //[JsonProperty("categoryId")]
        //    public int CategoryId { get; set; }
        //[JsonProperty("categoryTitle")]
        //public string CategoryTitle { get; set; }
        //[JsonProperty("categoryImage")]
        //public byte[] CategoryImage { get; set; }


    }
}
