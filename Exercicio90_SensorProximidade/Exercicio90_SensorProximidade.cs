using System;
using System.Windows.Forms;

namespace Exercicio90_SensorProximidade
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
            this.Text = "Exercicio 90 - SensorProximidade";
            this.Width = 800;
            this.Height = 600;
        }
    }
}
