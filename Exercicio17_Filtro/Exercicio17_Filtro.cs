using System;
using System.Windows.Forms;

namespace Exercicio17_Filtro
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
            this.Text = "Exercicio 17 - Filtro";
            this.Width = 800;
            this.Height = 600;
        }
    }
}
