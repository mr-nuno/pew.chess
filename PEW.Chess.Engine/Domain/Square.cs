namespace PEW.Chess.Engine.Domain;

public class Square
{
    const string AvaliableLetters = "ABCDEFGH";
    
    /// <summary>
    /// The position of the square on the board
    /// </summary>
    public Position Position = new();
    
    /// <summary>
    /// The current piece occupying the square
    /// </summary>
    public Piece? Piece;

    /// <summary>
    /// The color of the square
    /// </summary>
    public Color Color = Color.Black;

    /// <summary>
    /// Text representation of the square position in chess notation form
    /// </summary>
    /// <returns>A chess notation for the square</returns>
    public override string ToString()
    {
        return $"{AvaliableLetters[Position.X]}:{Position.Y+1}";
    }

    /// <summary>
    /// Checks if a square is occupied by a piece
    /// </summary>
    /// <returns>True or false</returns>
    public bool IsOccupied()
    {
        return Piece != null;
    }
}
