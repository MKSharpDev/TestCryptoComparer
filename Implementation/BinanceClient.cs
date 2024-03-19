using Binance.Net.Clients;
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
    public class BinanceClient: IGetTickerByRest
    {
        public async Task<string> GetBTCByRestAsync( )
        {
            var restClient = new BinanceRestClient();
            try
            {
                var tickerResult = await restClient.SpotApi.ExchangeData.GetTickerAsync("BTCUSDT");
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
