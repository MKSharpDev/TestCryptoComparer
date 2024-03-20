using Binance.Net.Clients;
using Bybit.Net.Clients;
using Kucoin.Net.Clients;
using Kucoin.Net.Objects.Models.Spot;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCryptoСomparer.Abstractions;
using static System.Net.Mime.MediaTypeNames;

namespace TestCryptoСomparer.Implementation
{
    public class KucoinClient : BaseClient<KucoinTick> , IGetTickerByRest
    {
        public KucoinClient()
        {
            KucoinRestClient restClient = new KucoinRestClient();
            this.WebCall = restClient.SpotApi.ExchangeData.GetTickerAsync;

            //this.Ticker = ticker;
        }
        public async Task<string> GetTicketByRestAsync(string ticker, CancellationToken token)
        {
            switch (ticker)
            {
                case "BTCUSDT":
                    return await BaseGetTicketByRestAsync("BTC-USDT", token);
                case "ETHUSDT":
                    return await BaseGetTicketByRestAsync("ETH-USDT", token);
                default:
                    return "не задан тикер";
            }
        }
    }
}
