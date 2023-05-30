using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Controllers
{
    public class BillFinder : IBillFinder

    {
        public bool IsBillCreateTimeMatch(BillDetail bill, string timeTxt)
        {
            var patten = $".*{timeTxt}.*";
            Regex regex = new Regex(patten, RegexOptions.IgnoreCase);
            return regex.IsMatch(bill.CreatedTime.ToString("dd/MM/yyyy HH:mm:ss"));
        }

        public bool IsBillCustomerNameMatch(BillDetail bill, string customerName)
        {
            var patten = $".*{customerName}.*";
            Regex regex = new Regex(patten, RegexOptions.IgnoreCase);
            return regex.IsMatch(bill.Cart?.Customer?.FullName.FirstName);
        }

        public bool IsBillStaffNameMatch(BillDetail bill, string staffName)
        {
            var patten = $".*{staffName}.*";
            Regex regex = new Regex(patten, RegexOptions.IgnoreCase);
            return regex.IsMatch(bill.StaffName);
        }

        public bool IsBillStatusMatch(BillDetail bill, string status)
        {
            var patten = $".*{status}.*";
            Regex regex = new Regex(patten, RegexOptions.IgnoreCase);
            return regex.IsMatch(bill?.Status);
        }
    }
}
