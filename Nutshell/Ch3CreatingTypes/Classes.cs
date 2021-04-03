using System;
using Xunit;

namespace Nutshell.Ch3CreatingTypes
{
    class ConstantAndReadOnly
    {
        private readonly int _readOnly1 = 1; //Field initialization is optional. An uninitialized field has a default value (0, \0, null,false).
                                            //Field initializers run before constructors:
                                            
        private readonly int _readOnly2; //The readonly modifier prevents a field from being modified after construction.
                                        //read-only field can be assigned only in its declaration or within the enclosing type’s constructor
                                        
        public const string Message = "Hello World"; //A constant is declared with the const keyword and must be initialized with a value.
        //A constant also differs from a static readonly field in that the evaluation of the constant occurs at compile time
        //It makes sense for PI to be a constant because its value is predetermined at compile time.
        //In contrast, a static readonly field’s value can potentially differ each time the program is run:
        static readonly DateTime StartupTime = DateTime.Now;

        ConstantAndReadOnly(int readOnly2)
        {
            _readOnly2 = readOnly2;
        }
        
        //Constants can also be declared local to a method
        private void Test()
        {
            const double twoPI = 2 * System.Math.PI;
        }
    }

    class Methods
    {
        private int Square(int x)
        {
            var y = x;
            static int SquareLocal(int y) => y * y; //local method
            return SquareLocal(y);
        }

        private int Cube (int x) => x * x * x; //Can be written more tersely as an expression-bodied method.
                                               //A fat arrow replaces the braces and return keyword
        private double Cube(double y) => y * y * y; //Overloaded method, return type can be the same
    }
    public class ConstructorAndDeconstructor
    {
        private readonly DateTime _fieldInitialization = DateTime.Now;
        private readonly DateTime _firstConstructor;
        private readonly DateTime _secondConstructor;
        private static readonly DateTime _staticConstructor;
        private static readonly DateTime _staticField = DateTime.Now;

        static ConstructorAndDeconstructor()
        {
            _staticConstructor = DateTime.Now;
        }
        ConstructorAndDeconstructor()
        {
            _firstConstructor = DateTime.Now;
        }

        public ConstructorAndDeconstructor(string s) : this()
        {
            _secondConstructor = DateTime.Now;
        }

        public void Deconstruct(out DateTime fieldInitialization, out DateTime firstConstructor,
            out DateTime secondConstructor, out DateTime deconstructor,
            out DateTime staticField, out DateTime staticConstructor)
        {
            deconstructor = DateTime.Now;
            fieldInitialization = _fieldInitialization;
            firstConstructor = _firstConstructor;
            secondConstructor = _secondConstructor;
            staticField = _staticField;
            staticConstructor = _staticConstructor;
        }
    }
    public class Accessors
    {
        private decimal _currentPrice;
        public decimal Discount { get; set; }
        public decimal CurrentPrice
        {
            get => _currentPrice*Discount;
            set => _currentPrice = value;
        }
    }
    
    public class Indexers
    {
        private string[] s = "Hello from class".Split();

        public string this [Index index] => s [index];
        public string[] this [Range range] => s [range];

    }

    public class Classes
    {
        [Fact]
        public void Indexers()
        {
            //Arrang
            var f = new Indexers();
            
            //Act
            var twoLastElements = f[1..];
            
            //Assert
            Assert.Equal("Hello", f[0]);
            Assert.Equal("class", f[^1]);
            Assert.Equal(new string[]{"from","class"}, twoLastElements);
        }
        
        [Fact]
        public void Accessors()
        {
            //Arrang
            var f = new Accessors();
            
            //Act
            f.Discount = 0.95m;
            f.CurrentPrice = 100;
            

            //Assert
            Assert.Equal(f.CurrentPrice, f.CurrentPrice);
        }
        
        [Fact]
        public void ConstructorAndParametersInitialization()
        {
            //Arrang
            var c = new ConstructorAndDeconstructor("");

            //Act
            var (fieldInitialization, firstConstructor, 
                secondConstructor, deconstructor, 
                staticField,staticConstructor) = c;

            //Assert
            Assert.True(staticField < staticConstructor);
            Assert.True(staticConstructor < fieldInitialization);
            Assert.True(fieldInitialization < firstConstructor);
            Assert.True(firstConstructor < secondConstructor);
            Assert.True(secondConstructor < deconstructor);

        }
    }
}