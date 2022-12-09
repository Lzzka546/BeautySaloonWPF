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
   public class ServiceCategoryesController
    {
        /// <summary>
        /// Вывод всех категорий
        /// </summary>
        /// <returns></returns>
        public static List<ServiceCategoryes> GetServiceCategoryes()

        {

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync($"{Manager.RootUrl}ServiceCategoryes").Result;
                var content = response.Content.ReadAsStringAsync();
                var answer = JsonConvert.DeserializeObject<List<ServiceCategoryes>>(content.Result);
                return answer;

            }
        }
        public static List<ServiceCategoryes> GetInfoCategory(int idCategory)

        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync($"{Manager.RootUrl}ServiceCategoryes/{idCategory}").Result;
                var content = response.Content.ReadAsStringAsync();
                var answer = JsonConvert.DeserializeObject<List<ServiceCategoryes>>(content.Result);
                return answer;

            }
        }
    }
}
