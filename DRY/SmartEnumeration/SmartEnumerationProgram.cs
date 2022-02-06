using System;

namespace DRY.SmartEnumeration
{
    public class SmartEnumerationProgram
    {
        public static double GetDiscount(EnumSubscription enumSubscription)
        {
            return enumSubscription switch
            {
                EnumSubscription.Free => .0,
                EnumSubscription.Premium => 0.25,
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }
}
