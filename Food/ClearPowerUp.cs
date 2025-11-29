using Figures;

namespace Lab4;

public class ResetPowerUp : Food
{
    public ResetPowerUp(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override void Draw(Graphics g) => Draw(g, Pens.Aquamarine);

    public override void OnEaten(Figure figure)
    {
        SpeedUpPowerUp.IsAlreadyApplied = false;
        figure.HorizontalMoveDelta = Figure.DefaultMoveDelta * Math.Sign(figure.HorizontalMoveDelta);
        figure.VerticalMoveDelta = Figure.DefaultMoveDelta * Math.Sign(figure.VerticalMoveDelta);
        figure.ResetSize();
    }
}
