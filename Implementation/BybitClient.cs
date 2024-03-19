using Binance.Net.Clients;
using Bitget.Net.Clients;
using Bybit.Net.Clients;
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
    public class BybitClient : IGetTickerByRest
    {
        public async Task<string> GetBTCByRestAsync()
        {
            var restClient = new BybitRestClient();
            try
            {
                var tickerResult = await restClient.V5Api.ExchangeData.GetSpotTickersAsync("BTCUSDT");
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
