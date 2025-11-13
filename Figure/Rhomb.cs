namespace Figures;

public class Rhomb : Figure
{
    public float DiagonalA { get; private set; } = 50;
    public float DiagonalB { get; private set; } = 50;

    public Rhomb() : base() { /* Default values are fine */ }

    public override void DrawBlack(Graphics g)
    {
        Draw(g, new SolidBrush(Color.Black));
    }

    public override void HideDrawingBackGround(Graphics g)
    {
        Draw(g, new SolidBrush(Color.White));
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
