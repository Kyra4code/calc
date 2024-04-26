using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calculadora_que_agora_tem_que_dar_certo
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void Button1Click(object sender, EventArgs e)
		{
			int x1, y1, r1;
			x1 = int.Parse(textBox1.Text);
			y1 = int.Parse(textBox2.Text);
			r1 = x1 + y1;
			textBox3.Text = r1.ToString();
		}
		void Button2Click(object sender, EventArgs e)
		{
			int x1, x2, y1;
			x1 = int.Parse(textBox1.Text);
			x2 = int.Parse(textBox2.Text);
			y1 = x1 - x2;
			textBox3.Text = y1.ToString();
		}
		void Button3Click(object sender, EventArgs e)
		{
			int x1, x2, y1;
			x1 = int.Parse(textBox1.Text);
			x2 = int.Parse(textBox2.Text);
			y1 = x1 * x2;
			textBox3.Text = y1.ToString();
		}
		void Button4Click(object sender, EventArgs e)
		{
			float x1, x2, y1;
			x1 = float.Parse(textBox1.Text);
			x2 = float.Parse(textBox2.Text);
			y1 = x1 / x2;
			textBox3.Text = y1.ToString();
		}
		void Button5Click(object sender, EventArgs e)
		{
			double n1, n2, r;
			n1 = double.Parse(textBox1.Text);
			n2 = double.Parse(textBox2.Text);
			r = Math.Pow(n1, n2);
			textBox3.Text = r.ToString();
			
		}
		void Button6Click(object sender, EventArgs e)
		{
			double n1, n2, r;
			n1 = double.Parse(textBox1.Text);
			n2 = double.Parse(textBox2.Text);
			r = Math.Sqrt (n1);
			textBox3.Text = r.ToString();
		}
	}
}
