namespace Chess;

public abstract class Figure
{
    public Figure(Color color)
    {
        Color = color;
    }

    public string Image { get; set; }
    public Color Color { get; set; }

    public virtual bool CanTurn(int oldRow, int oldColumn, int newRow, int newColumn, List<List<Figure>> Board)
    {
        return true;
    }

}

public enum Color
{
    White,
    Black
}