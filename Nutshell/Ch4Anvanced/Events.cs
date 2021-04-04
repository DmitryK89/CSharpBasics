using System;
using Nutshell.Ch3CreatingTypes;
using Xunit;

namespace Nutshell.Ch4Anvanced
{
    //Delegate definition
    public delegate void PriceChangedEventHandler(decimal oldPrice,
                                                    decimal newPrice);

    public class BroadcasterStock
    {
        private string _symbol;

        public BroadcasterStock(string symbol)
        {
            _symbol = symbol;  
        }
        
        private decimal _price;

        public decimal Price
        {
            get => _price;
            set
            {
                if (_price == value) return;
                decimal oldPrice = _price;
                _price = value;
               OnPriceChanged(new PriceChangedEventArgs(oldPrice,_price));
            }
        }

        //Event declaration
        //public event PriceChangedEventHandler PriceChanged;
        
        public event EventHandler<PriceChangedEventArgs> PriceChanged;
        
        protected virtual void OnPriceChanged (PriceChangedEventArgs e)
        {
            PriceChanged?.Invoke (this, e);
        }
    }

    public class PriceChangedEventArgs : System.EventArgs
    {
        public readonly decimal LastPrice;
        public readonly decimal NewPrice;

        public PriceChangedEventArgs(decimal lastPrice, decimal newPrice)
        {
            LastPrice = lastPrice;
            NewPrice = newPrice;
        }
    }
    
    public class Events
    {
        private string _result;
        
        [Fact]
        public void TestEvents()
        {
            var s = new BroadcasterStock ("Stock");
            s.Price = 27.10M;
            s.PriceChanged += OnPriceChanged;
            Assert.Null(_result);
            s.Price = 31.59M; //Event happened
            Assert.Equal("Alert",_result);
        }

        private void OnPriceChanged(object? sender, PriceChangedEventArgs e)
        {
            if ((e.NewPrice - e.LastPrice) / e.LastPrice > 0.1M) _result = "Alert";
        }
    }
}