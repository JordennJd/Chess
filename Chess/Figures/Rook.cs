namespace Chess.Figures;

public class Rook : Figure
{
    public Rook(Color color) : base(color)
    {
        base.Image = color == Color.Black ?  "♖" : "♜";
    }
    
    public override bool CanTurn(int oldRow, int oldColumn, int newRow, int newColumn, List<List<Figure>> Board)
    {
        if (Math.Abs(oldRow - newRow) == 0 & Math.Abs(oldColumn - newColumn) >0 || 
            Math.Abs(oldRow - newRow) >0 & Math.Abs(oldColumn - newColumn) == 0)
        {
            return true;
        }

        return false;
    }
}