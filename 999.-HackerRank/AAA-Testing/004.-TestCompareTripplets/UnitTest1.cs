using FluentAssertions;

namespace _004._TestCompareTripplets
{
    public class UnitTest1
    {
        //[Fact]
        //public void Test1()
        //{
        //    // Arrange
        //    List<int> a = new List<int> { 1, 2, 3 };
        //    List<int> b = new List<int> { 3, 2, 1 };

        //    // Act
        //    List<int> result = _004._CompareTripplets.Result.CompareTripplets(a, b);

        //    // Assert
        //    Assert.Equal(new List<int> { 1, 1 }, result);
        //}

        [Theory]
        [InlineData(new[] { 1, 2, 3 }, new[] { 3, 2, 1 }, new[] { 1, 1})]
        [InlineData(new[] { 4, 5, 6 }, new[] { 6, 7, 8 }, new[] { 0, 3 })]
        [InlineData(new[] { 10,10,10 }, new[] { 6, 7, 8 }, new[] { 3, 0 })]
        [InlineData(new[] { 10, 10, 10 }, new[] { 10,10,10}, new[] { 0, 0 })]
        public void MyTestMethod(int[] a, int[] b, int[] pResultadoEsperado)
        {
            //// Arrange
            //List<int> a = new List<int> { 1, 2, 3 };
            //List<int> b = new List<int> { 3, 2, 1 };

            // Act
            List<int> result = _004._CompareTripplets.Result.CompareTripplets(a.ToList(), b.ToList());

            // Assert
            //Assert.Equal(pResultadoEsperado, result);

            //result.Should().BeEquivalentTo(pResultadoEsperado);
            result.Should().BeEquivalentTo(pResultadoEsperado);
        }



    }
}