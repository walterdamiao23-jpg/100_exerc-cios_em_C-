using System;
using System.Windows.Forms;

namespace Exercicio51_Tema
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
            this.Text = "Exercicio 51 - Tema";
            this.Width = 800;
            this.Height = 600;
        }
    }
}
