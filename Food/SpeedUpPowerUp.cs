using Figures;
using Timer = System.Windows.Forms.Timer;

namespace Lab4;

public class SpeedUpPowerUp : Food
{
    public static bool IsAlreadyApplied { get; set; }

    public SpeedUpPowerUp(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override void Draw(Graphics g) => Draw(g, Pens.AliceBlue);

    public override void OnEaten(Figure figure)
    {
        if (!IsAlreadyApplied)
        {
            IsAlreadyApplied = true;
            figure.HorizontalMoveDelta *= 2;
            figure.VerticalMoveDelta *= 2;
        }

        InvokeAfter(10000, () =>
        {
            if (IsAlreadyApplied)
            {
                IsAlreadyApplied = false;
                figure.HorizontalMoveDelta /= 2;
                figure.VerticalMoveDelta /= 2;
                System.Console.WriteLine("Timer is gone");
            }
        });
    }

    public static async void InvokeAfter(int ms, Action action)
    {
        await Task.Delay(ms);
        action();
    }
}
