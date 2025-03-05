namespace Exemplo1_Winforms_IDE;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

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
    }

    #endregion
}
