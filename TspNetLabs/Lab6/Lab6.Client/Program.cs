using System.Windows.Forms;

namespace Lab6.Client
{
    public static class Program
    {
        public static void Main()
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}