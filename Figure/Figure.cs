namespace Figures;

public abstract class Figure
{
    public int _horizontalMoveDelta = 2;
    public int _verticalMoveDelta = 2;

    public float X { get; set; } = 100;
    public float Y { get; set; } = 100;

    public abstract SizeF BoundingBox { get; }

    public abstract void DrawBlack(Graphics g);
    public abstract void HideDrawingBackGround(Graphics g);

    public void Move(Size size)
    {
        var (collidedHorizontally, collidedVertically) = IsCollidedWithBorder(size);

        if (collidedHorizontally) _horizontalMoveDelta = -_horizontalMoveDelta;
        if (collidedVertically) _verticalMoveDelta = -_verticalMoveDelta;

        X += _horizontalMoveDelta;
        Y += _verticalMoveDelta;
    }

    private (bool, bool) IsCollidedWithBorder(Size border)
    {
        var collidedHorizontally = false;
        var collidedVertically = false;
        var bb = BoundingBox;
        var dx = bb.Width * 0.5f;
        var dy = bb.Height * 0.5f;

        // Check each dimension that bounding box is within range of the border.
        // Also clamp it.
        if (X + dx >= border.Width)
        {
            X = border.Width - dx - 1;
            collidedHorizontally = true;
        }
        if (X - dx <= 0)
        {
            X = dx + 1;
            collidedHorizontally = true;
        }
        if (Y + dy >= border.Height)
        {
            Y = border.Height - dy - 1;
            collidedVertically = true;
        }
        if (Y - dy <= 0)
        {
            Y = dy + 1;
            collidedVertically = true;
        }

        return (collidedHorizontally, collidedVertically);
    }
}
