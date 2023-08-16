using System.Numerics;

namespace PEW.Chess.Engine.Domain;

/// <summary>
/// A pawn
/// </summary>
public class Pawn : Piece
{
    /// <summary>
    /// Create a pawn with a color and a start position
    /// </summary>
    /// <param name="color">The color of the pawn</param>
    /// <param name="startSquare">The start square of the pawn</param>
    public Pawn(Color color, Square startSquare) : base(color, startSquare)
    {
        Movements = new []
        {
            new Vector2(0, 1),
            new Vector2(0, 2),
            new Vector2(1, 1),
        };
    }

    protected override void Move(Square square)
    {
        
    }

    protected override void Strike(Square square)
    {
        throw new NotImplementedException();
    }
}
