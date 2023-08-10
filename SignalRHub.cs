using Microsoft.AspNetCore.SignalR;
using System.Diagnostics;

namespace NanofSignalRTesterServer
{
    public class SignalRHub : Hub
    {

        public override async Task OnConnectedAsync()
        {

            await base.OnConnectedAsync();

            Debug.WriteLine($"Device added");
        }

        // Override OnDisconnectedAsync to handle when a client disconnects
        public override async Task OnDisconnectedAsync(Exception exception)
        {

            await base.OnDisconnectedAsync(exception);

            Debug.WriteLine($"Device removed");
        }

    }
}
