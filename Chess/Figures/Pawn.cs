namespace Chess.Figures;

public class Pawn : Figure
{
    public Pawn(Color color) : base(color)
    {
        base.Image = color == Color.White ?  "♙" : "♟";
    }
    
}