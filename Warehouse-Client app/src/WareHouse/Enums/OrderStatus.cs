using System;

namespace WareHouse.Enums
{
    [Flags]
    public enum OrderStatus
    {
        NotFormed = 0,
        Formed = 1,
        Processed = 2,
        PaidUp = 4,
        Shipped = 8,
        Completed = 16
    }
}