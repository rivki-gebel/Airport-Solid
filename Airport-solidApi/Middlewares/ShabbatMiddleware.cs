namespace Airport_solidApi.Middlewares
{
    public class ShabbatMiddleware
    {
        private readonly RequestDelegate _next;

        public ShabbatMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            await Console.Out.WriteLineAsync("in middleware");
            if (DateTime.Today.DayOfWeek == DayOfWeek.Saturday)
            {
                context.Response.StatusCode = StatusCodes.Status403Forbidden; // 403 Forbidden
                await context.Response.WriteAsync("Access forbidden: The application is not available on Saturdays.");
            }
            else
            {
                await _next(context);
            }
        }
    }
}
