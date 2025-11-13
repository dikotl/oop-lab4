namespace Figures;

public class Square : Figure
{
    public float A { get; private set; } = 100;
    public float B { get; private set; } = 100;

    public Square() : base() { /* Default values are fine */ }

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
        g.FillRectangle(brush, X - (A * 0.5f), Y - (B * 0.5f), A, B);
        g.Flush();
    }
}
