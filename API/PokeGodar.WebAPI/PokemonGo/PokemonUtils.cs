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
using AllEnum;
using PokeGodar.WebAPI.Extensions;
using PokeGodar.WebAPI.GeneratedCode;
using PokeGodar.WebAPI.PokemonGo;
using Item = PokeGodar.WebAPI.Enums.Item;

namespace PokeGodar.WebAPI.PokemonGo
{
    public class PokemonUtils
    {

        public async Task<CatchPokemonResponse> CatchPokemon(HttpClient client, string _apiUrl, ulong encounterId, string spawnPointGuid, double pokemonLat,
    double pokemonLng, Enums.Item pokeball, int? pokemonCP, Request.Types.UnknownAuth _unknownAuth, double _currentLat, double _currentLng)
        {
            var customRequest = new Request.Types.CatchPokemonRequest
            {
                EncounterId = encounterId,
                Pokeball = (int)PlayerUtils.GetBestBall(client, _apiUrl, _unknownAuth, _currentLat, _currentLng, pokemonCP).Result,
                SpawnPointGuid = spawnPointGuid,
                HitPokemon = 1,
                NormalizedReticleSize = Helpers.Extensions.FloatAsUlong(1.950),
                SpinModifier = Helpers.Extensions.FloatAsUlong(1),
                NormalizedHitPosition = Helpers.Extensions.FloatAsUlong(1)
            };

            var catchPokemonRequest = RequestBuilder.GetRequest(_unknownAuth, _currentLat, _currentLng, 30,
                new Request.Types.Requests
                {
                    Type = (int)RequestType.CATCH_POKEMON,
                    Message = customRequest.ToByteString()
                });
            return
                await
                    client.PostProtoPayload<Request, CatchPokemonResponse>($"https://{_apiUrl}/rpc",
                        catchPokemonRequest);
        }

        public async Task<EncounterResponse> EncounterPokemon(HttpClient client, string _apiUrl, ulong encounterId, string spawnPointGuid, Request.Types.UnknownAuth _unknownAuth, double _currentLat, double _currentLng)
        {
            var customRequest = new Request.Types.EncounterRequest
            {
                EncounterId = encounterId,
                SpawnpointId = spawnPointGuid,
                PlayerLatDegrees = Helpers.Extensions.FloatAsUlong(_currentLat),
                PlayerLngDegrees = Helpers.Extensions.FloatAsUlong(_currentLng)
            };

            var encounterResponse = RequestBuilder.GetRequest(_unknownAuth, _currentLat, _currentLng, 30,
                new Request.Types.Requests
                {
                    Type = (int)RequestType.ENCOUNTER,
                    Message = customRequest.ToByteString()
                });
            return
                await
                    client.PostProtoPayload<Request, EncounterResponse>($"https://{_apiUrl}/rpc", encounterResponse);
        }

        public async Task<TransferPokemonOut> TransferPokemon(HttpClient client, string _apiUrl, ulong pokemonId, Request.Types.UnknownAuth _unknownAuth, double _currentLat, double _currentLng)
        {
            var customRequest = new TransferPokemon
            {
                PokemonId = pokemonId
            };

            var releasePokemonRequest = RequestBuilder.GetRequest(_unknownAuth, _currentLat, _currentLng, 30,
                new Request.Types.Requests
                {
                    Type = (int)RequestType.RELEASE_POKEMON,
                    Message = customRequest.ToByteString()
                });
            return
                await
                    client.PostProtoPayload<Request, TransferPokemonOut>($"https://{_apiUrl}/rpc",
                        releasePokemonRequest);
        }

        public async Task<EvolvePokemonOut> EvolvePokemon(HttpClient client, string _apiUrl, ulong pokemonId, Request.Types.UnknownAuth _unknownAuth, double _currentLat, double _currentLng)
        {
            var customRequest = new EvolvePokemon
            {
                PokemonId = pokemonId
            };

            var releasePokemonRequest = RequestBuilder.GetRequest(_unknownAuth, _currentLat, _currentLng, 30,
                new Request.Types.Requests
                {
                    Type = (int)RequestType.EVOLVE_POKEMON,
                    Message = customRequest.ToByteString()
                });
            return
                await
                    client.PostProtoPayload<Request, EvolvePokemonOut>($"https://{_apiUrl}/rpc",
                        releasePokemonRequest);
        }

    }
}
