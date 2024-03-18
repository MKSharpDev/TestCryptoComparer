using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCryptoСomparer.Abstractions
{
    internal interface IGetTickerByRest
    {
        public  Task GetBTCByRestAsync(CancellationToken token);
    }
}
