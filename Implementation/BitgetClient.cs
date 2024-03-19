using Binance.Net.Clients;
using Bitget.Net.Clients;
using Kucoin.Net.Clients;
using Microsoft.VisualBasic;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCryptoСomparer.Abstractions;
using static System.Net.Mime.MediaTypeNames;

namespace TestCryptoСomparer.Implementation
{
    public class BitgetClient : IGetTicker
    {

        public async Task<string> GetBTCByRestAsync()
        {
            return await GetTicketByRestAsync("BTCUSDT_SPBL");
        }

        public async Task<string> GetETHByRestAsync()
        {
            return await GetTicketByRestAsync("ETHUSDT_SPBL");
        }

        public async Task<string> GetTicketByRestAsync(string ticker)
        {
            var restClient = new BitgetRestClient();
            try
            {
                var tickerResult = await restClient.SpotApi.ExchangeData.GetTickerAsync(ticker);
                if (tickerResult.Data == null)
                {
                    throw new Exception();
                }
                var lastPrice = tickerResult.Data.ClosePrice;
                return lastPrice.ToString();
            }
            catch (Exception)
            {
                return "Ошибка получения данных";
            }
        }     
    }
}
