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
        const string letters = "ABCDEFGH";
        var chessboard = Board.Build();
        
        chessboard.Squares.ShouldNotBeNull();
        
        chessboard.Squares.Skip(0).First().ToString().ShouldBe("A:1");
        chessboard.Squares.Skip(1).First().ToString().ShouldBe("B:1");
        chessboard.Squares.Skip(2).First().ToString().ShouldBe("C:1");
        chessboard.Squares.Skip(3).First().ToString().ShouldBe("D:1");
        chessboard.Squares.Skip(4).First().ToString().ShouldBe("E:1");
        chessboard.Squares.Skip(5).First().ToString().ShouldBe("F:1");
        chessboard.Squares.Skip(6).First().ToString().ShouldBe("G:1");
        chessboard.Squares.Skip(7).First().ToString().ShouldBe("H:1");
    }
}