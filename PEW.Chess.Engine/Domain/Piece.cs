using System.Numerics;

namespace PEW.Chess.Engine.Domain;

/// <summary>
/// A chess piece
/// </summary>
public abstract class Piece
{
    /// <summary>
    /// The color of the piece
    /// </summary>
    protected Color Color { get; }
    
    /// <summary>
    /// The start position of the piece
    /// </summary>
    protected Square StartSquare { get; }
    
    /// <summary>
    /// The current position on the board
    /// </summary>
    protected Square CurrentSquare { get; set; }
    
    /// <summary>
    /// Indicates that this piece has moved from it's start position.
    /// </summary>
    protected bool HasMoved { get; set; }
    
    /// <summary>
    /// The movement capabilities of the piece
    /// </summary>
    protected IEnumerable<Vector2> Movements { get; set; } = ArraySegment<Vector2>.Empty;

    /// <summary>
    /// Create a piece with a color and a start position
    /// </summary>
    /// <param name="color">The color of the piece</param>
    /// <param name="startSquare">The start square of the piece</param>
    protected Piece(Color color, Square startSquare)
    {
        Color = color;
        StartSquare = startSquare;
        CurrentSquare = startSquare;
    }

    /// <summary>
    /// Move the piece
    /// </summary>
    /// <param name="square">The new square</param>
    protected abstract void Move(Square square);
    
    /// <summary>
    /// Strike a opponent piece
    /// </summary>
    /// <param name="position">The new position</param>
    protected abstract void Strike(Square square);
}
