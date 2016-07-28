﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Web;
using PokeGodar.WebAPI.Enums;
using PokeGodar.WebAPI.Helpers;
using PokeGodar.WebAPI.Exceptions;

namespace PokeGodar.WebAPI.Authentication
{
    internal static class PtcLogin
    {
        public static async Task<string> GetAccessToken(string username, string password)
        {
            var handler = new HttpClientHandler
            {
                AutomaticDecompression = DecompressionMethods.GZip,
                AllowAutoRedirect = false
            };

            using (var tempHttpClient = new HttpClient(handler))
            {
                //Get session cookie
                var sessionResp = await tempHttpClient.GetAsync(AppSettingsConfig.PtcLoginUrl);
                var data = await sessionResp.Content.ReadAsStringAsync();
                var lt = JsonHelper.GetValue(data, "lt");
                var executionId = JsonHelper.GetValue(data, "execution");

                //Login
                var loginResp = await tempHttpClient.PostAsync(AppSettingsConfig.PtcLoginUrl,
                    new FormUrlEncodedContent(
                        new[]
                        {
                            new KeyValuePair<string, string>("lt", lt),
                            new KeyValuePair<string, string>("execution", executionId),
                            new KeyValuePair<string, string>("_eventId", "submit"),
                            new KeyValuePair<string, string>("username", username),
                            new KeyValuePair<string, string>("password", password)
                        }));

                var ticketId = HttpUtility.ParseQueryString(loginResp.Headers.Location.Query)["ticket"];
                if (ticketId == null)
                    throw new PtcOfflineException();

                //Get tokenvar 
                var tokenResp = await tempHttpClient.PostAsync(AppSettingsConfig.PtcLoginOauth,
                    new FormUrlEncodedContent(
                        new[]
                        {
                            new KeyValuePair<string, string>("client_id", "mobile-app_pokemon-go"),
                            new KeyValuePair<string, string>("redirect_uri",
                                "https://www.nianticlabs.com/pokemongo/error"),
                            new KeyValuePair<string, string>("client_secret",
                                "w8ScCUXJQc6kXKw8FiOhd8Fixzht18Dq3PEVkUCP5ZPxtgyWsbTvWHFLm2wNY0JR"),
                            new KeyValuePair<string, string>("grant_type", "refresh_token"),
                            new KeyValuePair<string, string>("code", ticketId)
                        }));

                var tokenData = await tokenResp.Content.ReadAsStringAsync();
                return HttpUtility.ParseQueryString(tokenData)["access_token"];
            }
        }
    }
}
