using TestLibrary.Interface;
using TestLibrary.Services;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        private readonly IFigure _triangleService;
        public UnitTest1()
        {
            _triangleService = new TriangleService();
        }
        [Fact]
        public async Task Test1()
        {
            //Arrange
            var arrange = 6;
            //Act
            var result = await _triangleService.GetArea(new List<double>() { 3, 4, 5 });
            //Assert
            Assert.Equal(arrange, result);
        }
        [Fact]
        public async Task Test2()
        {
            //Act
            var result = await ((TriangleService)_triangleService).IsRectangular(new List<double>() { 3, 4, 5 });
            //Assert
            Assert.True(result);
        }
        [Fact]
        public async Task Test3()
        {
            //Act
            var result = await ((TriangleService)_triangleService).IsRectangular(new List<double>() { 4, 4, 6 });
            //Assert
            Assert.False(result);
        }
    }
}