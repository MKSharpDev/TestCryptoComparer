using Binance.Net.Clients;
using Bitget.Net.Clients;
using Bybit.Net.Clients;
using Bybit.Net.Objects.Models.V5;
using Kucoin.Net.Clients;
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
