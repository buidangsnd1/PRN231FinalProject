using System;
using Models;

namespace Controllers
{
    public interface IDiscountController
    {
        bool IsStartTimeMatch(Discount discount, string startTime);
        bool IsEndTimeMatch(Discount discount, string endTime);
        bool IsDiscountNameMatch(Discount discount, string name);
    }
}
