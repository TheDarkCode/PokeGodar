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
using PokeGodar.WebAPI.Extensions;
using PokeGodar.WebAPI.GeneratedCode;
using PokeGodar.WebAPI.Helpers;

namespace PokeGodar.WebAPI.PokemonGo
{
    public class MapUtils
    {
        public async Task<GetMapObjectsResponse> GetMapObjects(HttpClient client, string _apiUrl, Request.Types.UnknownAuth _unknownAuth, double _currentLat, double _currentLng)
        {
            var customRequest = new Request.Types.MapObjectsRequest
            {
                CellIds =
                    ByteString.CopyFrom(
                        Protos.EncodeUlongList(S2Utils.GetNearbyCellIds(_currentLng,
                            _currentLat))),
                Latitude = Helpers.Extensions.FloatAsUlong(_currentLat),
                Longitude = Helpers.Extensions.FloatAsUlong(_currentLng),
                Unknown14 = ByteString.CopyFromUtf8("\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0")
            };

            var mapRequest = RequestBuilder.GetRequest(_unknownAuth, _currentLat, _currentLng, 10,
                new Request.Types.Requests
                {
                    Type = (int)RequestType.GET_MAP_OBJECTS,
                    Message = customRequest.ToByteString()
                },
                new Request.Types.Requests { Type = (int)RequestType.GET_HATCHED_OBJECTS },
                new Request.Types.Requests
                {
                    Type = (int)RequestType.GET_INVENTORY,
                    Message = new Request.Types.Time { Time_ = DateTime.UtcNow.ToUnixTime() }.ToByteString()
                },
                new Request.Types.Requests { Type = (int)RequestType.CHECK_AWARDED_BADGES },
                new Request.Types.Requests
                {
                    Type = (int)RequestType.DOWNLOAD_SETTINGS,
                    Message =
                        new Request.Types.SettingsGuid
                        {
                            Guid = ByteString.CopyFromUtf8("4a2e9bc330dae60e7b74fc85b98868ab4700802e")
                        }.ToByteString()
                });

            return
                await client.PostProtoPayload<Request, GetMapObjectsResponse>($"https://{_apiUrl}/rpc", mapRequest);
        }
    }
}
