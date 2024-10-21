using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = (string)textBox1.Text;
            int number;

            if (int.TryParse(input, out number))
            {
                if (number % 3 == 0)
                {
                    MessageBox.Show($"{number} делится на 3.", "Вывод", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"{number} не делится на 3.", "Вывод", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректное число", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxRed_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRed.Checked)
            {
                button2.BackColor = Color.Red;
                button2.ForeColor = Color.White;
                checkBoxBlue.Checked = false;
                checkBoxGreen.Checked = false;
                checkBoxYellow.Checked = false;
            }
        }

        private void checkBoxBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBlue.Checked)
            {
                button2.BackColor = Color.Blue;
                button2.ForeColor = Color.White;
                checkBoxRed.Checked = false;
                checkBoxGreen.Checked = false;
                checkBoxYellow.Checked = false;
            }
        }

        private void checkBoxGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGreen.Checked)
            {
                button2.BackColor = Color.Green;
                button2.ForeColor = Color.White;
                checkBoxBlue.Checked = false;
                checkBoxRed.Checked = false;
                checkBoxYellow.Checked = false;
            }
        }

        private void checkBoxYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxYellow.Checked)
            {
                button2.BackColor = Color.Yellow;
                button2.ForeColor = Color.Black;
                checkBoxBlue.Checked = false;
                checkBoxGreen.Checked = false;
                checkBoxRed.Checked = false;
            }
        }
    }
}
