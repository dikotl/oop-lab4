using System.Runtime.InteropServices;

namespace Lab4;

static class Program
{
    [DllImport("kernel32.dll")]
    static extern bool AttachConsole(int dwProcessId);
    private const int AttachParentProcess = -1;

    [STAThread]
    static void Main()
    {
        AttachConsole(AttachParentProcess);

        ApplicationConfiguration.Initialize();
        Application.Run(new ProgramForm());
    }
}
