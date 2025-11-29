namespace Figures;

public class Rhomb : Figure
{
    public const float DefaultDiagonalA = 50f;
    public const float DefaultDiagonalB = 50f;

    public float DiagonalA { get; private set; } = DefaultDiagonalA;
    public float DiagonalB { get; private set; } = DefaultDiagonalB;

    public Rhomb() : base() { /* Default values are fine */ }

    public override SizeF Size => new(DiagonalA * 2f, DiagonalB * 2f);

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
        DiagonalA += factor;
        DiagonalB += factor;
    }

    public override void ResetSize()
    {
        DiagonalA = DefaultDiagonalA;
        DiagonalB = DefaultDiagonalB;
    }

    private void Draw(Graphics g, Brush brush)
    {
        g.FillPolygon(brush,
        [
            new PointF(X - DiagonalA, Y),
            new PointF(X, Y - DiagonalB),
            new PointF(X + DiagonalA, Y),
            new PointF(X, Y + DiagonalB),
        ]);
        g.Flush();
    }
}
