using System;
using System.Windows.Forms;

namespace Exercicio74_Video
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }

    public class MainForm : Form
    {
        public MainForm()
        {
            this.Text = "Exercicio 74 - Video";
            this.Width = 800;
            this.Height = 600;
        }
    }
}
