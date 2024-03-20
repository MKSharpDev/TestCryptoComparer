﻿using Binance.Net.Interfaces;
using Bybit.Net.Objects.Models.V5;
using CryptoExchange.Net.Objects;
using TestCryptoСomparer.Abstractions;
using Bitget.Net.Objects.Models;
using Kucoin.Net.Objects.Models.Spot;


namespace TestCryptoСomparer.Implementation
{
    public class BaseClient<T> : IGetTicker
    {
        protected delegate Task<WebCallResult<T>> BaseCall (string str, CancellationToken token);
        //public string Ticker {  get; set; }

        protected BaseCall WebCall;

        public async Task<string> BaseGetTicketByRestAsync(string ticker, CancellationToken cancellationToken)
        {
            decimal? lastPrice = 0m;
            try
            {
                var tickerResult = await WebCall(ticker, cancellationToken);
                if (tickerResult is WebCallResult<BitgetTicker> BitgetvCallResult && tickerResult.Data != null)
                {
                    lastPrice = BitgetvCallResult.Data.ClosePrice;
                }
                else if(tickerResult is WebCallResult<BybitResponse<BybitSpotTicker>> BybitCallResult && tickerResult.Data != null)
                {
                    lastPrice = BybitCallResult.Data.List.First().LastPrice;
                }
                else if(tickerResult is WebCallResult<KucoinTick> KucoinCallResult && tickerResult.Data != null)
                {
                    lastPrice = KucoinCallResult.Data.LastPrice;
                }
                else if (tickerResult is WebCallResult<IBinanceTick> BinanceCallResult && tickerResult.Data != null)
                {
                    lastPrice = BinanceCallResult.Data.LastPrice;
                }
                return lastPrice.ToString();
            }
            catch (Exception)
            {
                return "Ошибка получения данных";
            }

        }

    }
}
