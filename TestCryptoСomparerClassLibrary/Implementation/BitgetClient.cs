using Bitget.Net.Clients;
using Bitget.Net.Objects.Models;
using CryptoExchange.Net.Objects.Sockets;


namespace TestCryptoСomparerClassLibrary.Implementation
{
    public class BitgetClient : BaseClient<BitgetTicker>
    {

        public BitgetClient()
        {
            var restClient = new BitgetRestClient();
            this.WebCall = restClient.SpotApi.ExchangeData.GetTickerAsync;
        }
        public override async Task<string> GetTicketByRestAsync(string ticker, CancellationToken token)
        {
            string tickerEdit; 
            switch (ticker)
            {
                case "BTCUSDT":
                    tickerEdit = "BTCUSDT_SPBL";
                    break;
                case "ETHUSDT":
                    tickerEdit = "ETHUSDT_SPBL";
                    break;
                default:
                    tickerEdit = "не задан тикер";
                    break;
            }
            
            return await BaseGetTicketByRestAsync(tickerEdit, token);
        }

        public override async Task GetTicketBySocketAsync(string ticker, CancellationToken token)
        {
            await SocketAsync(ticker, token);
        }

        private async Task SocketAsync(string ticker, CancellationToken token)
        {
            string tickerEdit = GetTickerName(ticker);

            var socketClient = new BitgetSocketClient();

            var res = await socketClient.SpotApi.SubscribeToTickerUpdatesAsync(tickerEdit, onMessage, token);
            if (!res.Success)
            {
                this.Price = "ошибка";
            }

            void onMessage(DataEvent<BitgetTickerUpdate> update)
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
