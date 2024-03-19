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
    public class BitgetClient : IGetTickerByRest
    {
        public async Task<string> GetBTCByRestAsync()
        {
            var restClient = new BitgetRestClient();
            try
            {
                var tickerResult = await restClient.SpotApi.ExchangeData.GetTickerAsync("BTCUSDT_SPBL");
                if (tickerResult.Data == null)
                {
                    throw new Exception();
                }
                var lastPrice = tickerResult.Data.ClosePrice;
                return lastPrice.ToString();
            }
            catch (NullReferenceException)
            {
                return "Ошибка";
            }
            catch (Exception)
            {
                return "Ошибка получения данных";
            }
        }     
    }
}
