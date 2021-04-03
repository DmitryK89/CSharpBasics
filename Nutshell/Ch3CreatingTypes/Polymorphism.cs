using System;
using Xunit;

namespace Nutshell.Ch3CreatingTypes
{
    public class Asset
    {
        public string Name;
        public virtual decimal Liability => 0; // Expression-bodied property
    }
    
    public class Stock : Asset // inherits from Asset
    {
        public long SharesOwned;
    }
    public class House : Asset // inherits from Asset
    {
        public decimal Mortgage;
        public override decimal Liability => Mortgage;
    }
    
    public class Polymorphism
    {
        private Stock _msft;
        private House _mansion;
        
        public Polymorphism()
        {
            _msft = new Stock { Name="MSFT", SharesOwned=1000 };
            _mansion = new House { Name="Mansion", Mortgage=250000 };
        }
        
        [Fact]
        public void BaseClassMethodCheck()
        {
            //Arrange
            string Display (Asset asset)
            {
                return asset.Name;
            }
            
            //Act
            string msftName = Display(_msft);
            string mansionName = Display(_mansion);
            
            
           
            //Assert
            Assert.Equal("MSFT",msftName );
            Assert.Equal("Mansion", mansionName);
        }
        
        [Fact]
        public void Upcasting()
        {
            //Arrange
            
            //Act
            Asset a = _msft; //Upcasting
            
            //Assert
            Assert.IsType<Asset>(a);
        }
        
        [Fact]
        public void Downcasting()
        {
            //Arrange
            Stock msft = new Stock();
            msft.SharesOwned = 1;
            msft.Name = "msft";
            
            Asset a = msft; //Upcasting
            
            //Act
            Stock s = (Stock)a; //DownCasting
            
            //Assert
            Assert.IsType<Stock>(s);
        }
        
        [Fact]
        public void AsAndIs()
        {
            //Arrange
            Asset a = new Asset(); 
            
            //Act
            Func<Stock> b = () => (Stock)a;
            var c = a as Stock;
            var isAStock = a is Stock;
            
            //Assert
            Assert.Throws<InvalidCastException>(b);
            Assert.Null(c);
            Assert.False(isAStock);
        }
        
        [Fact]
        public void Virtual()
        {
            //Arrange
            House mansion = new House { Name="McMansion", Mortgage=250000 };
            Asset a = mansion;
            Asset b = new Asset();
            
            //Act
            var mansionLiability = mansion.Liability; // 250000
            var  assetLiability = a.Liability; // 250000
            
            //Assert
            Assert.Equal(250000,assetLiability);
            Assert.Equal(250000,mansionLiability);
            Assert.Equal(0,b.Liability);
        }
    }
}