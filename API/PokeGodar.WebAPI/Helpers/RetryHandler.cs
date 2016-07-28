﻿using System;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;

namespace PokeGodar.WebAPI.Helpers
{
    internal class RetryHandler : DelegatingHandler
    {
        private const int MaxRetries = 100000;

        public RetryHandler(HttpMessageHandler innerHandler)
            : base(innerHandler)
        {
        }

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            for (var i = 0; i <= MaxRetries; i++)
            {
                try
                {
                    var response = await base.SendAsync(request, cancellationToken);
                    if (response.StatusCode == HttpStatusCode.BadGateway)
                        throw new Exception(); //todo: proper implementation

                    return response;
                }
                catch (Exception)
                {
                    Console.WriteLine(
                        $"[{DateTime.Now.ToString("HH:mm:ss")}] [#{i} of {MaxRetries}] retry request {request.RequestUri}");
                    if (i < MaxRetries)
                    {
                        await Task.Delay(1000);
                        continue;
                    }
                    throw;
                }
            }
            return null;
        }
    }
}
