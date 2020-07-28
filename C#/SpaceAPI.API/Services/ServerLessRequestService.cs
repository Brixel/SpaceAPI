using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace SpaceAPI.Host.Services
{
    public class ServerLessRequestService : IServerLessRequestService
    {
        private static HttpClient _httpClient;
        private readonly ServerLessOptions _serverLessOptions;


        public ServerLessRequestService(IOptions<ServerLessOptions> options)
        {
            _serverLessOptions = options.Value ?? throw new ArgumentNullException(nameof(ServerLessOptions));

            var baseAddress = _serverLessOptions.FunctionBaseUri;
            _httpClient = new HttpClient {BaseAddress = new Uri(baseAddress)};
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 |
                                                   SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            //ServicePointManager.ServerCertificateValidationCallback = (sender, cert, chain, sslPolicyErrors) => true;
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task SpaceStateChanged(bool isOpen)
        {
            var spaceStateChangedUri = _serverLessOptions.SpaceStateChangedUri;
            var spaceStateChanged = new SpaceStateChanged()
            {
                IsOpen = isOpen
            };
            string textMessage = JsonConvert.SerializeObject(spaceStateChanged);
            var httpContent = new StringContent(textMessage, Encoding.UTF8, "application/json");
            await _httpClient.PostAsync(spaceStateChangedUri, httpContent);
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