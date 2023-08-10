namespace NanofSignalRTesterServer
{
    public class Program
    {

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddSignalR(o =>
            {
                o.EnableDetailedErrors = true;
                o.MaximumReceiveMessageSize = 200000; // bytes
            });

            var app = builder.Build();

            app.MapGet("/", () => "SignalR Hub is running!");
            app.MapHub<SignalRHub>("/DirectMessage");

            app.Run();
        }
    }
}