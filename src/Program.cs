using System;
using System.Windows.Forms;

namespace Magic8Ball
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Magic8Ball());
        }
    }
}
