using Bybit.Net.Clients;
using Bybit.Net.Objects.Models.V5;
using CryptoExchange.Net.Objects.Sockets;

namespace TestCryptoСomparerClassLibrary.Implementation
{
    public class BybitClient :  BaseClient<BybitResponse<BybitSpotTicker>>
    {
        public BybitClient()
        {
            var restClient = new BybitRestClient();
            this.WebCall = restClient.V5Api.ExchangeData.GetSpotTickersAsync;

        }
        public override async Task<string> GetTicketByRestAsync(string ticker, CancellationToken token)
        {
            var editTicket = GetTickerName(ticker);
            return await BaseGetTicketByRestAsync(editTicket, token);          
        }

        public override async Task GetTicketBySocketAsync(string ticker, CancellationToken token)
        {
            await SocketAsync(ticker, token);
        }
        public async Task SocketAsync(string ticker, CancellationToken token)
        {
            var socketClient1 = new BybitSocketClient();

            var res = await socketClient1.V5SpotApi.SubscribeToTickerUpdatesAsync(GetTickerName(ticker), onMessage, token);
            if (!res.Success)
            {
                this.Price = "ошибка";
            }

            void onMessage(DataEvent<BybitSpotTickerUpdate> update)
            {
                this.Price = update.Data.LastPrice.ToString();
            }
        }

        private string GetTickerName(string ticker)
        {
            switch (ticker)
            {
                case "BTCUSDT":
                    return "BTCUSDT";
                case "ETHUSDT":
                    return "ETHUSDT";
                default:
                    return "не задан тикер";
            }
        }
    }
}
