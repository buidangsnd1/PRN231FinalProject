using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public interface IBillFinder
    {
        bool IsBillCreateTimeMatch(BillDetail bill, string timeTxt);
        bool IsBillCustomerNameMatch(BillDetail bill, string customerName);
        bool IsBillStatusMatch(BillDetail bill, string status);
        bool IsBillStaffNameMatch(BillDetail bill, string staffName);

    }
}
