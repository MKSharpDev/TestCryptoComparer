using CryptoExchange.Net.Objects.Sockets;
using Kucoin.Net.Clients;
using Kucoin.Net.Objects.Models.Spot;
using Kucoin.Net.Objects.Models.Spot.Socket;

namespace TestCryptoСomparerClassLibrary.Implementation
{
    public class KucoinClient : BaseClient<KucoinTick>   
    {
        public KucoinClient()
        {
            KucoinRestClient restClient = new KucoinRestClient();
            this.WebCall = restClient.SpotApi.ExchangeData.GetTickerAsync;
        }

        public override async Task<string> GetTicketByRestAsync(string ticker, CancellationToken token)
        {
            var tickerEdit = GetTickerName(ticker);
            return await BaseGetTicketByRestAsync(tickerEdit, token);
        }

        public override async Task GetTicketBySocketAsync(string ticker, CancellationToken token)
        {
            await SocketAsync(ticker, token);
        }
        public async Task SocketAsync(string ticker, CancellationToken token)
        {
            var socketClient1 = new KucoinSocketClient();

            var res = await socketClient1.SpotApi.SubscribeToTickerUpdatesAsync(GetTickerName(ticker), onMessage, token);
            if (!res.Success)
            {
                this.Price = "ошибка";
            }

            void onMessage(DataEvent<KucoinStreamTick> update)
            {
                this.Price = update.Data.LastPrice.ToString();
            }
        }

        private string GetTickerName(string ticker)
        {
            switch (ticker)
            {
                case "BTCUSDT":
                    return "BTC-USDT";
                case "ETHUSDT":
                    return "ETH-USDT";
                default:
                    return "не задан тикер";
            }
        }
    }
}
