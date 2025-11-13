namespace Figures;

public abstract class Figure
{
    public float X { get; set; } = 100;
    public float Y { get; set; } = 100;

    public abstract void DrawBlack(Graphics g);
    public abstract void HideDrawingBackGround(Graphics g);

    public void MoveRight()
    {
        X += 1;
    }
}
