using System;
using Xunit;

namespace Nutshell.Ch3CreatingTypes
{
    internal class Stack<T>
    {
        private int _position;
        private T[] data = new T[100];
        public void Push(T obj)
        {
            data[_position] = obj;
            _position++;
        }

        public T Pop()
        {
            _position--;
            return data[_position];
        }
    }

    public class Generics
    {
        [Fact]
        private void Stack()
        {
            //Arrange
            var stack = new Stack<int>();
            stack.Push(5);
            stack.Push(10);
            //Act
            var x = stack.Pop();
            var y = stack.Pop();
            //Assert
            Assert.Equal(10,x);
            Assert.Equal(5,y);
        }

        private static void Swap<T>(ref T a, ref T b)
        {
            var temp = a;
            a = b;
            b = temp;
        }
        
        [Fact]
        private void SwapTest()
        {
            //Arrange
            var a = 3;
            var b = 5;
            //Act
            Swap(ref a,ref b);

            //Assert
            Assert.Equal(5,a);
            Assert.Equal(3,b);
        }

        private static T Max<T>(T a, T b) where T : IComparable<T>
        {
            var compareResult = a.CompareTo(b);
            return  compareResult > 0 ? a : b;
        }
        
        [Fact]
        private void MaxTest()
        {
            //Arrange

            //Act
            var numbers = Max<int>(10, 5);

            //Assert
            Assert.Equal(10,numbers);
        }
    }
}