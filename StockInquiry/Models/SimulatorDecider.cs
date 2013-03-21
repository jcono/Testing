using System;
using System.Web;

namespace StockInquiry.Models
{
    public class SimulatorDecider : ISimulatorDecider
    {
        public bool ShouldSimulate(SimulatorKey key)
        {
            var cookie = HttpContext.Current.Request.Cookies.Get(key.ToString());
            return cookie != null && bool.Parse(cookie.Value);
        }

        public void ChangeSimulatorTo(SimulatorKey key, bool value)
        {
            var cookie = new HttpCookie(key.ToString(), value.ToString())
            {
                Expires = DateTime.MaxValue
            };
            HttpContext.Current.Response.Cookies.Set(cookie);
        }
    }
}