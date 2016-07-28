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

namespace PokeGodar.WebAPI.PokemonGo
{
    public class FortUtils
    {
        public async Task<FortDetailsResponse> GetFort(HttpClient client, string fortId, double fortLat, double fortLng)
        {
            var customRequest = new Request.Types.FortDetailsRequest
            {
                Id = ByteString.CopyFromUtf8(fortId),
                Latitude = Extensions.FloatAsUlong(fortLat),
                Longitude = Extensions.FloatAsUlong(fortLng)
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

        public async Task<FortSearchResponse> SearchFort(HttpClient client, string fortId, double fortLat, double fortLng)
        {
            var customRequest = new Request.Types.FortSearchRequest
            {
                Id = ByteString.CopyFromUtf8(fortId),
                FortLatDegrees = Extensions.FloatAsUlong(fortLat),
                FortLngDegrees = Extensions.FloatAsUlong(fortLng),
                PlayerLatDegrees = Extensions.FloatAsUlong(_currentLat),
                PlayerLngDegrees = Extensions.FloatAsUlong(_currentLng)
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
