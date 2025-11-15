using System;
using System.Windows.Forms;

namespace Exercicio30_DragDrop
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
            this.Text = "Exercicio 30 - DragDrop";
            this.Width = 800;
            this.Height = 600;
        }
    }
}
