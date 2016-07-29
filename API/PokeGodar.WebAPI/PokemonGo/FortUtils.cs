using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using Google.Protobuf;
using System.Threading.Tasks;
using PokeGodar.WebAPI.Enums;
using PokeGodar.WebAPI.Helpers;
using PokeGodar.WebAPI.GeneratedCode;
using AllEnum;
using PokeGodar.WebAPI.Extensions;

namespace PokeGodar.WebAPI.PokemonGo
{
    public class FortUtils
    {
        public static async Task<FortDetailsResponse> GetFort(HttpClient client, string _apiUrl, string fortId, double fortLat, double fortLng, Request.Types.UnknownAuth _unknownAuth, double _currentLat, double _currentLng)
        {
            var customRequest = new Request.Types.FortDetailsRequest
            {
                Id = ByteString.CopyFromUtf8(fortId),
                Latitude = Helpers.Extensions.FloatAsUlong(fortLat),
                Longitude = Helpers.Extensions.FloatAsUlong(fortLng)
            };

            var fortDetailRequest = RequestBuilder.GetRequest(_unknownAuth, _currentLat, _currentLng, 10,
                new Request.Types.Requests
                {
                    Type = (int)RequestType.FORT_DETAILS,
                    Message = customRequest.ToByteString()
                });
            return
                await
                    client.PostProtoPayload<Request, FortDetailsResponse>($"https://{_apiUrl}/rpc",
                        fortDetailRequest);
        }

        public static async Task<FortSearchResponse> SearchFort(HttpClient client, string _apiUrl, string fortId, double fortLat, double fortLng, Request.Types.UnknownAuth _unknownAuth, double _currentLat, double _currentLng)
        {
            var customRequest = new Request.Types.FortSearchRequest
            {
                Id = ByteString.CopyFromUtf8(fortId),
                FortLatDegrees = Helpers.Extensions.FloatAsUlong(fortLat),
                FortLngDegrees = Helpers.Extensions.FloatAsUlong(fortLng),
                PlayerLatDegrees = Helpers.Extensions.FloatAsUlong(_currentLat),
                PlayerLngDegrees = Helpers.Extensions.FloatAsUlong(_currentLng)
            };

            var fortDetailRequest = RequestBuilder.GetRequest(_unknownAuth, _currentLat, _currentLng, 30,
                new Request.Types.Requests
                {
                    Type = (int)RequestType.FORT_SEARCH,
                    Message = customRequest.ToByteString()
                });
            return
                await
                    client.PostProtoPayload<Request, FortSearchResponse>($"https://{_apiUrl}/rpc",
                        fortDetailRequest);
        }
    }
}
