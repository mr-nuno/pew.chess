namespace PEW.Chess.Engine.Domain;

public class Square
{
    const string AvaliableLetters = "ABCDEFGH";
    
    /// <summary>
    /// The position of the square on the board
    /// </summary>
    public Position Position = new();

    /// <summary>
    /// The color of the square
    /// </summary>
    public Color Color = Color.Black;

    public override string ToString()
    {
        return $"{AvaliableLetters[Position.X]}:{Position.Y+1}";
    }
}