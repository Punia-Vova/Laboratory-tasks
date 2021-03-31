namespace Пятнашки
{
    partial class Пятнашки
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.RepeatGameButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblMotion = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.textBoxMot = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // NewGameButton
            // 
            this.NewGameButton.BackColor = System.Drawing.Color.Orange;
            this.NewGameButton.Location = new System.Drawing.Point(794, 150);
            this.NewGameButton.Margin = new System.Windows.Forms.Padding(6);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(300, 106);
            this.NewGameButton.TabIndex = 0;
            this.NewGameButton.Text = "Новая игра";
            this.NewGameButton.UseVisualStyleBackColor = false;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // RepeatGameButton
            // 
            this.RepeatGameButton.BackColor = System.Drawing.Color.Orange;
            this.RepeatGameButton.Location = new System.Drawing.Point(794, 315);
            this.RepeatGameButton.Margin = new System.Windows.Forms.Padding(6);
            this.RepeatGameButton.Name = "RepeatGameButton";
            this.RepeatGameButton.Size = new System.Drawing.Size(300, 106);
            this.RepeatGameButton.TabIndex = 1;
            this.RepeatGameButton.Text = "Повторить игру";
            this.RepeatGameButton.UseVisualStyleBackColor = false;
            this.RepeatGameButton.Click += new System.EventHandler(this.RepeatGameButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(47, 37);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 75;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(602, 579);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblMotion
            // 
            this.lblMotion.AutoSize = true;
            this.lblMotion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMotion.Location = new System.Drawing.Point(1032, 48);
            this.lblMotion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMotion.Name = "lblMotion";
            this.lblMotion.Size = new System.Drawing.Size(102, 37);
            this.lblMotion.TabIndex = 3;
            this.lblMotion.Text = "Ходы:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTime.Location = new System.Drawing.Point(722, 54);
            this.lblTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(192, 37);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Время игры:";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // textBoxTime
            // 
            this.textBoxTime.BackColor = System.Drawing.Color.PaleGreen;
            this.textBoxTime.Location = new System.Drawing.Point(718, 54);
            this.textBoxTime.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.ReadOnly = true;
            this.textBoxTime.Size = new System.Drawing.Size(196, 31);
            this.textBoxTime.TabIndex = 5;
            this.textBoxTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMot
            // 
            this.textBoxMot.BackColor = System.Drawing.Color.PaleGreen;
            this.textBoxMot.Location = new System.Drawing.Point(976, 54);
            this.textBoxMot.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxMot.Name = "textBoxMot";
            this.textBoxMot.ReadOnly = true;
            this.textBoxMot.Size = new System.Drawing.Size(196, 31);
            this.textBoxMot.TabIndex = 6;
            this.textBoxMot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Пятнашки
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(1220, 681);
            this.Controls.Add(this.textBoxMot);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblMotion);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RepeatGameButton);
            this.Controls.Add(this.NewGameButton);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Пятнашки";
            this.Text = "Пятнашки";
            this.Load += new System.EventHandler(this.Пятнашки_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewGameButton;
        private System.Windows.Forms.Button RepeatGameButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblMotion;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.TextBox textBoxMot;
    }
}

