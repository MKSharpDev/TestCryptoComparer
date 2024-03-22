using Bitget.Net.Clients;
using Bitget.Net.Objects.Models;
using TestCryptoСomparerClassLibrary.Abstractions;

namespace TestCryptoСomparerClassLibrary.Implementation
{
    public class BitgetClient : BaseClient<BitgetTicker>, IGetTickerByRest
    {
        public BitgetClient()
        {

            var restClient = new BitgetRestClient();
            this.WebCall = restClient.SpotApi.ExchangeData.GetTickerAsync;

            //this.Ticker = ticker;
        }
        public async Task<string> GetTicketByRestAsync(string ticker, CancellationToken token)
        {
            switch (ticker)
            {
                case "BTCUSDT":
                    return await BaseGetTicketByRestAsync("BTCUSDT_SPBL", token);
                case "ETHUSDT":
                    return await BaseGetTicketByRestAsync("ETHUSDT_SPBL", token);
                default:
                    return "не задан тикер";
            }
        }
    }
}
