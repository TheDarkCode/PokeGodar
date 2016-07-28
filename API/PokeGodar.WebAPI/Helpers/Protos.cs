using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeGodar.WebAPI.Helpers
{
    class Protos
    {
        public static byte[] EncodeUlongList(List<ulong> integers)
        {
            var output = new List<byte>();
            foreach (var integer in integers.OrderBy(c => c))
            {
                output.AddRange(VarintBitConverter.GetVarintBytes(integer));
            }

            return output.ToArray();
        }
    }
}
