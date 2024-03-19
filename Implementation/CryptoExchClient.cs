using Binance.Net.Clients;
using Bybit.Net.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCryptoСomparer.Implementation
{
    public class CryptoExchClient
    {
        protected async Task<string> GetTicketByRestAsync(string ticket)
        {
            var restClient = new BinanceRestClient();
            try
            {
                var tickerResult = await restClient.SpotApi.ExchangeData.GetTickerAsync(ticket);
                var lastPrice = tickerResult.Data.LastPrice;
                return lastPrice.ToString();
            }
            catch (Exception)
            {
                return "Ошибка получения данных";
            }
        }

        protected async Task<string> GetBTCByRestV5ApiAsync(string ticket)
        {
            var restClient = new BybitRestClient();
            try
            {
                var tickerResult = await restClient.V5Api.ExchangeData.GetSpotTickersAsync(ticket);
                var lastPrice = tickerResult.Data.List.First().LastPrice;
                return lastPrice.ToString();
            }
            catch (Exception)
            {
                return "Ошибка получения данных";
            }
        }

    }
}
