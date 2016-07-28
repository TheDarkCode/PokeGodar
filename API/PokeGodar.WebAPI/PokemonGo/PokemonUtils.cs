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
    public class PokemonUtils
    {

        public async Task<CatchPokemonResponse> CatchPokemon(HttpClient client, ulong encounterId, string spawnPointGuid, double pokemonLat,
    double pokemonLng, Item pokeball, int? pokemonCP)
        {
            var customRequest = new Request.Types.CatchPokemonRequest
            {
                EncounterId = encounterId,
                Pokeball = (int)GetBestBall(pokemonCP).Result,
                SpawnPointGuid = spawnPointGuid,
                HitPokemon = 1,
                NormalizedReticleSize = Extensions.FloatAsUlong(1.950),
                SpinModifier = Extensions.FloatAsUlong(1),
                NormalizedHitPosition = Extensions.FloatAsUlong(1)
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

        public async Task<EncounterResponse> EncounterPokemon(HttpClient client, ulong encounterId, string spawnPointGuid)
        {
            var customRequest = new Request.Types.EncounterRequest
            {
                EncounterId = encounterId,
                SpawnpointId = spawnPointGuid,
                PlayerLatDegrees = Extensions.FloatAsUlong(_currentLat),
                PlayerLngDegrees = Extensions.FloatAsUlong(_currentLng)
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

        public async Task<TransferPokemonOut> TransferPokemon(HttpClient client, ulong pokemonId)
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

        public async Task<EvolvePokemonOut> EvolvePokemon(HttpClient client, ulong pokemonId)
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

        private async Task<Item> GetBestBall(int? pokemonCP)
        {
            var inventory = await GetInventory();

            var ballCollection = inventory.InventoryDelta.InventoryItems.Select(i => i.InventoryItemData?.Item)
                .Where(p => p != null)
                .GroupBy(i => (Item)i.Item_)
                .Select(kvp => new { ItemId = kvp.Key, Amount = kvp.Sum(x => x.Count) })
                .Where(y => y.ItemId == Item.ITEM_POKE_BALL
                            || y.ItemId == Item.ITEM_GREAT_BALL
                            || y.ItemId == Item.ITEM_ULTRA_BALL
                            || y.ItemId == Item.ITEM_MASTER_BALL);

            var pokeBallsCount = ballCollection.Where(p => p.ItemId == Item.ITEM_POKE_BALL).
                DefaultIfEmpty(new { ItemId = Item.ITEM_POKE_BALL, Amount = 0 }).FirstOrDefault().Amount;
            var greatBallsCount = ballCollection.Where(p => p.ItemId == Item.ITEM_GREAT_BALL).
                DefaultIfEmpty(new { ItemId = Item.ITEM_GREAT_BALL, Amount = 0 }).FirstOrDefault().Amount;
            var ultraBallsCount = ballCollection.Where(p => p.ItemId == Item.ITEM_ULTRA_BALL).
                DefaultIfEmpty(new { ItemId = Item.ITEM_ULTRA_BALL, Amount = 0 }).FirstOrDefault().Amount;
            var masterBallsCount = ballCollection.Where(p => p.ItemId == Item.ITEM_MASTER_BALL).
                DefaultIfEmpty(new { ItemId = Item.ITEM_MASTER_BALL, Amount = 0 }).FirstOrDefault().Amount;

            // Use better balls for high CP pokemon
            if (masterBallsCount > 0 && pokemonCP >= 1000)
            {
                return Item.ITEM_MASTER_BALL;
            }

            if (ultraBallsCount > 0 && pokemonCP >= 600)
            {
                return Item.ITEM_ULTRA_BALL;
            }

            if (greatBallsCount > 0 && pokemonCP >= 350)
            {
                return Item.ITEM_GREAT_BALL;
            }

            // If low CP pokemon, but no more pokeballs; only use better balls if pokemon are of semi-worthy quality
            if (pokeBallsCount > 0)
            {
                return Item.ITEM_POKE_BALL;
            }
            else if ((greatBallsCount < 40 && pokemonCP >= 200) || greatBallsCount >= 40)
            {
                return Item.ITEM_GREAT_BALL;
            }
            else if (ultraBallsCount > 0 && pokemonCP >= 500)
            {
                return Item.ITEM_ULTRA_BALL;
            }
            else if (masterBallsCount > 0 && pokemonCP >= 700)
            {
                return Item.ITEM_MASTER_BALL;
            }

            return Item.ITEM_POKE_BALL;
        }

        public async Task<TransferPokemonOut> TransferPokemon(HttpClient client, ulong pokemonId)
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

    }
}
