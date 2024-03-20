using Binance.Net.Clients;
using Binance.Net.Interfaces;
using CryptoExchange.Net.Interfaces;
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
    public class BinanceClient :  BaseClient<IBinanceTick>, IGetTickerByRest
    {
        public BinanceClient()
        {

            var restClient = new BinanceRestClient();
            this.WebCall = restClient.SpotApi.ExchangeData.GetTickerAsync;

            //this.Ticker = ticker;
        }
        public async Task<string> GetTicketByRestAsync(string ticker,CancellationToken token)
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
