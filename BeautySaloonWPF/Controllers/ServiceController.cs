using BeautySaloonWPF.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BeautySaloonWPF.Controllers
{
    public class ServiceController

    {
        /// <summary>
        /// вывод сервисов
        /// </summary>
        /// <returns></returns>
        public static List<Services> GetServices()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync($"{Manager.RootUrl}Services").Result;
                var content = response.Content.ReadAsStringAsync();
                var answer = JsonConvert.DeserializeObject<List<Services>>(content.Result);
                return answer;
            }
        
        }

    }
       
}
