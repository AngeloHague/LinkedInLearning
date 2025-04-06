using Microsoft.AspNetCore.SignalR;

public class SalesHub : Hub
{

    record Response(string Amount, string Employee);

    public async Task PostNewSale(string amount, string employee)
    {
        if (decimal.TryParse(amount, out decimal amountValue) && amountValue > 1000)
        {
            Response res = new Response(amount, employee);
            await Clients.All.SendAsync("ReceiveNewHighSale", res);
        }
    }
}