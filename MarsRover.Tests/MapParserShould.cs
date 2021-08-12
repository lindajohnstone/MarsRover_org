using System.Collections.Generic;
using Xunit;

namespace MarsRover.Tests
{
    public class MapParserShould
    {
        [Fact]
        public void ReturnMap_GivenValidString() // TODO: what has not been setup correctly? doesn't show squiggly lines on errors or suggestions
        {
            var squares = new List<Square>
            {
                new Square(SquareContent.Obstacle, 0, 0),
                new Square(SquareContent.Empty, 1, 0),
                new Square(SquareContent.Empty, 2, 0),
                new Square(SquareContent.Empty, 0, 1),
                new Square(SquareContent.Empty, 1, 1),
                new Square(SquareContent.Empty,2, 1),
                new Square(SquareContent.Empty, 0, 2),
                new Square(SquareContent.Empty, 1, 2),
                new Square(SquareContent.Empty, 2, 2)
            };
            var expected = new Map(3, 3, squares);

        }
    }
}