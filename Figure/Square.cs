
namespace Figures;

public class Square : Figure
{
    public const float DefaultA = 100f;
    public const float DefaultB = 100f;

    public float A { get; private set; } = DefaultA;
    public float B { get; private set; } = DefaultB;

    public Square() : base() { /* Default values are fine */ }

    public override SizeF Size => new(A, B);

    public override void DrawBlack(Graphics g)
    {
        Draw(g, Brushes.Black);
    }

    public override void HideDrawingBackGround(Graphics g)
    {
        Draw(g, Brushes.White);
    }

    public override void Grow(int factor)
    {
        A += factor;
        B += factor;
    }

    public override void ResetSize()
    {
        A = DefaultA;
        B = DefaultB;
    }

    private void Draw(Graphics g, Brush brush)
    {
        g.FillRectangle(brush, X - (A * 0.5f), Y - (B * 0.5f), A, B);
        g.DrawRectangle(Pens.Red, X - (A * 0.5f), Y - (B * 0.5f), A, B);
        g.Flush();
    }
}
