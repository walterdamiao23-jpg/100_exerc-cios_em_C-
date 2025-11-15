using System;
using System.Windows.Forms;

namespace Exercicio58_Breadcrumb
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
            this.Text = "Exercicio 58 - Breadcrumb";
            this.Width = 800;
            this.Height = 600;
        }
    }
}
