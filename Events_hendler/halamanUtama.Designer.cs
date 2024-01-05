namespace Events_hendler
{
    partial class halamanUtama
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rolePeserta = new System.Windows.Forms.TextBox();
            this.namaPeserta = new System.Windows.Forms.TextBox();
            this.izinBtn = new System.Windows.Forms.Button();
            this.hadirBtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.izinBtn2 = new System.Windows.Forms.Button();
            this.hadirBtn2 = new System.Windows.Forms.Button();
            this.roleEvent2 = new System.Windows.Forms.TextBox();
            this.pesertaEvent2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.pesertaEvent3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.calenderEvent = new System.Windows.Forms.MonthCalendar();
            this.timeEvent = new System.Windows.Forms.DateTimePicker();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.rolePeserta);
            this.panel1.Controls.Add(this.namaPeserta);
            this.panel1.Controls.Add(this.izinBtn);
            this.panel1.Controls.Add(this.hadirBtn);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(23, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 257);
            this.panel1.TabIndex = 0;
            // 
            // rolePeserta
            // 
            this.rolePeserta.Location = new System.Drawing.Point(119, 133);
            this.rolePeserta.Name = "rolePeserta";
            this.rolePeserta.Size = new System.Drawing.Size(205, 22);
            this.rolePeserta.TabIndex = 8;
            // 
            // namaPeserta
            // 
            this.namaPeserta.Location = new System.Drawing.Point(119, 100);
            this.namaPeserta.Name = "namaPeserta";
            this.namaPeserta.ReadOnly = true;
            this.namaPeserta.Size = new System.Drawing.Size(205, 22);
            this.namaPeserta.TabIndex = 7;
            this.namaPeserta.TextChanged += new System.EventHandler(this.namaPeserta_TextChanged);
            // 
            // izinBtn
            // 
            this.izinBtn.Location = new System.Drawing.Point(189, 177);
            this.izinBtn.Name = "izinBtn";
            this.izinBtn.Size = new System.Drawing.Size(135, 41);
            this.izinBtn.TabIndex = 6;
            this.izinBtn.Text = "Izin";
            this.izinBtn.UseVisualStyleBackColor = true;
            this.izinBtn.Click += new System.EventHandler(this.izinBtn_Click);
            // 
            // hadirBtn
            // 
            this.hadirBtn.Location = new System.Drawing.Point(29, 177);
            this.hadirBtn.Name = "hadirBtn";
            this.hadirBtn.Size = new System.Drawing.Size(135, 41);
            this.hadirBtn.TabIndex = 5;
            this.hadirBtn.Text = "Hadir";
            this.hadirBtn.UseVisualStyleBackColor = true;
            this.hadirBtn.Click += new System.EventHandler(this.hadirBtn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 16);
            this.label12.TabIndex = 4;
            this.label12.Text = "Sebagai :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Nama :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Peserta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Sedang Berlangsung";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Event 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Geometr415 Blk BT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dashboard";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.izinBtn2);
            this.panel2.Controls.Add(this.hadirBtn2);
            this.panel2.Controls.Add(this.roleEvent2);
            this.panel2.Controls.Add(this.pesertaEvent2);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(429, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 257);
            this.panel2.TabIndex = 2;
            // 
            // izinBtn2
            // 
            this.izinBtn2.Location = new System.Drawing.Point(203, 177);
            this.izinBtn2.Name = "izinBtn2";
            this.izinBtn2.Size = new System.Drawing.Size(135, 41);
            this.izinBtn2.TabIndex = 9;
            this.izinBtn2.Text = "Izin";
            this.izinBtn2.UseVisualStyleBackColor = true;
            this.izinBtn2.Click += new System.EventHandler(this.izinBtn2_Click);
            // 
            // hadirBtn2
            // 
            this.hadirBtn2.Location = new System.Drawing.Point(37, 177);
            this.hadirBtn2.Name = "hadirBtn2";
            this.hadirBtn2.Size = new System.Drawing.Size(135, 41);
            this.hadirBtn2.TabIndex = 9;
            this.hadirBtn2.Text = "Hadir";
            this.hadirBtn2.UseVisualStyleBackColor = true;
            this.hadirBtn2.Click += new System.EventHandler(this.hadirBtn2_Click);
            // 
            // roleEvent2
            // 
            this.roleEvent2.Location = new System.Drawing.Point(124, 134);
            this.roleEvent2.Name = "roleEvent2";
            this.roleEvent2.Size = new System.Drawing.Size(214, 22);
            this.roleEvent2.TabIndex = 11;
            // 
            // pesertaEvent2
            // 
            this.pesertaEvent2.Location = new System.Drawing.Point(124, 96);
            this.pesertaEvent2.Name = "pesertaEvent2";
            this.pesertaEvent2.Size = new System.Drawing.Size(214, 22);
            this.pesertaEvent2.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(34, 136);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 16);
            this.label15.TabIndex = 9;
            this.label15.Text = "Sebagai :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(34, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 16);
            this.label14.TabIndex = 9;
            this.label14.Text = "Peserta";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(35, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 16);
            this.label13.TabIndex = 9;
            this.label13.Text = "Nama :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(229, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Sedang Berlangsung";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Event 2";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.pesertaEvent3);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(842, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(377, 257);
            this.panel3.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(200, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 41);
            this.button2.TabIndex = 12;
            this.button2.Text = "Izin";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 41);
            this.button1.TabIndex = 12;
            this.button1.Text = "Hadir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(34, 139);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 16);
            this.label17.TabIndex = 12;
            this.label17.Text = "Sebagai :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 22);
            this.textBox1.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(34, 100);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 16);
            this.label16.TabIndex = 12;
            this.label16.Text = "Nama :";
            // 
            // pesertaEvent3
            // 
            this.pesertaEvent3.Location = new System.Drawing.Point(121, 98);
            this.pesertaEvent3.Name = "pesertaEvent3";
            this.pesertaEvent3.Size = new System.Drawing.Size(214, 22);
            this.pesertaEvent3.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(225, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Sedang Berlangsung";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Event 3";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(23, 384);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(377, 251);
            this.panel4.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(228, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Sedang Berlangsung";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Event 4";
            // 
            // calenderEvent
            // 
            this.calenderEvent.Location = new System.Drawing.Point(957, 428);
            this.calenderEvent.Name = "calenderEvent";
            this.calenderEvent.TabIndex = 5;
            this.calenderEvent.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calenderEvent_DateChanged);
            // 
            // timeEvent
            // 
            this.timeEvent.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeEvent.Location = new System.Drawing.Point(1019, 12);
            this.timeEvent.Name = "timeEvent";
            this.timeEvent.Size = new System.Drawing.Size(200, 22);
            this.timeEvent.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.label19);
            this.panel5.Location = new System.Drawing.Point(429, 384);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(377, 251);
            this.panel5.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(228, 19);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(134, 16);
            this.label18.TabIndex = 4;
            this.label18.Text = "Sedang Berlangsung";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(24, 21);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(99, 29);
            this.label19.TabIndex = 3;
            this.label19.Text = "Event 4";
            // 
            // halamanUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 668);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.timeEvent);
            this.Controls.Add(this.calenderEvent);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "halamanUtama";
            this.Text = "halamanUtama";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MonthCalendar calenderEvent;
        private System.Windows.Forms.DateTimePicker timeEvent;
        private System.Windows.Forms.TextBox rolePeserta;
        private System.Windows.Forms.TextBox namaPeserta;
        private System.Windows.Forms.Button izinBtn;
        private System.Windows.Forms.Button hadirBtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button izinBtn2;
        private System.Windows.Forms.Button hadirBtn2;
        private System.Windows.Forms.TextBox roleEvent2;
        private System.Windows.Forms.TextBox pesertaEvent2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox pesertaEvent3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
    }
}