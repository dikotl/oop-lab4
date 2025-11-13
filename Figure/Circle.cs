namespace Figures;

public class Circle : Figure
{
    public float Radius { get; private set; } = 100.0f;

    public Circle() : base() { /* Default values are fine */ }

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
        g.FillEllipse(brush, X - (Radius * 0.5f), Y - (Radius * 0.5f), Radius, Radius);
        g.Flush();
    }
}
