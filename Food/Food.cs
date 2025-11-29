using Figures;

namespace Lab4;

public abstract class Food
{
    public static readonly Size Size = new(50, 50);

    public int X { get; protected init; }
    public int Y { get; protected init; }

    public Rectangle BoundingBox => new(X, Y, Size.Width, Size.Height);

    public abstract void Draw(Graphics g);
    public abstract void OnEaten(Figure figure);

    protected void Draw(Graphics g, Pen p) => g.DrawEllipse(p, X, Y, Size.Width, Size.Height);
    protected void DrawFilled(Graphics g, Brush b) => g.FillEllipse(b, X, Y, Size.Width, Size.Height);
}
