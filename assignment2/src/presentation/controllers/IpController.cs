using Microsoft.AspNetCore.Mvc;
using assignment2.src.domain;

namespace assignment2.src.presentation.controllers;

[ApiController]
[Route("i-know-who-you-are")]
public class IpController : ControllerBase
{
    [HttpGet("/")]
    public IActionResult RedirectToCreepy()
    {
        return RedirectPermanent("i-know-who-you-are");
    }

    [HttpGet("")]
    public IActionResult GetIp()
    {
        var userAgent = Request.Headers.UserAgent.ToString();

        var ipInfo = new IpInfo
        {
            IpAddress = HttpContext.Connection.RemoteIpAddress?.ToString(),
            Port = HttpContext.Connection.RemotePort,
            Browser = ParseBrowser(userAgent),
            OperatingSystem = ParseOs(userAgent),
            UserAgent = userAgent,
            Language = Request.Headers.AcceptLanguage.ToString(),
            Host = Request.Host.ToString(),
            Referer = Request.Headers.Referer.ToString(),
            Protocol = Request.Protocol,
            ConnectionId = HttpContext.Connection.Id,
            Timestamp = DateTime.UtcNow,
            CreepyLink = "https://ic6do.com/gafRuY_update_info"
        };

        return Ok(ipInfo);
    }

    private static string ParseBrowser(string ua)
    {
        if (ua.Contains("Edg")) return "Microsoft Edge";
        if (ua.Contains("Chrome")) return "Google Chrome";
        if (ua.Contains("Firefox")) return "Mozilla Firefox";
        if (ua.Contains("Safari")) return "Apple Safari";
        if (ua.Contains("Opera") || ua.Contains("OPR")) return "Opera";
        return "Unknown";
    }

    private static string ParseOs(string ua)
    {
        if (ua.Contains("Windows")) return "Windows";
        if (ua.Contains("Mac OS")) return "macOS";
        if (ua.Contains("Linux")) return "Linux";
        if (ua.Contains("Android")) return "Android";
        if (ua.Contains("iPhone") || ua.Contains("iPad")) return "iOS";
        return "Unknown";
    }
}
