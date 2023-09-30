namespace Chess.Figures;

public class Rook : Figure
{
    public Rook(Color color) : base(color)
    {
        base.Image = color == Color.White ?  "♖" : "♜";
    }
}