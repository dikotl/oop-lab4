using Figures;

namespace Lab4;

public class BadApple : Food
{
    public BadApple(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override void Draw(Graphics g) => DrawFilled(g, Brushes.DarkRed);

    public override void OnEaten(Figure figure)
    {
        figure.Grow(-5);
    }
}
