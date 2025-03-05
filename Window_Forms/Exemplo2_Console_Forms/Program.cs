// using System;

// namespace Exemplo2_Console_Forms
// {
//     class Program
//     {
//         [STAThread] // StatTred é um atributo que indica que o método Main é um método de thread de nível de aplicativo que é executado em um único thread de aplicativo.
//         static void Main(string[] args)
//         {
//             // Aplication é a classe que gerencia a execução de um aplicativo Windows Forms
//             Application.EnableVisualStyles(); // Habilita o estilo visual do Windows Forms
//             Application.SetCompatibleTextRenderingDefault(false); // Define o valor padrão para a propriedade TextRenderingDefault de todos os controles do aplicativo, ele faz com que o texto seja renderizado de forma mais nítida
//             // Application.Run(new MeuFormulario()); // Executa o aplicativo Windows Forms com o formulário Form1
//             Application.Run(new Calculadora()); // Executa o aplicativo Windows Forms com o formulário MeuFormulario
//         }
//     }

//     public class MeuFormulario : Form
//     {
//         public MeuFormulario()
//         {
//             this.Text = "Meu Formulário"; // Define o titulo do formulário
//             this.Size = new Size(300, 300); // Define o tamanho do formulário

//             Label label = new Label(); // Cria um novo label
//             label.Text = "Olá Mundo!"; // Define o texto do label
//             label.Location = new Point(100, 100); // Define a posição do label
//             this.AutoSize = true; // Define o tamanho do formulário de acordo com o conteúdo

//             this.Controls.Add(label); // Adiciona o label ao formulário
//         }
//     }


//     public class Calculadora : Form
//     {
//         private System.ComponentModel.IContainer components = null;
//         private System.Windows.Forms.Label Label1;
//         private System.Windows.Forms.TextBox TextBox1;
//         private System.Windows.Forms.TextBox TextBox2;
//         private System.Windows.Forms.Button Button1;
//         public Calculadora()
//         {
//             this.components = new System.ComponentModel.Container(); // Inicializa o container
//             this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; // Define o modo de ajuste automático
//             this.ClientSize = new System.Drawing.Size(800, 450); // Define o tamanho do formulário
//             this.BackColor = Color.LightGreen;
//             this.Text = "Calculadora"; // Define o titulo do formulário

//             // Intancia os componentes
//             this.Label1 = new System.Windows.Forms.Label();
//             this.TextBox1 = new System.Windows.Forms.TextBox();
//             this.TextBox2 = new System.Windows.Forms.TextBox();
//             this.Button1 = new System.Windows.Forms.Button();

//             // Configura o Label 
//             this.Label1.AutoSize = true;
//             this.Label1.Location = new System.Drawing.Point(30, 30);
//             this.Label1.Name = "Label1";
//             this.Label1.Size = new System.Drawing.Size(90, 20);
//             this.Label1.Text = "Digite os numeros";

//             // Configura o TextBox1
//             this.TextBox1.Location = new System.Drawing.Point(30, 60);
//             this.TextBox1.Name = "TextBox1";
//             this.TextBox1.Size = new System.Drawing.Size(200, 27);

//             this.TextBox2.Location = new System.Drawing.Point(30, 90);
//             this.TextBox2.Name = "TextBox1";
//             this.TextBox2.Size = new System.Drawing.Size(200, 27);

//             // Configura o Button1
//             this.Button1.Location = new System.Drawing.Point(30, 120);
//             this.Button1.Name = "Button1";
//             this.Button1.Size = new System.Drawing.Size(100, 30);
//             this.Button1.Text = "Calcular";
//             this.Button1.Click += new System.EventHandler(this.Button1_Click);


//             // Adiciona os componentes ao formulário
//             this.Controls.Add(this.Label1);
//             this.Controls.Add(this.TextBox1);
//             this.Controls.Add(this.TextBox2);
//             this.Controls.Add(this.Button1);
//         }

//         private void Button1_Click(object sender, EventArgs e)
//         {
//             // MessageBox.Show("O número digitado foi: " + textBox1.Text);
//             int num1 = 0;
//             int num2 = 0;

//             try
//             {
//                 num1 = Convert.ToInt32(TextBox1.Text);
//                 num2 = Convert.ToInt32(TextBox2.Text);

//                 MessageBox.Show("A soma dos números é: " + (num1 + num2)
//                 + "\nA subtração dos números é: " + (num1 - num2)
//                 + "\nA multiplicação dos números é: " + (num1 * num2)
//                 + "\nA divisão dos números é: " + (num1 / num2));

//             }
//             catch (System.Exception)
//             {

//                 MessageBox.Show("Digite apenas números inteiros");
//                 return;
//             }

//         }
//     }
// }