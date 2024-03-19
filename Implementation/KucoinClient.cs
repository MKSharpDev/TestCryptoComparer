using Binance.Net.Clients;
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
    public class KucoinClient : IGetTickerByRest
    {
        public async Task<string> GetBTCByRestAsync()
        {
            var restClient = new KucoinRestClient();
            try
            {
                var tickerResult = await restClient.SpotApi.ExchangeData.GetTickerAsync("BTC-USDT");

                var lastPrice = tickerResult.Data.LastPrice;
                return lastPrice.ToString();
            }
            catch (Exception)
            {
                return "Ошибка получения данных";
            }
        }
    }
}
