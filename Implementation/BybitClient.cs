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
    public class BybitClient :  IGetTicker
    {

        public async Task<string> GetBTCByRestAsync()
        {
            return await GetTickerByRestV5ApiAsync("BTCUSDT");
        }

        public async Task<string> GetETHByRestAsync()
        {
            return await GetTickerByRestV5ApiAsync("USDT");
        }


        public async Task<string> GetTickerByRestV5ApiAsync(string ticker)
        {
            var restClient = new BybitRestClient();
            try
            {
                var tickerResult = await restClient.V5Api.ExchangeData.GetSpotTickersAsync(ticker);
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
