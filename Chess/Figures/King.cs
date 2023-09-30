namespace Chess.Figures;

public class King : Figure
{
    public King(Color color) : base(color)
    {
        base.Image = color == Color.White ?  "♔" : "♚";
    }
}