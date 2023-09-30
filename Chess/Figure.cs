namespace Chess;

public class Figure
{
    public Figure(Color color)
    {
        Color = color;
    }

    public string Image { get; set; }
    public Color Color { get; set; }
}

public enum Color
{
    White,
    Black
}