namespace Chess.Figures;

public class EmptyPlace : Figure
{
    public EmptyPlace() : base(Color.Black)
    {
        base.Image = "▣";
    }
}