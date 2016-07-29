using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using Google.Protobuf;
using System.Threading.Tasks;
using AllEnum;
using PokeGodar.WebAPI.Enums;
using PokeGodar.WebAPI.Extensions;
using PokeGodar.WebAPI.GeneratedCode;
using PokeGodar.WebAPI.Helpers;
using Item = PokeGodar.WebAPI.Enums.Item;

namespace PokeGodar.WebAPI.PokemonGo
{
    public class PlayerUtils
    {
        public static async Task<GetPlayerResponse> GetProfile(HttpClient client, string _accessToken, AuthType _authType, string _apiUrl, Request.Types.UnknownAuth _unknownAuth, double _currentLat, double _currentLng)
        {
            var profileRequest = RequestBuilder.GetInitialRequest(_accessToken, _authType, _currentLat, _currentLng, 10,
                new Request.Types.Requests { Type = (int)RequestType.GET_PLAYER });
            return
                await client.PostProtoPayload<Request, GetPlayerResponse>($"https://{_apiUrl}/rpc", profileRequest);
        }

        public static async Task<DownloadSettingsResponse> GetSettings(HttpClient client, string _apiUrl, Request.Types.UnknownAuth _unknownAuth, double _currentLat, double _currentLng)
        {
            var settingsRequest = RequestBuilder.GetRequest(_unknownAuth, _currentLat, _currentLng, 10,
                RequestType.DOWNLOAD_SETTINGS);
            return
                await
                    client.PostProtoPayload<Request, DownloadSettingsResponse>($"https://{_apiUrl}/rpc",
                        settingsRequest);
        }

        public static async Task<Item> GetBestBall(HttpClient client, string _apiUrl, Request.Types.UnknownAuth _unknownAuth, double _currentLat, double _currentLng, int? pokemonCP)
        {
            var inventory = await GetInventory(client, _apiUrl, _unknownAuth, _currentLat, _currentLng);

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

        public static async Task<Response.Types.Unknown6> RecycleItem(HttpClient client, string _apiUrl, AllEnum.ItemId itemId, int amount, Request.Types.UnknownAuth _unknownAuth, double _currentLat, double _currentLng)
        {
            var customRequest = new InventoryItemData.RecycleInventoryItem
            {
                ItemId = (AllEnum.ItemId)Enum.Parse(typeof(AllEnum.ItemId), itemId.ToString()),
                Count = amount
            };

            var releasePokemonRequest = RequestBuilder.GetRequest(_unknownAuth, _currentLat, _currentLng, 30,
                new Request.Types.Requests()
                {
                    Type = (int)RequestType.RECYCLE_INVENTORY_ITEM,
                    Message = customRequest.ToByteString()
                });
            return await client.PostProtoPayload<Request, Response.Types.Unknown6>($"https://{_apiUrl}/rpc", releasePokemonRequest);
        }

        public static async Task<IEnumerable<GeneratedCode.Item>> GetItems(HttpClient client, string _apiUrl, Request.Types.UnknownAuth _unknownAuth, double _currentLat, double _currentLng)
        {
            var inventory = await GetInventory(client, _apiUrl, _unknownAuth, _currentLat, _currentLng);
            return inventory.InventoryDelta.InventoryItems
                .Select(i => i.InventoryItemData?.Item)
                .Where(p => p != null);
        }

        public static async Task<GetInventoryResponse> GetInventory(HttpClient client, string _apiUrl, Request.Types.UnknownAuth _unknownAuth, double _currentLat, double _currentLng)
        {
            var inventoryRequest = RequestBuilder.GetRequest(_unknownAuth, _currentLat, _currentLng, 30,
                RequestType.GET_INVENTORY);
            return
                await
                    client.PostProtoPayload<Request, GetInventoryResponse>($"https://{_apiUrl}/rpc",
                        inventoryRequest);
        }

        public static async Task<UseItemCaptureRequest> UseCaptureItem(HttpClient client, string _apiUrl, ulong encounterId, AllEnum.ItemId itemId, string spawnPointGuid, Request.Types.UnknownAuth _unknownAuth, double _currentLat, double _currentLng)
        {
            var customRequest = new UseItemCaptureRequest
            {
                EncounterId = encounterId,
                ItemId = itemId,
                SpawnPointGuid = spawnPointGuid
            };

            var useItemRequest = RequestBuilder.GetRequest(_unknownAuth, _currentLat, _currentLng, 30,
                new Request.Types.Requests()
                {
                    Type = (int)RequestType.USE_ITEM_CAPTURE,
                    Message = customRequest.ToByteString()
                });
            return await client.PostProtoPayload<Request, UseItemCaptureRequest>($"https://{_apiUrl}/rpc", useItemRequest);
        }

        public static async Task UseRazzBerry(HttpClient client, string _apiUrl, ulong encounterId, string spawnPointGuid, Request.Types.UnknownAuth _unknownAuth, double _currentLat, double _currentLng)
        {
            IEnumerable<GeneratedCode.Item> myItems = await GetItems(client, _apiUrl, _unknownAuth, _currentLat, _currentLng);
            IEnumerable<GeneratedCode.Item> RazzBerries = myItems.Where(i => (ItemId)i.Item_ == ItemId.ItemRazzBerry);
            GeneratedCode.Item RazzBerry = RazzBerries.FirstOrDefault();
            if (RazzBerry != null)
            {
                UseItemCaptureRequest useRazzBerry = await UseCaptureItem(client, _apiUrl, encounterId, AllEnum.ItemId.ItemRazzBerry, spawnPointGuid, _unknownAuth, _currentLat, _currentLng);
                await Task.Delay(2000);
            }
        }

        public static async Task<UseItemRequest> UseItemXpBoost(HttpClient client, string _apiUrl, ItemId itemId, Request.Types.UnknownAuth _unknownAuth, double _currentLat, double _currentLng)
        {
            var customRequest = new UseItemRequest
            {
                ItemId = itemId,
            };

            var useItemRequest = RequestBuilder.GetRequest(_unknownAuth, _currentLat, _currentLng, 30,
                new Request.Types.Requests
                {
                    Type = (int)RequestType.USE_ITEM_XP_BOOST,
                    Message = customRequest.ToByteString()
                });
            return
                await
                    client.PostProtoPayload<Request, UseItemRequest>($"https://{_apiUrl}/rpc",
                        useItemRequest);
        }
    }
}
