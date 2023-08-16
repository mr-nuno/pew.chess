namespace PEW.Chess.UnitTests;

public class BoardTests
{
    [Fact]
    public void A_chess_board_should_have_64_squares()
    {
        var chessboard = Board.Build();
        
        chessboard.Squares.ShouldNotBeNull();
        chessboard.Squares.Count.ShouldBe(64);
    }
    
    [Fact]
    public void A_chess_board_should_have_32_black_and_32_white_squares()
    {
        var chessboard = Board.Build();
        
        chessboard.Squares.ShouldNotBeNull();
        chessboard.Squares.Count(s => s.Color == Color.Black).ShouldBe(32);
        chessboard.Squares.Count(s => s.Color == Color.White).ShouldBe(32);
    }
    
    [Fact]
    public void A_chess_board_should_not_have_two_squares_with_the_same_color_adjacent_to_each_other()
    {
        var chessboard = Board.Build();
        
        chessboard.Squares.ShouldNotBeNull();

        for (var i = 0; i < chessboard.Squares.Count; i++)
        {
            var current = chessboard.Squares[i];
            
            if (i > 0)
            {
                var previous = chessboard.Squares[i - 1];

                previous.Color.ShouldNotBe(current.Color);
            }
            else
            {
                current.Color.ShouldBe(Color.Black);
            }
        }
    }
    
    [Fact]
    public void A_chess_board_square_should_have_a_to_h_plus_a_1_to_8_notation()
    {
        var chessboard = Board.Build();
        
        chessboard.Squares.ShouldNotBeNull();
        
        string[] letters = { "A", "B", "C", "D", "E", "F", "G", "H" };
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };

        foreach (int number in numbers)
        {
            for (int i = 0; i < letters.Length; i++)
            {
                int index = (number - 1) * 8 + i;
                string letter = letters[i];
                string expected = $"{letter}:{number}";
                string actual = chessboard.Squares.Skip(index).First().ToString();
                actual.ShouldBe(expected);
            }
        }
    }
}
