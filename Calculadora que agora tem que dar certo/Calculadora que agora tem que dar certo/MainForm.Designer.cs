/*
 * Created by SharpDevelop.
 * User: aluno
 * Date: 12/03/2024
 * Time: 19:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Calculadora_que_agora_tem_que_dar_certo
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button6 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(51, 176);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 50);
			this.button1.TabIndex = 0;
			this.button1.Text = "Somar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(51, 232);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(112, 50);
			this.button2.TabIndex = 1;
			this.button2.Text = "Subtrair";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(233, 176);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(112, 50);
			this.button3.TabIndex = 2;
			this.button3.Text = "Multiplicar";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(233, 232);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(112, 50);
			this.button4.TabIndex = 3;
			this.button4.Text = "Dividir";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(419, 176);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(112, 50);
			this.button5.TabIndex = 4;
			this.button5.Text = "Elevar";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(51, 60);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(128, 26);
			this.textBox1.TabIndex = 6;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(217, 60);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(128, 26);
			this.textBox2.TabIndex = 7;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(419, 60);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(128, 26);
			this.textBox3.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(367, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 43);
			this.label1.TabIndex = 9;
			this.label1.Text = "=";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(217, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(134, 20);
			this.label2.TabIndex = 10;
			this.label2.Text = "Segundo Numero";
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(419, 232);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(112, 50);
			this.button6.TabIndex = 11;
			this.button6.Text = "Raiz";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(51, 37);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(126, 20);
			this.label3.TabIndex = 12;
			this.label3.Text = "Primeiro Numero";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(419, 37);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(82, 20);
			this.label4.TabIndex = 13;
			this.label4.Text = "Resultado";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(217, 89);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(112, 68);
			this.label5.TabIndex = 14;
			this.label5.Text = "Não usar essa caixa de texto para raiz";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(582, 359);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(604, 415);
			this.Name = "MainForm";
			this.Text = "Calculadora que agora tem que dar certo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
