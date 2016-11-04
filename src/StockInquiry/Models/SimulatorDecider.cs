using System;
using Microsoft.AspNetCore.Http;

namespace StockInquiry.Models
{
    public class SimulatorDecider : ISimulatorDecider
    {
        private readonly IHttpContextAccessor _context;

        public SimulatorDecider(IHttpContextAccessor context)
        {
            _context = context;
        }

        public bool ShouldSimulate(SimulatorKey key)
        {
            var cookie = _context.HttpContext.Request.Cookies[key.ToString()];
            return cookie != null && bool.Parse(cookie);
        }

        public void ChangeSimulatorTo(SimulatorKey key, bool value)
        {
            _context.HttpContext.Response.Cookies.Append(key.ToString(), value.ToString(), new CookieOptions { Expires = DateTimeOffset.MaxValue });
        }
    }
}
