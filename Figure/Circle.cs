namespace Figures;

public class Circle : Figure
{
    public const float DefaultRadius = 100f;

    public float Radius { get; private set; } = DefaultRadius;

    public Circle() : base() { /* Default values are fine */ }

    public override SizeF Size => new(Radius, Radius);

    public override void DrawBlack(Graphics g) => Draw(g, Brushes.Black);
    public override void HideDrawingBackGround(Graphics g) => Draw(g, Brushes.White);
    public override void Grow(int factor) => Radius += factor;
    public override void ResetSize() => Radius = DefaultRadius;

    private void Draw(Graphics g, Brush brush)
    {
        g.FillEllipse(brush, X - (Radius * 0.5f), Y - (Radius * 0.5f), Radius, Radius);
        g.Flush();
    }
}
