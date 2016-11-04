using System;
using System.Diagnostics;
using System.Threading;

namespace StockInquiry.Tests.Framework.Browser
{
    public static class Wait
    {
        private static readonly TimeSpan OneSecond = new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 1);
        private static readonly TimeSpan DefaultTotalTime = new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 10);

        public static void For(Func<bool> action, string failureMessage)
        {
            For(action, failureMessage, DefaultTotalTime);
        }

        public static void For(Func<bool> action, string failureMessage, TimeSpan defaultTotalTime)
        {
            var amountOfTimeLeft = defaultTotalTime;
            while (amountOfTimeLeft > TimeSpan.Zero)
            {
                try
                {
                    if (action())
                    {
                        return;
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Wait.For() swallowed an exception : {0} : {1}s", ex.Message, amountOfTimeLeft.TotalSeconds);
                    continue;
                }
                finally
                {
                    Thread.Sleep(OneSecond);
                    amountOfTimeLeft -= OneSecond;
                }
            }
            throw new TimeoutException(failureMessage);
        }
    }
}
