namespace Figures;

public abstract class Figure
{
    public const int DefaultMoveDelta = 2;

    public int HorizontalMoveDelta = DefaultMoveDelta;
    public int VerticalMoveDelta = DefaultMoveDelta;

    public abstract SizeF Size { get; }

    public float X { get; set; } = 100;
    public float Y { get; set; } = 100;

    public PointF Location => new(X - Size.Width / 2, Y - Size.Height / 2);
    public RectangleF BoundingBox => new(Location, Size);

    public abstract void DrawBlack(Graphics g);
    public abstract void HideDrawingBackGround(Graphics g);
    public abstract void Grow(int factor);
    public abstract void ResetSize();

    public void Move(Size size)
    {
        var (collidedHorizontally, collidedVertically) = IsCollidedWithBorder(size);

        if (collidedHorizontally) HorizontalMoveDelta = -HorizontalMoveDelta;
        if (collidedVertically) VerticalMoveDelta = -VerticalMoveDelta;

        X += HorizontalMoveDelta;
        Y += VerticalMoveDelta;
    }

    private (bool, bool) IsCollidedWithBorder(Size border)
    {
        var collidedHorizontally = false;
        var collidedVertically = false;
        var bb = Size;
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

    public bool IsIntersects(RectangleF box)
    {
        return BoundingBox.IntersectsWith(box);
    }
}
