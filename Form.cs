using Figures;

using Timer = System.Windows.Forms.Timer;

namespace Lab4;

public partial class ProgramForm : Form
{
    private Figure? _figure = null;
    private Timer _moveTimer = new();
    private Size _clipSize = new();

    // For fullscreen.
    private FormWindowState _prevWindowState;
    private FormBorderStyle _prevBorder;
    private Rectangle _prevBounds;

    public ProgramForm()
    {
        InitializeComponent();
        InitializeEvents();
    }

    private void InitializeEvents()
    {
        _moveTimer.Tick += OnMoveFigureTick;
        _moveTimer.Interval = 1;
        _moveTimer.Enabled = true;

        KeyDown += OnKeyPressed;
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

    private void OnKeyPressed(object? _, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.F11)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                ExitFullscreen();
            }
            else
            {
                EnterFullscreen();
            }
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

    public void EnterFullscreen()
    {
        _prevWindowState = WindowState;
        _prevBorder = FormBorderStyle;
        _prevBounds = Bounds;

        FormBorderStyle = FormBorderStyle.None;
        WindowState = FormWindowState.Maximized;
    }

    public void ExitFullscreen()
    {
        FormBorderStyle = _prevBorder;
        WindowState = _prevWindowState;
        Bounds = _prevBounds;
    }
}
