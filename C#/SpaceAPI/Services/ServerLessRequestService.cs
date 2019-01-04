using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;

namespace SpaceAPI.Services
{
    public class ServerLessRequestService : IServerLessRequestService
    {
        private static HttpClient httpClient = new HttpClient();
        

        public ServerLessRequestService()
        {
            var baseAddress =ConfigurationManager.AppSettings.Get("FunctionBaseUri");
            httpClient.BaseAddress = new Uri(baseAddress);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task SpaceStateChanged(bool isOpen)
        {
            var spaceStateChangedUri = ConfigurationManager.AppSettings.Get("SpaceStateChangedUri");
            var spaceStateChanged = new SpaceStateChanged()
            {
                IsOpen = isOpen
            };
            string textMessage = JsonConvert.SerializeObject(spaceStateChanged);
            var httpContent = new StringContent(textMessage, Encoding.UTF8, "application/json");
            try
            {
                await httpClient.PostAsync(spaceStateChangedUri, httpContent);
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }

    public class SpaceStateChanged
    {
        public bool IsOpen { get; set; }
    }

    public interface IServerLessRequestService
    {
        Task SpaceStateChanged(bool isOpen);
    }
}