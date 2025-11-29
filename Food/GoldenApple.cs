using Figures;

namespace Lab4;

public class GoldenApple : Food
{
    public int _factor;

    public GoldenApple(int x, int y, int factor)
    {
        X = x;
        Y = y;
        _factor = factor;
    }

    public override void Draw(Graphics g) => DrawFilled(g, Brushes.Yellow);

    public override void OnEaten(Figure figure)
    {
        figure.Grow(_factor);
    }
}
