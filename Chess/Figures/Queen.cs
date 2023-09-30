namespace Chess.Figures;

public class Queen : Figure
{
    public Queen(Color color) : base(color)
    {
        base.Image = color == Color.White ?  "♕" : "♛";
    }
}