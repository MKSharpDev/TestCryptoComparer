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
    public class KucoinClient : IGetTicker
    {
        public async Task<string> GetBTCByRestAsync()
        {
            return await GetTicketByRestAsync("BTC-USDT");
        }

        public async Task<string> GetETHByRestAsync()
        {
            return await GetTicketByRestAsync("ETH-USDT");
        }

        public async Task<string> GetTicketByRestAsync(string ticker)
        {

            var restClient = new KucoinRestClient();
            try
            {
                var tickerResult = await restClient.SpotApi.ExchangeData.GetTickerAsync(ticker);

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
