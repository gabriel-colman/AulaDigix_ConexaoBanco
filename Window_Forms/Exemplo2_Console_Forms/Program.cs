using System;

namespace Exemplo2_Console_Forms
{
    class Program
    {
        [STAThread] // StatTred é um atributo que indica que o método Main é um método de thread de nível de aplicativo que é executado em um único thread de aplicativo.
        static void Main(string[] args)
        {
            // Aplication é a classe que gerencia a execução de um aplicativo Windows Forms
            Application.EnableVisualStyles(); // Habilita o estilo visual do Windows Forms
            Application.SetCompatibleTextRenderingDefault(false); // Define o valor padrão para a propriedade TextRenderingDefault de todos os controles do aplicativo, ele faz com que o texto seja renderizado de forma mais nítida
            Application.Run(new MeuFormulario()); // Executa o aplicativo Windows Forms com o formulário Form1
        }
    }

    public class MeuFormulario: Form
    {
        public MeuFormulario()
        {
            this.Text = "Meu Formulário"; // Define o titulo do formulário
            this.Size = new Size(300, 300); // Define o tamanho do formulário

            Label label = new Label(); // Cria um novo label
            label.Text = "Olá Mundo!"; // Define o texto do label
            label.Location = new Point(100, 100); // Define a posição do label
            this.AutoSize = true; // Define o tamanho do formulário de acordo com o conteúdo

            this.Controls.Add(label); // Adiciona o label ao formulário
        }
    }
}