using Bybit.Net.Clients;
using Bybit.Net.Objects.Models.V5;
using TestCryptoСomparerClassLibrary.Abstractions;

namespace TestCryptoСomparerClassLibrary.Implementation
{
    public class BybitClient :  BaseClient<BybitResponse<BybitSpotTicker>>, IGetTickerByRest
    {
        public BybitClient()
        {
            var restClient = new BybitRestClient();
            this.WebCall = restClient.V5Api.ExchangeData.GetSpotTickersAsync;

            //this.Ticker = ticker;
        }
        public async Task<string> GetTicketByRestAsync(string ticker, CancellationToken token)
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
