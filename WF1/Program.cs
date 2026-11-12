using WF1.Data;
using WF1.Forms;

namespace WF1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            DbInitializer.Initialize();

            Application.Run(new LoginUsers1());
        }
    }
}