using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Controllers
{
    public class DiscountController : IDiscountController
    {
        public bool IsDiscountNameMatch(Discount discount, string name)
        {
            var pattern = $".*{name}.*";
            var regex = new Regex(pattern);
            return regex.IsMatch(discount.Name);

        }

        public bool IsEndTimeMatch(Discount discount, string startTime)
        {
            var pattern = $".*{startTime}.*";
            var regex = new Regex(pattern);
            return regex.IsMatch(discount.StartTime.ToString("dd/MM/yyyy HH:mm:ss"));
        }

        public bool IsStartTimeMatch(Discount discount, string endTime)
        {
            var pattern = $".*{endTime}.*";
            var regex = new Regex(pattern);
            return regex.IsMatch(discount.EndTime.ToString("dd/MM/yyyy HH:mm:ss"));
        }
    }
}
