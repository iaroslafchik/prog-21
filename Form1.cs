using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_prog_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if (InputBox.Text == "")
            {
                result = MessageBox.Show("Вы не ввели имя" + Environment.NewLine + "Продолжить?", "Ошибка!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    InputBox.Text = "Input text here";
                }
                else
                {
                    Close();
                }
            }
            else
            {
                ConsoleBox.Text = "Здравствуй, " + InputBox.Text + "!";
                InputBox.Text = "";
            }
        }
    }
}
