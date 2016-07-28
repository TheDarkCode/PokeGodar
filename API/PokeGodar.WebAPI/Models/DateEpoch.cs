using System;
using PokeGodar.WebAPI.Helpers;

namespace PokeGodar.WebAPI.Models
{
    public class DateEpoch
    {
        public DateTime Date { get; set; }
        public int Epoch
        {
            get
            {
                return (this.Date.Equals(null) || this.Date.Equals(DateTime.MinValue)) ? int.MinValue : this.Date.ToEpoch();
            }
        }
    }
}
