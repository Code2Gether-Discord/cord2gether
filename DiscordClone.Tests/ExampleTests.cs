namespace DiscordClone.Tests
{
    public class ExampleTests
    {
        //SUT = System Under Test
        private int[] sut = new[] { 1, 4, 5 };
        
        [Fact]
        public void MyFirstUnitTest_Should_ShowYouOnlyCommentsOfTestDrivenDevelopment()
        {
         //Arrange
         var data = sut;

         //Act
         var result = Enumerable.Sum(data);
         //Assert
         
        }


        [Theory]
        [InlineData(new int[] {1,1}, 2)]
        [InlineData(new int[] { 2, 2 }, 4)]
        [InlineData(new int[] { 3, 3 }, 6)]
        public void MySecondUnitTest_Should_ShowYouHowToUseInlineData(int[] values, int result)
        {
            //Act
            var sumOfArray = Enumerable.Sum(values);
            //Assert
            sumOfArray.Should().Be(result);
        }
    }
}