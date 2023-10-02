namespace Chess.Figures;

public class King : Figure
{
    public King(Color color) : base(color)
    {
        base.Image = color == Color.Black ?  "♔" : "♚";
    }
    public override bool CanTurn(int oldRow, int oldColumn, int newRow, int newColumn, List<List<Figure>> Board)
    {
        if (Math.Abs(oldRow - newRow) <= 1 & Math.Abs(oldColumn - newColumn) <=1)
        {
            return true;
        }

        return false;
    }
}