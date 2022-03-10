using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace SimbirSoft_Appl.Middlewares
{
    /// <summary>
    /// 2.2.3 Логгирование с помощью ILogger
    /// </summary>
    public class Logger
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<Logger> _logger;

        public Logger(RequestDelegate next, ILogger<Logger> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            string startTime = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fffzzz");

            await _next(httpContext);

            string EndTime = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fffzzz");

            string log = $"Начало запроса: {startTime} :::: Конец запроса: {EndTime}";

            _logger.LogInformation(log);
        }
    }
}
