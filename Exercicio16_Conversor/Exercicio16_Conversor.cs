using System;
using System.Windows.Forms;

namespace Exercicio16_Conversor
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
            this.Text = "Exercicio 16 - Conversor";
            this.Width = 800;
            this.Height = 600;
        }
    }
}
