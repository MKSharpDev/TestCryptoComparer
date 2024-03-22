using Binance.Net.Clients;
using Binance.Net.Interfaces;
using TestCryptoСomparerClassLibrary.Abstractions;

namespace TestCryptoСomparerClassLibrary.Implementation
{
    public class BinanceClient :  BaseClient<IBinanceTick>, IGetTickerByRest
    {
        public BinanceClient()
        {

            var restClient = new BinanceRestClient();
            this.WebCall = restClient.SpotApi.ExchangeData.GetTickerAsync;

            //this.Ticker = ticker;
        }
        public async Task<string> GetTicketByRestAsync(string ticker,CancellationToken token)
        {         
            switch (ticker)
            {
                case "BTCUSDT":
                    return await BaseGetTicketByRestAsync("BTCUSDT", token);
                case "ETHUSDT":
                    return await BaseGetTicketByRestAsync("ETHUSDT", token);
                default:
                    return "не задан тикер";
            }
        }
    }
}
