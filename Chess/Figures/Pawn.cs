namespace Chess.Figures;

public class Pawn : Figure
{
    public Pawn(Color color) : base(color)
    {
        base.Image = color == Color.Black ?  "♙" : "♟";
    }
    public override bool CanTurn(int oldColumn,int oldRow,  int newColumn,int newRow, List<List<Figure>> Board)
    {
        if (this.Color == Color.White)
        {
            if (oldRow == 1 && newRow  - oldRow <= 2 && oldColumn == newColumn
                ||  newRow - oldRow == 1  && oldColumn == newColumn && Board[newColumn][newRow].GetType() == typeof(EmptyPlace)|| 
                newRow - oldRow  == 1 
                & Math.Abs(oldColumn - newColumn) == 1 
                & Board[newColumn][newRow].GetType() != typeof(EmptyPlace) & Board[newColumn][newRow].Color != this.Color)
            {
                return true;
            }
        }
        else
        {
            if (oldRow == 6 && oldRow - newRow  <= 2  && oldColumn == newColumn
                ||  oldRow - newRow  == 1  && oldColumn == newColumn && Board[newColumn][newRow].GetType() == typeof(EmptyPlace)|| 
                oldRow - newRow == 1 
                & Math.Abs(oldColumn - newColumn) == 1 
                & Board[newColumn][newRow].GetType() != typeof(EmptyPlace) & Board[newColumn][newRow].Color != this.Color)
            {
                return true;
            }
        }

        return false;
    }
    
}