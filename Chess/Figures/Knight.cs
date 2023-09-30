namespace Chess.Figures;

public class Knight : Figure
{
    public Knight(Color color) : base(color)
    {
        base.Image = color == Color.White ?  "♘" : "♞";
    }
}