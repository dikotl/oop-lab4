using Figures;

namespace Lab4;

public class Apple : Food
{
    public Apple(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override void Draw(Graphics g) => DrawFilled(g, Brushes.Red);

    public override void OnEaten(Figure figure)
    {
        figure.Grow(5);
    }
}
