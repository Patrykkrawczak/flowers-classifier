using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp13ML.Model;

namespace WindowsFormsApp13
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			
			var input = new ModelInput();

			input.ImageSource = sciezkabox.Text;
			pictureBox1.Image = Image.FromFile(sciezkabox.Text);
			// Load model and predict output of sample data
			ModelOutput result = ConsumeModel.Predict(input);
			wynikbox.Text = result.Prediction;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void wynikbox_TextChanged(object sender, EventArgs e)
		{

		}

		private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{

			int size = -1;
			DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
			if (result == DialogResult.OK) // Test result.
			{
				sciezkabox.Text = openFileDialog1.FileName;
				
			}
			
		}

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
