using System;
using Xunit;

namespace Nutshell.Ch2LanguageBasics
{
    public class Arrays
    {
        private class PointClass
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
        
        [Fact]
        public void  Array()
        {
            //Arrange
            char[] vowels = new char[5]; // Declare an array of 5 characters
            vowels[0] = 'a';
            vowels[1] = 'e';
            vowels[2] = 'i';
            vowels[3] = 'o';
            vowels[4] = 'u';
            
            //Simple Initialization
            char[] vowels2 = new char[] {'a','e','i','o','u'};
            char[] vowels3 = {'a','e','i','o','u'};
            
            //Act
            
            //Assert
            Assert.Equal('a',vowels[0]); //Firs element array
            Assert.Equal('u',vowels[^1]); //Last element array
            Assert.Equal('o',vowels[^2]); //Firs element array
            Assert.Equal(5,vowels.Length);
            Assert.Throws<IndexOutOfRangeException>(() => vowels[6]);
        }
        
        [Fact]
        public void  ArrayDefaultInitializationValueType()
        {
            //Arrange
            int[] a = new int[1000];
            
            //Act
            
            //Assert
            Assert.Equal(0,a[123]);
        }
        
        [Fact]
        public void  ArrayDefaultInitializationReferenceType()
        {
            //Arrange
            var a = new PointClass[1000];
            
            //Act
            
            //Assert
            Assert.Throws<NullReferenceException>(() => a[500].X);
            
            //Act
           for (int i = 0; i < a.Length; i++) // Iterate i from 0 to 999
                a[i] = new PointClass(); // Set array element i with new point
            
            Assert.Equal(0,a[500].X);
        }
        
        [Fact]
        public void  RectangularArray()
        {
            //Arrange
            int[,] matrix = new int[3,3];
            
            for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
                matrix[i,j] = i * 3 + j;
            
            int[,] matrix2 = new int[,]
            {
                {0,1,2},
                {3,4,5},
                {6,7,8}
            };
            
            //Act
            
            //Assert

        }
        
        [Fact]
        public void  JaggedArray()
        {
            //Arrange
            int[][] matrix = new int[3][];
            
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new int[3]; // Create inner array
                for (int j = 0; j < matrix[i].Length; j++)
                    matrix[i][j] = i * 3 + j;
            }
            
            int[][] matrix2 = new int[][]
            {
                new int[] {0,1,2},
                new int[] {3,4,5},
                new int[] {6,7,8,9}
            };
            
            //Act
            
            //Assert

        }
    }
}