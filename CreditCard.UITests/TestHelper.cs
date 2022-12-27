using System;
using System.Collections.Generic;
using System.Threading;


namespace CreditCard.UITests
{
    internal static class TestHelper
    {
        public static void Pause(int secondsToPause = 3000)
        {
            Thread.Sleep(secondsToPause);
        }
    }
}
