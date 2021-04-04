using System;
using Xunit;

namespace Nutshell.Ch4Anvanced
{
    public class Delegates
    {
        private delegate int Transformer(int x);

        int Square(int x) => x * x;
        int Cube (int x) => x * x * x;
        
        [Fact]
        private void BasicDelegateTest()
        {
            //Arrange
            Transformer t = new Transformer(Square);
            
            //Act
            var result = t.Invoke(3);
            
            //Assert
            Assert.Equal(9,result);
        }
        
        [Fact]
        private void TransformTest()
        {
            //Arrange
            void Transform(int[] values, Transformer t)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = t.Invoke(values[i]);
                }
            }

            int[] values = new int[] {1, 2, 3};
            
            //Act
            Transform(values, Square);
            
            //Assert
            Assert.Equal(new int[]{1,4,9},values);
        }
        
        public delegate string ProgressReporter (int percentComplete);
        class MyReporter
        {
            public string Prefix = "";
            public string ReportProgress (int percentComplete)
                => Prefix + percentComplete;
        }
        
        [Fact]
        private void MethodInstnceTest()
        {
            //Arrange
            var r = new MyReporter();
            r.Prefix = "%Complete: ";
            var p = new ProgressReporter(r.ReportProgress);
           
            //Act
            string result = p(99);
            bool isTarget = p.Target == r;
            string method = p.Method.ToString();
            
            //Assert
            Assert.Equal("%Complete: 99",result);
            Assert.True(isTarget);
            Assert.Equal("System.String ReportProgress(Int32)",method);
        }

        public delegate T GenericTransformer<T>(T arg);
        
        [Fact]
        private void GenericTransformTest()
        {
            //Arrange
            void Transform<T>(T[] values, GenericTransformer<T> t)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = t.Invoke(values[i]);
                }
            }

            int[] values = new int[] {1, 2, 3};
            
            //Act
            Transform(values, Square);
            
            //Assert
            Assert.Equal(new int[]{1,4,9},values);
        }
        
        [Fact]
        private void FuncTransformTest()
        {
            //Arrange
            void Transform<T>(T[] values, Func<T,T> t)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = t.Invoke(values[i]);
                }
            }

            int[] values = new int[] {1, 2, 3};
            
            //Act
            Transform(values, Square);
            
            //Assert
            Assert.Equal(new int[]{1,4,9},values);
        }
        
    }
}