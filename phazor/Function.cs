//using Amazon.Lambda.Core;
//using Amazon.Lambda.RuntimeSupport;
//using Amazon.Lambda.Serialization.Json;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.Extensions.Hosting;
//using System;
//using System.Threading.Tasks;


//namespace phazor
//{
//    public class Function
//    {
//        public static async Task Main(string[] args)
//        {
//            Func<string, ILambdaContext, string[]> func = FunctionHandler;
//            using (var handlerWrapper = HandlerWrapper.GetHandlerWrapper(func, new JsonSerializer()))
//            using (var bootstrap = new LambdaBootstrap(handlerWrapper))
//            {
//                await bootstrap.RunAsync();
//            }
//        }

//        public static IHostBuilder FunctionHandler(string input, ILambdaContext context, string[] args) =>
//            Host.CreateDefaultBuilder(args)
//            .ConfigureWebHostDefaults(webBuilder =>
//            {
//                webBuilder.UseStartup<Startup>();
//            });

//        }
//}
