namespace TestCryptoСomparerClassLibrary.Abstractions
{
    public interface IGetTicker
    {
        public Task<string> GetTicketByRestAsync(string ticker, CancellationToken token);
        public Task GetTicketBySocketAsync(string ticker, CancellationToken token);

        public string? Price
        {
            get; set;
        }

    }
}
