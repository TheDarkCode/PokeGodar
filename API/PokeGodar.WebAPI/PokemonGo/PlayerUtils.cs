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
    class PlayerUtils
    {
        public async Task<GetPlayerResponse> GetProfile(HttpClient client)
        {
            var profileRequest = RequestBuilder.GetInitialRequest(_accessToken, _authType, _currentLat, _currentLng, 10,
                new Request.Types.Requests { Type = (int)RequestType.GET_PLAYER });
            return
                await client.PostProtoPayload<Request, GetPlayerResponse>($"https://{_apiUrl}/rpc", profileRequest);
        }

        public async Task<DownloadSettingsResponse> GetSettings(HttpClient client)
        {
            var settingsRequest = RequestBuilder.GetRequest(_unknownAuth, _currentLat, _currentLng, 10,
                RequestType.DOWNLOAD_SETTINGS);
            return
                await
                    client.PostProtoPayload<Request, DownloadSettingsResponse>($"https://{_apiUrl}/rpc",
                        settingsRequest);
        }

        public async Task<Response.Types.Unknown6> RecycleItem(HttpClient client, AllEnum.ItemId itemId, int amount)
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

        public async Task<IEnumerable<Item>> GetItems(HttpClient client)
        {
            var inventory = await GetInventory(client);
            return inventory.InventoryDelta.InventoryItems
                .Select(i => i.InventoryItemData?.Item)
                .Where(p => p != null);
        }

        public async Task<UseItemCaptureRequest> UseCaptureItem(HttpClient client, ulong encounterId, AllEnum.ItemId itemId, string spawnPointGuid)
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

        public async Task UseRazzBerry(HttpClient client, ulong encounterId, string spawnPointGuid)
        {
            IEnumerable<Item> myItems = await GetItems(client);
            IEnumerable<Item> RazzBerries = myItems.Where(i => (ItemId)i.Item_ == ItemId.ItemRazzBerry);
            Item RazzBerry = RazzBerries.FirstOrDefault();
            if (RazzBerry != null)
            {
                UseItemCaptureRequest useRazzBerry = await UseCaptureItem(client, encounterId, AllEnum.ItemId.ItemRazzBerry, spawnPointGuid);
                await Task.Delay(2000);
            }
        }

        public async Task<UseItemRequest> UseItemXpBoost(HttpClient client, ItemId itemId)
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
