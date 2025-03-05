namespace Exemplo1_Winforms_IDE;

public partial class Form1 : Form 
{
    public Form1()
    {
        this.Text = "Meu primeiro Windows Forms"; // Define o texto do formulário
        this.Width = 400; // Define a largura do formulário
        this.Height = 200; // Define a altura do formulário

        // Instancia a classe Label para mexer com texto
        Label label = new Label();
        label.Text = "Olá, Mundo!"; // Define o texto do label
        label.AutoSize = true; // Define o tamanho do label
        label.Location = new Point(10, 10); // Define a posição do label, Point é uma classe que define um ponto no plano cartesiano

        // Adiciona o label ao formulário
        this.Controls.Add(label); // Controls é uma propriedade que contém todos os controles do formulário, e estou adicionando para mostrar a informação na tela pelo Label
    }
}
