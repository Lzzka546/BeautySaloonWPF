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
   public static class UsersController
    {
        /// <summary>
        /// Авторизация пользователя
        /// </summary>
        /// <param name="login">
        /// Логин пользователя
        /// </param>
        /// <param name="password">
        /// Пароль пользователя
        /// </param>
        /// <returns>
        /// Аунтификация пользователя
        /// </returns>
        public static bool Auth(string login,string password)

        {

            using (HttpClient client = new HttpClient())
            {
                string strQuery = $"{Manager.RootUrl}Users/{login}/{password}";
                Console.WriteLine(strQuery);
                HttpResponseMessage response = client.GetAsync(strQuery).Result;
               
                return response.IsSuccessStatusCode;

            }

        }
        /// <summary>
        /// Регистрация пользователя
        /// </summary>
        /// <param name="user">
        /// На вход приходят данные пользователя
        /// </param>
        /// <returns>
        /// Регистрация пользователя
        /// </returns>
        public static bool AddUser(Users user)

        {
          
                string jsonStr=JsonConvert.SerializeObject(user);
                var buffer=System.Text.Encoding.UTF8.GetBytes(jsonStr);
                var byteContent=new ByteArrayContent(buffer);
                byteContent.Headers.ContentType= new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                using(HttpClient client =new HttpClient())
                    {
                string strQuery = $"{Manager.RootUrl}Users";
                HttpResponseMessage response=client.PostAsync(strQuery, byteContent).Result;
                    return response.IsSuccessStatusCode;
                        }

            

        }
    }
}
