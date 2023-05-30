using System;
using Newtonsoft.Json;
namespace Models
{
    public class SelectedItem : Item
    {
        [JsonProperty("numberOfSelectedItem")]
        public int NumberOfSelectedItem { get; set; }
        [JsonProperty("priceAfterDiscount")]
        public int PriceAfterDiscount { get; set; }
        public SelectedItem(){
            CaculatePriceAfterDiscount();
        }
        public SelectedItem(Item item) : base(item.ItemId, item.ItemName, item.ItemType, item.Quantity, item.Brand, item.ReleaseDate, item.Price, item.Discount) {
            CaculatePriceAfterDiscount();
        }
        public SelectedItem(int numberOfSelectedItem) {
            NumberOfSelectedItem = numberOfSelectedItem;
            CaculatePriceAfterDiscount();
        }

        private void CaculatePriceAfterDiscount()
        {
            if (Discount == null)
            {
                PriceAfterDiscount = Price;
            }
            else
            {
                var currentTime = DateTime.Now;
                if(currentTime >= Discount.StartTime && currentTime <= Discount.EndTime)
                {
                    if(Discount.DiscountPercent > 0)
                    {
                        PriceAfterDiscount= (int)(Price * (1 - 1.0f * Discount.DiscountPercent/100)); 
                    }
                    if(Discount.DiscountPercent > 0)
                    {
                        PriceAfterDiscount = Price - Discount.DiscountPriceAmount;
                    }
                }
            }
        }

        public SelectedItem(int itemId, string itemName, string itemType, int quantity, string brand, DateTime releaseDate, int price,
            Discount discount,int numberOfSelectedItem, int priceAfterDiscount) 
            : base(itemId, itemName, itemType, quantity, brand, releaseDate, price, discount)
        {
            NumberOfSelectedItem = numberOfSelectedItem;
            PriceAfterDiscount = Price;
        }

    }
}
