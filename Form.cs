using Figures;

using Timer = System.Windows.Forms.Timer;

namespace Lab4;

public partial class ProgramForm : Form
{
    private Figure? _figure = null;
    private Timer _moveTimer = new();
    private Size _clipSize = new();

    public ProgramForm()
    {
        InitializeComponent();
        InitializeMoveTimer();
    }

    private void InitializeMoveTimer()
    {
        _moveTimer.Tick += OnMoveFigureTick;
        _moveTimer.Interval = 1;
        _moveTimer.Enabled = true;
    }

    protected override CreateParams CreateParams
    {
        get
        {
            CreateParams createParams = base.CreateParams;
            createParams.ExStyle |= 0x00000020;
            return createParams;
        }
    }

    private void OnMoveFigureTick(object? _, EventArgs e)
    {
        if (_figure is not null)
        {
            _figure.Move(_clipSize);

            // Because we're moved the figure we need to re-paint.
            Invalidate();
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        using var g = e.Graphics;
        _clipSize = e.ClipRectangle.Size;
        _figure?.DrawBlack(g);
    }

    private void button1_Click(object _, EventArgs e)
    {
        _figure = new Circle
        {
            X = Width / 2,
            Y = Height / 2
        };
        Invalidate();
    }

    private void button2_Click(object _, EventArgs e)
    {
        _figure = new Square()
        {
            X = Width / 2,
            Y = Height / 2
        };
        Invalidate();
    }

    private void button3_Click(object _, EventArgs e)
    {
        _figure = new Rhomb()
        {
            X = Width / 2,
            Y = Height / 2
        };
        Invalidate();
    }
}
