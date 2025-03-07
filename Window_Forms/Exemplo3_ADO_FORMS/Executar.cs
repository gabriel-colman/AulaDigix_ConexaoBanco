using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo3_ADO_FORMS
{
    public class Executar
    {
        [STAThread] // Atributo para indicar que o método é um método de entrada de thread de aplicativo
        static void Mina()
        {
            Application.EnableVisualStyles(); // Habilitar estilos visuais
            Application.SetCompatibleTextRenderingDefault(false); // Definir o texto de renderização compatível como falso
            Application.Run(new Cadastro()); // Executar o formulário
        }
    }
    public class Cadastro : Form
    {
        private Label label1, label2, label3; // Declaração de variáveis label
        private TextBox txtId, txtNome, txtEmail; // Declaração de variáveis TextBox
        private Button btnInserir, btnListar, btnAtualizar, btnDeletar; // Declaração de variáveis Button
        private ListBox lstUsuarios; // Declaração de variáveis, para eu colocar os valores dos resultados do TextBox em uma lista
        private CRUD crud;

        public Cadastro() // Construtor
        {
            // Inicializar o objeto CRUD
            crud = new CRUD();

            // Definir o tamanho da janela e cor de fundo 
            this.Size = new Size(500, 500);
            this.Text = "Cadastro de Usuários";
            this.BackColor = Color.White; // Cor de fundo

            // Fonte padrão para os textos
            Font fontePadrao = new Font("Arial", 12, FontStyle.Bold); // FontStyle é para definir o estilo da fonte
            Font fontealternativa = new Font("Italic", 12, FontStyle.Bold);

            // Criando as labels
            label1 = new Label { Text = "ID:", Location = new Point(20, 10), Font = fontePadrao, ForeColor = Color.Blue };
            label2 = new Label { Text = "Nome:", Location = new Point(20, 60), Font = fontePadrao, ForeColor = Color.Blue };
            label3 = new Label { Text = "Email:", Location = new Point(20, 110), Font = fontePadrao, ForeColor = Color.Blue };

            // Criando os TextBox
            txtId = new TextBox { Location = new Point(20, 30), Width = 220, Font = fontealternativa };
            txtNome = new TextBox { Location = new Point(20, 80), Width = 220, Font = fontealternativa };
            txtEmail = new TextBox { Location = new Point(20, 130), Width = 220, Font = fontealternativa };

            // Criando os botões
            btnInserir = CriarBotao("Inserir", new Point(270, 30), Color.LightGreen);
            btnListar = CriarBotao("Inserir", new Point(270, 30), Color.LightGreen);
            btnAtualizar = CriarBotao("Inserir", new Point(270, 30), Color.LightGreen);
            btnDeletar = CriarBotao("Inserir", new Point(270, 30), Color.LightGreen);

            // Craindo enventos dos botões
            btnInserir.Click += new EventHandler(ButtonInserir_Click);
            btnListar.Click += new EventHandler(ButtonListar_Click);
            btnAtualizar.Click += new EventHandler(ButtonAtualizar_Click);
            btnDeletar.Click += new EventHandler(ButtonDeletar_Click);

            // Criando a ListBox 
            lstUsuarios = new ListBox
            {
                Location = new Point(20, 180),
                Width = 500,
                Height = 150,
                BackColor = Color.White, // Cor de fundo
                ForeColor = Color.Blue, // ForeColor é a cor da fonte
            };

            // Adicionando os controles na janela
            this.Controls.Add(label1);
            this.Controls.Add(label2);
            this.Controls.Add(label3);
            this.Controls.Add(txtId);
            this.Controls.Add(txtNome);
            this.Controls.Add(txtEmail);
            this.Controls.Add(btnInserir);
            this.Controls.Add(btnListar);
            this.Controls.Add(btnAtualizar);
            this.Controls.Add(btnDeletar);
            this.Controls.Add(lstUsuarios);

        }


    }
}