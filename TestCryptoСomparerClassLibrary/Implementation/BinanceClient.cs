using Binance.Net.Clients;
using Binance.Net.Interfaces;
using CryptoExchange.Net.Objects.Sockets;

namespace TestCryptoСomparerClassLibrary.Implementation
{
    public class BinanceClient :  BaseClient<IBinanceTick>
    {
        public BinanceClient()
        {
            var restClient = new BinanceRestClient();
            this.WebCall = restClient.SpotApi.ExchangeData.GetTickerAsync;

        }
        public override async Task<string> GetTicketByRestAsync(string ticker,CancellationToken token)
        {
            var editTicket = GetTickerName(ticker);
            if (editTicket == "не задан тикер")
            {
                return editTicket;
            }
            return await BaseGetTicketByRestAsync(editTicket, token);
        }

        public override async Task GetTicketBySocketAsync(string ticker, CancellationToken token)
        {
            await SocketAsync(ticker, token);
        }


        private async Task SocketAsync(string ticker, CancellationToken token)
        {
            
            var socketClient = new BinanceSocketClient();

            var res = await socketClient.SpotApi.ExchangeData.SubscribeToTickerUpdatesAsync(GetTickerName(ticker), onMessage, token);
            if (!res.Success)
            {
                this.Price = "ошибка";
            }

            void onMessage(DataEvent<IBinanceTick> update)
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
