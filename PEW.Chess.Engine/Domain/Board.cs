namespace PEW.Chess.Engine.Domain;

/// <summary>
/// A board with squares
/// </summary>
public class Board
{
    /// <summary>
    /// The squares on the board
    /// </summary>
    public List<Square> Squares { get; private set; } = new();

    /// <summary>
    /// Builds a chess board
    /// </summary>
    /// <returns>A playable chess board</returns>
    public static Board Build()
    {
        var squares = new List<Square>();
        for (var i = 0; i < 8; i++)
        {
            for (var j = 0; j < 8; j++)
            {
                squares.Add(new Square 
                { 
                    Position = new Position(j, i),
                    Color = !int.IsEvenInteger(j+1) 
                        ? Color.Black 
                        : Color.White
                });
            }
        }
        
        return new ()
        {
            Squares = squares
        };
    }
}