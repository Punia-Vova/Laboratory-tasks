using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Дурак1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Еще не поздно все исправить!");
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Это замечательно!");
        }
        private void buttonNo_MouseMove(object sender, MouseEventArgs e)
        {
         
        }

        private void buttonNo_Enter(object sender, EventArgs e)
        {
            buttonYes.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "1970")
            {
                buttonNo.Location = new Point(434, 229);
                textBox1.Text = "Правильный код";
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int x = MousePosition.X - this.Location.X;
            int y = MousePosition.Y - this.Location.Y;
            if (textBox1.Text != "1970" & textBox1.Text != "Правильный код")
            {
                if (buttonNo.Location.X - x < 0 & buttonNo.Location.Y - y < 0)
                {
                    if (x - buttonNo.Location.X - buttonNo.Width < 50 & y - buttonNo.Location.Y - buttonNo.Height < 50)
                    {
                        if (x - buttonNo.Location.X > buttonNo.Width)
                            buttonNo.Location = new Point(buttonNo.Location.X - 60, buttonNo.Location.Y);
                        if (y - buttonNo.Location.Y > buttonNo.Height)
                            buttonNo.Location = new Point(buttonNo.Location.X, buttonNo.Location.Y - 60);
                    }
                }
                if (buttonNo.Location.X - x < 0 & buttonNo.Location.Y - y > 0)
                {
                    if (x - buttonNo.Location.X - buttonNo.Width < 50 & buttonNo.Location.Y - y < 50)
                    {
                        if (x - buttonNo.Location.X < buttonNo.Width)
                            buttonNo.Location = new Point(buttonNo.Location.X - 60, buttonNo.Location.Y);
                        buttonNo.Location = new Point(buttonNo.Location.X, buttonNo.Location.Y + 60);
                    }
                }
                if (buttonNo.Location.X - x > 0 & buttonNo.Location.Y - y < 0)
                {
                    if (buttonNo.Location.X - x < 50 & y - buttonNo.Location.Y - buttonNo.Height < 50)
                    {
                            buttonNo.Location = new Point(buttonNo.Location.X + 60, buttonNo.Location.Y);
                        if (y - buttonNo.Location.Y < buttonNo.Height)
                            buttonNo.Location = new Point(buttonNo.Location.X, buttonNo.Location.Y - 60);
                    }
                }
                if (buttonNo.Location.X - x > 0 & buttonNo.Location.Y - y > 0)
                {
                    if (buttonNo.Location.X - x < 50 & buttonNo.Location.Y - y < 0)
                    {
                            buttonNo.Location = new Point(buttonNo.Location.X + 60, buttonNo.Location.Y);
                            buttonNo.Location = new Point(buttonNo.Location.X, buttonNo.Location.Y + 60);
                    }
                }
                if (buttonNo.Top < 0)
                    buttonNo.Location = new Point(buttonNo.Location.X, this.ClientSize.Height - buttonNo.Height);
                if (buttonNo.Left < 0)
                    buttonNo.Location = new Point(this.ClientSize.Width - buttonNo.Width, buttonNo.Location.Y);
                if (buttonNo.Top > this.ClientSize.Height - buttonNo.Height)
                    buttonNo.Location = new Point(buttonNo.Location.X, buttonNo.Height);
                if (buttonNo.Left > this.ClientSize.Width - buttonNo.Width)
                    buttonNo.Location = new Point(buttonNo.Width, buttonNo.Location.Y);
            }
        }
    }
}
