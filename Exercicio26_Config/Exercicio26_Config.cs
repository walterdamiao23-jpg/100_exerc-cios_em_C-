using System;
using System.Windows.Forms;

namespace Exercicio26_Config
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
            this.Text = "Exercicio 26 - Config";
            this.Width = 800;
            this.Height = 600;
        }
    }
}
