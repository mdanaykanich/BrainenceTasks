using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;
 
public class TestMiddleware
{
    private readonly RequestDelegate next;
 
    public TestMiddleware(RequestDelegate next)
    {
        this.next = next;
    }
 
    public async Task InvokeAsync(HttpContext context)
    {
        if (String.Equals(context.Request.Headers["TestTask"], "ping"))
        {
            context.Response.Headers.Add("TestTask", "pong");
        }
        await next.Invoke(context);
    }
}