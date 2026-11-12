using WF1.Data;

namespace WF1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            DbInitializer.Initialize();

            Application.Run(new Form1());
        }
    }
}