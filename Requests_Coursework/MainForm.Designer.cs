namespace Requests_Coursework
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddRequest_button = new System.Windows.Forms.Button();
            this.unsortedRequests_textBox = new System.Windows.Forms.TextBox();
            this.sortedRequests_textBox = new System.Windows.Forms.TextBox();
            this.startEmulator_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.endTime_textBox = new System.Windows.Forms.TextBox();
            this.startTime_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddCustomRequest_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stop_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(86, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Поданные заявки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(422, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Отобранные заявки";
            // 
            // AddRequest_button
            // 
            this.AddRequest_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddRequest_button.Location = new System.Drawing.Point(431, 85);
            this.AddRequest_button.Name = "AddRequest_button";
            this.AddRequest_button.Size = new System.Drawing.Size(188, 47);
            this.AddRequest_button.TabIndex = 6;
            this.AddRequest_button.Text = "Добавить рандомную заявку";
            this.AddRequest_button.UseVisualStyleBackColor = true;
            this.AddRequest_button.Click += new System.EventHandler(this.AddRequest_button_Click);
            // 
            // unsortedRequests_textBox
            // 
            this.unsortedRequests_textBox.BackColor = System.Drawing.Color.White;
            this.unsortedRequests_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unsortedRequests_textBox.Location = new System.Drawing.Point(27, 36);
            this.unsortedRequests_textBox.Multiline = true;
            this.unsortedRequests_textBox.Name = "unsortedRequests_textBox";
            this.unsortedRequests_textBox.ReadOnly = true;
            this.unsortedRequests_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.unsortedRequests_textBox.Size = new System.Drawing.Size(290, 415);
            this.unsortedRequests_textBox.TabIndex = 7;
            // 
            // sortedRequests_textBox
            // 
            this.sortedRequests_textBox.BackColor = System.Drawing.Color.White;
            this.sortedRequests_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortedRequests_textBox.Location = new System.Drawing.Point(382, 36);
            this.sortedRequests_textBox.Multiline = true;
            this.sortedRequests_textBox.Name = "sortedRequests_textBox";
            this.sortedRequests_textBox.ReadOnly = true;
            this.sortedRequests_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sortedRequests_textBox.Size = new System.Drawing.Size(283, 415);
            this.sortedRequests_textBox.TabIndex = 8;
            // 
            // startEmulator_button
            // 
            this.startEmulator_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startEmulator_button.Location = new System.Drawing.Point(387, 15);
            this.startEmulator_button.Name = "startEmulator_button";
            this.startEmulator_button.Size = new System.Drawing.Size(188, 64);
            this.startEmulator_button.TabIndex = 9;
            this.startEmulator_button.Text = "Запустить эмулятор подачи заявок в реальном времени";
            this.startEmulator_button.UseVisualStyleBackColor = true;
            this.startEmulator_button.Click += new System.EventHandler(this.startEmulator_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Время начала";
            // 
            // endTime_textBox
            // 
            this.endTime_textBox.Location = new System.Drawing.Point(171, 104);
            this.endTime_textBox.Name = "endTime_textBox";
            this.endTime_textBox.Size = new System.Drawing.Size(140, 20);
            this.endTime_textBox.TabIndex = 13;
            // 
            // startTime_textBox
            // 
            this.startTime_textBox.Location = new System.Drawing.Point(32, 104);
            this.startTime_textBox.Name = "startTime_textBox";
            this.startTime_textBox.Size = new System.Drawing.Size(133, 20);
            this.startTime_textBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Время окончания";
            // 
            // AddCustomRequest_button
            // 
            this.AddCustomRequest_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCustomRequest_button.Location = new System.Drawing.Point(62, 15);
            this.AddCustomRequest_button.Name = "AddCustomRequest_button";
            this.AddCustomRequest_button.Size = new System.Drawing.Size(217, 64);
            this.AddCustomRequest_button.TabIndex = 10;
            this.AddCustomRequest_button.Text = "Добавить свою заявку (формат времени \"ЧЧ:ММ\")";
            this.AddCustomRequest_button.UseVisualStyleBackColor = true;
            this.AddCustomRequest_button.Click += new System.EventHandler(this.AddCustomRequest_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SpringGreen;
            this.panel1.Controls.Add(this.stop_button);
            this.panel1.Controls.Add(this.AddCustomRequest_button);
            this.panel1.Controls.Add(this.startEmulator_button);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.AddRequest_button);
            this.panel1.Controls.Add(this.endTime_textBox);
            this.panel1.Controls.Add(this.startTime_textBox);
            this.panel1.Location = new System.Drawing.Point(-5, 467);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 163);
            this.panel1.TabIndex = 15;
            // 
            // stop_button
            // 
            this.stop_button.Location = new System.Drawing.Point(582, 15);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(88, 64);
            this.stop_button.TabIndex = 15;
            this.stop_button.Text = "Стоп";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(692, 614);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sortedRequests_textBox);
            this.Controls.Add(this.unsortedRequests_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Программа по отбору заявок";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddRequest_button;
        private System.Windows.Forms.TextBox unsortedRequests_textBox;
        private System.Windows.Forms.TextBox sortedRequests_textBox;
        private System.Windows.Forms.Button startEmulator_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox endTime_textBox;
        private System.Windows.Forms.TextBox startTime_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddCustomRequest_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button stop_button;
    }
}