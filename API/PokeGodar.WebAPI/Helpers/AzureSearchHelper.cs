using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System.Configuration;
using System.Net.Http;

namespace PokeGodar.WebAPI.Helpers
{
    public class AzureSearchHelper
    {
        public const string ApiVersionString = "api-version=2015-02-28";

        /// <summary>
        /// The API Version used with Azure Search Service.
        /// </summary>

        private static readonly JsonSerializerSettings _jsonSettings;

        static AzureSearchHelper()
        {
            _jsonSettings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented, // for readability, change to None for compactness
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                DateTimeZoneHandling = DateTimeZoneHandling.Utc
            };

            _jsonSettings.Converters.Add(new StringEnumConverter());
        }

        public static string SerializeJson(object value)
        {
            return JsonConvert.SerializeObject(value, _jsonSettings);
        }

        public static T DeserializeJson<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json, _jsonSettings);
        }

        public static HttpResponseMessage SendSearchRequest(HttpClient client, HttpMethod method, Uri uri, string json = null)
        {
            UriBuilder builder = new UriBuilder(uri);
            string separator = string.IsNullOrWhiteSpace(builder.Query) ? string.Empty : "&";
            builder.Query = builder.Query.TrimStart('?') + separator + ApiVersionString;

            var request = new HttpRequestMessage(method, builder.Uri);

            if (json != null)
            {
                request.Content = new StringContent(json, Encoding.UTF8, "application/json");
            }

            return client.SendAsync(request).Result;
        }

        public static void EnsureSuccessfulSearchResponse(HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                string error = response.Content == null ? null : response.Content.ReadAsStringAsync().Result;
                throw new Exception("Search request failed: " + error);
            }
        }
    }
}
