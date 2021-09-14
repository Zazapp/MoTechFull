using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoTechFull.Model;

namespace MoTechFull.WinUI
{
    public class APIService
    {
        private string _route = null;
        public APIService(string route) { _route = route; }

        public static string Username { get; set; }
        public static string Password { get; set; }
        public async Task<T> Get<T>(object request = null)
        {
            var url = $"{Properties.Settings.Default.ApiURL}{_route}";
            if (request != null)
            {
                url += "?";
                url += await request.ToQueryString();
            }

            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            return result;
        }

        public async Task<T> GetById<T>(object id)
        {
            var url = $"{Properties.Settings.Default.ApiURL}{_route}/{id}";
            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            return result;
        }

        public async Task<T> Recommend<T>(object id)
        {
            var url = $"{Properties.Settings.Default.ApiURL}{_route}/Recommend/{id}";
            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            return result;
        }

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{Properties.Settings.Default.ApiURL}{_route}";
            var result = await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
            return result;
        }

        public async Task<T> Update<T>(object id, object request)
        {
            var url = $"{Properties.Settings.Default.ApiURL}{_route}/{id}";
            var result = await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
            return result;
        }
    }

}
