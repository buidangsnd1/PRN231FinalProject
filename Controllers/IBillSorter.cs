using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public interface IBillSorter
    {
        int CompareBillTotalItems(BillDetail b1, BillDetail b2);
        int CompareBillTotalAmount(BillDetail b1, BillDetail b2);
        int CompareBillByCreatedDateTimeASC(BillDetail b1, BillDetail b2);
        int CompareBillByCreatedDateTimeDSC(BillDetail b1, BillDetail b2);
        int CompareBillByCustomerName(BillDetail b1, BillDetail b2);
    }
}
