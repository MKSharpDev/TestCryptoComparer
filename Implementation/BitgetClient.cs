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
    public class BitgetClient : CryptoExchClient, IGetTicker
    {

        public async Task<string> GetBTCByRestAsync()
        {
            return await GetTicketByRestAsync("BTCUSDT_SPBL");
        }

        public async Task<string> GetETHByRestAsync()
        {
            return await GetTicketByRestAsync("ETHUSDT_SPBL");
        } 
    }
}
