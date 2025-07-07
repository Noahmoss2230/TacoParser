using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldReturnNonNullObject()
        {
            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("34.087508, -84.575512, Taco Bell Acworth...",84.575512)]
        [InlineData("34.795116,-86.97191,Taco Bell Athens...",86.97191)]
        [InlineData("34.996237,-85.291147,Taco Bell Chattanooga...",85.291147)]
        [InlineData("30.392476,-86.498396,Taco Bell Desti...", 86.498396)]
        //Add additional inline data. Refer to your CSV file.
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete the test with Arrange, Act, Assert steps below.
            //       Note: "line" string represents input data we will Parse 
            //       to extract the Longitude.  
            //       Each "line" from your .csv file
            //       represents a TacoBell location

            //Arrange
            var tacoParserInstance = new TacoParser();

            //Act
            var actual = tacoParserInstance.Parse(line).Location.Longitude;
            
            //Assert
            Assert.Equal(expected, actual);
        }


        //TODO: Create a test called ShouldParseLatitude
        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...",34.073638)]
        [InlineData("34.087508, -84.575512, Taco Bell Acworth...",34.087508)]
        [InlineData("34.795116,-86.97191,Taco Bell Athens...",34.795116)]
        [InlineData("34.996237,-85.291147,Taco Bell Chattanooga...",34.996237)]
        [InlineData("30.392476,-86.498396,Taco Bell Desti...", 30.392476)]
        //Add additional inline data. Refer to your CSV file.
        public void ShouldParseLatitude(string line, double expected)
        {
            // TODO: Complete the test with Arrange, Act, Assert steps below.
            //       Note: "line" string represents input data we will Parse 
            //       to extract the Longitude.  
            //       Each "line" from your .csv file
            //       represents a TacoBell location

            //Arrange
            var tacoParserInstance = new TacoParser();

            //Act
            var actual = tacoParserInstance.Parse(line);
            
            //Assert
            Assert.Equal(expected, actual.Location.Latitude);
        }
    }
}
