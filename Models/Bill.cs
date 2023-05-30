using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Models 
{
    public class Bill : IComparable<Bill>
    {
        [JsonIgnore]
        public static int s_autoId = 1000000;
        [JsonProperty("billId")]
        public int BillId { get; set; }
        [JsonProperty("cart")]
        public Cart Cart { get; set; } = new Cart();
        [JsonProperty("createTime")]
        public DateTime CreatedTime { get; set; }
        [JsonProperty("totalItem")]
        public int TotalItem { get; set; } = 0;
        [JsonProperty("subTotal")]
        public long SubTotal { get; set; } = 0;
        [JsonProperty("totalDiscountAmount")]
        public long TotalDiscountAmount { get; set; } = 0;
        [JsonProperty("totalAmount")]
        public long TotalAmount { get; set; } = 0;
        [JsonProperty("status")]
        public string Status { get; set; }
        public Bill()
        {

        }
        public static void UpdateAutoId(int v)
        {
            s_autoId = v;
        }
        public Bill(int id)
        {
            BillId = id > 0 ? id : s_autoId++;
        }
        public Bill(int billId, Cart cart, DateTime createdTime, int totalItem, long subTotal, long totalDiscountAmount, long totalAmount, string status) : this(billId)
        {
            Cart = cart;
            CreatedTime = createdTime;
            TotalItem = totalItem;
            SubTotal = subTotal;
            TotalDiscountAmount = totalDiscountAmount;
            TotalAmount = totalAmount;
            Status = status;
        }


        public int CompareTo(Bill other)
        {
            return BillId - other.BillId;
        }

        public override bool Equals(object obj)
        {
            return obj is Bill bill &&
                   BillId == bill.BillId;
        }

        public override int GetHashCode()
        {
            return 740390073 + BillId.GetHashCode();
        }
    }
}
