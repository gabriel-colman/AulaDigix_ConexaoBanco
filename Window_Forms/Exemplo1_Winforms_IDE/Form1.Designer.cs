namespace Exemplo1_Winforms_IDE;
using System.Windows.Forms;
partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;


    private System.Windows.Forms.Label label1;
 // Criação de uma atributo com o tipo de uma classe específica para texto
    private System.Windows.Forms.TextBox textBox1; // Criação de uma atributo com o tipo de uma classe específica para entrada de texto

    private System.Windows.Forms.TextBox textBox2;

    private System.Windows.Forms.Button button1; // Criação de uma atributo com o tipo de uma classe específica para botão

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    // Esse dispose é um método que é chamado quando o formulário é fechado
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }



    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() //  Esse método é chamado para inicializar os componentes do formulário
    {
        this.components = new System.ComponentModel.Container(); //  Cria um novo container de componentes
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; //  Define o modo de ajuste automático do formulário
        this.ClientSize = new System.Drawing.Size(800, 450); //  Define o tamanho do formulário
        this.Text = "Iniciar"; //  Define o texto do formulário

        // Incialiar as variaveis criadas com instâncias de suas classes
        this.label1 = new System.Windows.Forms.Label();
        this.textBox1 = new System.Windows.Forms.TextBox();
        this.textBox2 = new System.Windows.Forms.TextBox();
        this.button1 = new System.Windows.Forms.Button();

        // Configuração do label1
        this.label1.AutoSize = true; // Ajusta o tamanho do label de acordo com o texto
        this.label1.Location = new System.Drawing.Point(30, 30); // Define a posição do label
        this.label1.Name = "label1"; // Define o nome do label
        this.label1.Size = new System.Drawing.Size(90, 20); // Define o tamanho do label
        this.label1.Text = "Digite um numero:"; // Define o texto do label

        // Configuração do textBox1
        this.textBox1.Location = new System.Drawing.Point(30, 60); // Define a posição do textBox
        this.textBox1.Name = "textBox1"; // Define o nome do textBox
        this.textBox1.Size = new System.Drawing.Size(100, 20); // Define o tamanho do textBox

        // Configuração do textBox2
        this.textBox2.Location = new System.Drawing.Point(30, 90); // Define a posição do textBox
        this.textBox2.Name = "textBox2"; // Define o nome do textBox
        this.textBox2.Size = new System.Drawing.Size(100, 20); // Define o tamanho do textBox

        // Configuração do button1
        this.button1.Location = new System.Drawing.Point(50, 120); // Define a posição do button
        this.button1.Name = "button1"; // Define o nome do button
        this.button1.Size = new System.Drawing.Size(100, 30); // Define o tamanho do button
        this.button1.Text = "Clique aqui"; // Define o texto do button
        this.button1.Click += new System.EventHandler(this.button1_Click); // Define o evento de clique do button, esse button1_Click é um método que será criado para tratar o evento de clique do botão

        // Adicionando os componentes ao formulário
        this.Controls.Add(this.label1); // Adiciona o label ao formulário
        this.Controls.Add(this.textBox1); // Adiciona o textBox ao formulário
        this.Controls.Add(this.textBox2); // Adiciona o textBox ao formulário
        this.Controls.Add(this.button1); // Adiciona o button ao formulário

    }

    #endregion
}
