using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public interface IAutoIdUpdater
    {
        void UpdateItemAutoId(List<Item> items);
        void UpdateDiscountAutoId(List<Discount> discounts);
        void UpdateBillAutoId(List<BillDetail> bills);
    }
}
