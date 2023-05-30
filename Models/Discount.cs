using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Models
{
    public class Discount
    {
        [JsonIgnore]
        public static int s_autoId = 1000000;
        [JsonProperty("id")]
        public int DiscountId { get; set; }
        [JsonProperty("name")]
        public String Name { get; set; }
        [JsonProperty("start")]
        public DateTime StartTime { get; set; }
        [JsonProperty("end")]
        public DateTime EndTime { get; set; }
        [JsonProperty("type")]
        public string DiscountType { get; set; }
        [JsonProperty("amount")]
        public int DiscountPriceAmount { get; set; }
        [JsonProperty("percent")]
        public int DiscountPercent { get; set; }
        public Discount()
        {

        }
        public Discount(int id)
        {
            DiscountId = id > 0 ? id : s_autoId++;
        }
        public static void UpdateAutoId(int v)
        {
            s_autoId = v;
        }

        public Discount(int discountId, string name, DateTime startTime, DateTime endTime, string discountType, int discountPriceAmount, int discountPercent) : this(discountId)
        {
            Name = name;
            StartTime = startTime;
            EndTime = endTime;
            DiscountType = discountType;
            DiscountPriceAmount = discountPriceAmount;
            DiscountPercent = discountPercent;
        }

        //public Discount(int discountId)
        //{
        //    DiscountId = discountId;
        //}

        public override bool Equals(object obj)
        {
            return obj is Discount discount &&
                   DiscountId == discount.DiscountId;
        }

        public override int GetHashCode()
        {
            return 1574009819 + DiscountId.GetHashCode();
        }
    }
}
