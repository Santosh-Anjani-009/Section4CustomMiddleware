namespace Section4CustomMiddleware
{
    public class Note
    {
        /*
         
        Suppose your middleware has to execute some large amount of code so it has larger responsibility, in that case it would doesn't make sense to write all of 
        that code inside the same file that is in the program.cs file itself, so then it would be better to separate the same as a separate class and keeping it in 
        a separate file and that is exactly called as custom middleware class.

        So a custom middleware class is used to separate the middleware logic into a separate reusable class and by default the middleware class has to implement 
        an interface called "IMiddleware" in order to register that this class is a middleware and this "IMiddleware" interface forces us to write "InvokeAsync" 
        method which will be executed when the request reaches to that particular middleware.
        
        // Syntax of  "InvokeAsync" method
        // public async Task InvokeAsync( HttpContext context, RequestDelegate next)
        // {
        //    ....before logic
        //     await next( context ) // -- Optionally you can invoke the subsequent middleware by using this next
        //    ...... after logic
        // }
        // 1. Tt receives two arguments that is context and next, so you can access the properties such as request and response by using this context object
        // 2. 
         
         
         */
    }
}
