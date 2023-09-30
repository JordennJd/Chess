namespace Chess.Figures;

public class Bishop : Figure
{
    public Bishop(Color color) : base(color)
    {
        base.Image = color == Color.White ?  "♗" : "♝";
    }
}