using Binance.Net.Clients;
using Binance.Net.Interfaces;
using Bitget.Net.Clients;
using Bitget.Net.Objects.Models;
using Kucoin.Net.Clients;
using Microsoft.VisualBasic;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCryptoComparerClassLibrary.Abstractions;
using static System.Net.Mime.MediaTypeNames;

namespace TestCryptoComparerClassLibrary.Implementation
{
    public class BitgetClient : BaseClient<BitgetTicker>, IGetTickerByRest
    {
        public BitgetClient()
        {

            var restClient = new BitgetRestClient();
            this.WebCall = restClient.SpotApi.ExchangeData.GetTickerAsync;

            //this.Ticker = ticker;
        }
        public async Task<string> GetTicketByRestAsync(string ticker, CancellationToken token)
        {
            switch (ticker)
            {
                case "BTCUSDT":
                    return await BaseGetTicketByRestAsync("BTCUSDT_SPBL", token);
                case "ETHUSDT":
                    return await BaseGetTicketByRestAsync("ETHUSDT_SPBL", token);
                default:
                    return "не задан тикер";
            }
        }
    }
}
