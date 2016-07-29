using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokeGodar.WebAPI.Enums;
using AllEnum;
using PokeGodar.WebAPI.GeneratedCode;

namespace PokeGodar.WebAPI.Helpers
{
    class RequestBuilder
    {
        public static Request GetInitialRequest(string authToken, AuthType authType, double lat, double lng,
            double altitude, params Request.Types.Requests[] customRequests)
        {
            return new Request
            {
                Altitude = Extensions.FloatAsUlong(altitude),
                Auth = new Request.Types.AuthInfo
                {
                    Provider = authType == AuthType.Google ? "google" : "ptc",
                    Token = new Request.Types.AuthInfo.Types.JWT
                    {
                        Contents = authToken,
                        Unknown13 = 14
                    }
                },
                Latitude = Extensions.FloatAsUlong(lat),
                Longitude = Extensions.FloatAsUlong(lng),
                RpcId = 1469378659230941192,
                Unknown1 = 2,
                Unknown12 = 989, //Required otherwise we receive incompatible protocol
                Requests =
                {
                    customRequests
                }
            };
        }

        public static Request GetInitialRequest(string authToken, AuthType authType, double lat, double lng,
            double altitude, params RequestType[] customRequestTypes)
        {
            var customRequests = customRequestTypes.ToList().Select(c => new Request.Types.Requests { Type = (int)c });
            return GetInitialRequest(authToken, authType, lat, lng, altitude, customRequests.ToArray());
        }

        public static Request GetRequest(Request.Types.UnknownAuth unknownAuth, double lat, double lng, double altitude,
            params Request.Types.Requests[] customRequests)
        {
            return new Request
            {
                Altitude = Extensions.FloatAsUlong(altitude),
                Unknownauth = unknownAuth,
                Latitude = Extensions.FloatAsUlong(lat),
                Longitude = Extensions.FloatAsUlong(lng),
                RpcId = 1469378659230941192,
                Unknown1 = 2,
                Unknown12 = 989, //Required otherwise we receive incompatible protocol
                Requests =
                {
                    customRequests
                }
            };
        }

        public static Request GetRequest(Request.Types.UnknownAuth unknownAuth, double lat, double lng, double altitude,
            params RequestType[] customRequestTypes)
        {
            var customRequests = customRequestTypes.ToList().Select(c => new Request.Types.Requests { Type = (int)c });
            return GetRequest(unknownAuth, lat, lng, altitude, customRequests.ToArray());
        }
    }
}
