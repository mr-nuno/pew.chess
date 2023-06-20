namespace PEW.Chess.Engine.Domain;

/// <summary>
/// A position in 2D space
/// </summary>
/// <param name="X">The x coordinate</param>
/// <param name="Y">The y coordinate</param>
public record Position(int X = 0, int Y = 0);