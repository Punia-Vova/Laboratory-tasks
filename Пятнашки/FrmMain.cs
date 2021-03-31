﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Пятнашки
{
    public partial class Пятнашки : Form
    {
        private Game g;
        public Пятнашки()
        {
            InitializeComponent();
            this.Height = 380;
            this.Width = 620;
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            g.StartGame(true);
            showGrid();
            if (!g.isPlayable())
                MessageBox.Show("Эта игра не соберется. Начните новую игру!");
            timerRestart();
            count = 0;
            textBoxMot.Text = count.ToString();
        }
        private void showGrid()
        {
            dataGridView1.ClearSelection();
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    if (g.Table[i, j] > 0)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = g.Table[i, j];
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells[j].Value = "";
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Red;
                    }
        }
        private void timerRestart()
        {
            textBoxTime.Text = "00:00";
            date1 = new DateTime(0, 0);
            gameTimer.Enabled = true;
        }
        private void RepeatGameButton_Click(object sender, EventArgs e)
        {
            g.StartGame(false);
            showGrid();
            if (!g.isPlayable())
                MessageBox.Show("Эта игра не соберется. Начните новую игру!");
            timerRestart();
            count = 0;
            textBoxMot.Text = count.ToString();
        }

        private void Пятнашки_Load(object sender, EventArgs e)
        {
            g = new Game();
            dataGridView1.RowCount = 4;
            dataGridView1.ColumnCount = 4;
            for (int i = 0; i < 4; i++)
            {
                dataGridView1.Rows[i].Height = 75;
                dataGridView1.Columns[i].Width = 75;
            }
            showGrid();
            if (!g.isPlayable())
                MessageBox.Show("Эта игра не соберется. Начните новую игру!");
            gameTimer.Start();
            textBoxMot.Text = count.ToString();
            textBoxTime.Text = "00:00";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        int count = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.RowIndex == g.getZeroRow() & dataGridView1.CurrentCell.ColumnIndex == g.getZeroColumn() + 1)
            {
                g.swap(ref g.Table[g.getZeroRow(), g.getZeroColumn()], ref g.Table[g.getZeroRow(), g.getZeroColumn() + 1]);
                count++;
                textBoxMot.Text = count.ToString();
            }
            if (dataGridView1.CurrentCell.RowIndex == g.getZeroRow() & dataGridView1.CurrentCell.ColumnIndex == g.getZeroColumn() - 1)
            { 
                g.swap(ref g.Table[g.getZeroRow(), g.getZeroColumn()], ref g.Table[g.getZeroRow(), g.getZeroColumn() - 1]);
                count++;
                textBoxMot.Text = count.ToString();
            }
            if (dataGridView1.CurrentCell.RowIndex == g.getZeroRow() + 1 & dataGridView1.CurrentCell.ColumnIndex == g.getZeroColumn())
            {
                g.swap(ref g.Table[g.getZeroRow(), g.getZeroColumn()], ref g.Table[g.getZeroRow() + 1, g.getZeroColumn()]);
                count++;
                textBoxMot.Text = count.ToString();
            }
            if (dataGridView1.CurrentCell.RowIndex == g.getZeroRow() - 1 & dataGridView1.CurrentCell.ColumnIndex == g.getZeroColumn())
            {
                g.swap(ref g.Table[g.getZeroRow(), g.getZeroColumn()], ref g.Table[g.getZeroRow() - 1, g.getZeroColumn()]);
                count++;
                textBoxMot.Text = count.ToString();
            }
            showGrid();
            if (g.isFinished())
            {
                gameTimer.Stop();
                MessageBox.Show("Поздравляю! Вы отлично справились!!!");
            }
        }
        DateTime date1 = new DateTime(0, 0);
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            date1 = date1.AddSeconds(1);
            textBoxTime.Text = date1.ToString("mm:ss");
        }

    }
}
