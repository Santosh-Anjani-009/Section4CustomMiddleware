namespace Section4CustomMiddleware.CustomMiddleware
{
    // Step 1. Create a custome middleware
    public class MyCustomMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("my custome middleware start");

            await next(context); // Optionally we are invoking the subsequent middleware so we are calling the next and we have to supply the context as argument so that the subsequent middleware whichever is present can receive this context as argument over there.

            await context.Response.WriteAsync("my custome middleware Ended"); // After completion of that subsequent middleware control will comes back here and execute this line of code.
                   
        }
    }

    // Note: Now we have successfully created the custom middleware now we have to register this custom middleware class as a service which will be done in Program.cs class.

}
