using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Common.Geometry;

namespace PokeGodar.WebAPI.Helpers
{
    public class S2Utils
    {
        public static List<ulong> GetNearbyCellIds(double longitude, double latitude)
        {
            var nearbyCellIds = new List<S2CellId>();

            var cellId = S2CellId.FromLatLng(S2LatLng.FromDegrees(latitude, longitude)).ParentForLevel(15);
            //.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Parent;

            nearbyCellIds.Add(cellId);
            for (var i = 0; i < 10; i++)
            {
                nearbyCellIds.Add(GetPrevious(cellId, i));
                nearbyCellIds.Add(GetNext(cellId, i));
            }

            return nearbyCellIds.Select(c => c.Id).OrderBy(c => c).ToList();
        }

        private static S2CellId GetNext(S2CellId cellId, int depth)
        {
            if (depth < 0)
                return cellId;

            depth--;

            return GetNext(cellId.Next, depth);
        }

        private static S2CellId GetPrevious(S2CellId cellId, int depth)
        {
            if (depth < 0)
                return cellId;

            depth--;

            return GetPrevious(cellId.Previous, depth);
        }
    }
}
