using System;
using System.Drawing;
using System.Windows.Forms;

namespace Exemplo2_Console_Forms
{
    public class Executar
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }

    public class MainForm : Form
    {
        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        
        public MainForm()
        {
            this.Text = "Sistema Multi-Tela";
            this.Size = new Size(500, 400);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Criando o Controle de Abas
            tabControl = new TabControl { Dock = DockStyle.Fill };

            // Criando as abas
            tabPage1 = new TabPage { Text = "Tela 1" };
            tabPage2 = new TabPage { Text = "Tela 2" };

            // Adicionando os painéis às abas
            tabPage1.Controls.Add(new Tela1());
            tabPage2.Controls.Add(new Tela2());

            // Adicionando as abas ao controle de abas
            tabControl.TabPages.Add(tabPage1);
            tabControl.TabPages.Add(tabPage2);

            // Adicionando o controle de abas ao formulário
            this.Controls.Add(tabControl);
        }
    }

    public class Tela1 : Panel
    {
        public Tela1()
        {
            this.BackColor = Color.LightBlue;
            this.Size = new Size(300, 300);

            Label label = new Label { Text = "Tela 1" };
            label.Location = new Point(100, 100);
            this.Controls.Add(label);
        }
    }

    public class Tela2 : Panel
    {
        public Tela2()
        {
            this.BackColor = Color.LightGreen;
            this.Size = new Size(300, 300);

            Label label = new Label { Text = "Tela 2" };
            label.Location = new Point(100, 100);
            this.Controls.Add(label);
        }
    }
}
