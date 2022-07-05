using TestLibrary.Interface;
using TestLibrary.Services;
using Xunit;

namespace TestProject1
{
    public class UnitTest2
    {
        private readonly IFigure _circleService;
        public UnitTest2()
        {
            _circleService = new CircleService();
        }
        [Fact]
        public async Task Test1()
        {
            //Arrange
            var arrange = 78.5;
            //Act
            var result = await _circleService.GetArea(new List<double>() { 5 });
            //Assert
            Assert.Equal(arrange, result);
        }
    }
}
