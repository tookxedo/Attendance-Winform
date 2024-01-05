namespace Events_hendler
{
    partial class adminForm
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
            this.userBox = new System.Windows.Forms.GroupBox();
            this.eventDateAdd = new System.Windows.Forms.DateTimePicker();
            this.AddBtn = new System.Windows.Forms.Button();
            this.eventNameAdd = new System.Windows.Forms.TextBox();
            this.userName2 = new System.Windows.Forms.Label();
            this.userName1 = new System.Windows.Forms.Label();
            this.userCount = new System.Windows.Forms.Label();
            this.absenList = new System.Windows.Forms.ListBox();
            this.keteranganAbsen = new System.Windows.Forms.ListBox();
            this.event1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.eventList = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ShowEventsList = new System.Windows.Forms.Button();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.userBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // userBox
            // 
            this.userBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userBox.Controls.Add(this.eventDateAdd);
            this.userBox.Controls.Add(this.AddBtn);
            this.userBox.Controls.Add(this.eventNameAdd);
            this.userBox.Controls.Add(this.userName2);
            this.userBox.Controls.Add(this.userName1);
            this.userBox.Controls.Add(this.userCount);
            this.userBox.Location = new System.Drawing.Point(26, 116);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(281, 493);
            this.userBox.TabIndex = 0;
            this.userBox.TabStop = false;
            this.userBox.Text = "User";
            // 
            // eventDateAdd
            // 
            this.eventDateAdd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.eventDateAdd.Location = new System.Drawing.Point(26, 147);
            this.eventDateAdd.Name = "eventDateAdd";
            this.eventDateAdd.Size = new System.Drawing.Size(227, 22);
            this.eventDateAdd.TabIndex = 7;
            this.eventDateAdd.Visible = false;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(30, 206);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(218, 52);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // eventNameAdd
            // 
            this.eventNameAdd.Location = new System.Drawing.Point(26, 93);
            this.eventNameAdd.Name = "eventNameAdd";
            this.eventNameAdd.Size = new System.Drawing.Size(227, 22);
            this.eventNameAdd.TabIndex = 4;
            // 
            // userName2
            // 
            this.userName2.AutoSize = true;
            this.userName2.Location = new System.Drawing.Point(20, 153);
            this.userName2.Name = "userName2";
            this.userName2.Size = new System.Drawing.Size(0, 16);
            this.userName2.TabIndex = 2;
            // 
            // userName1
            // 
            this.userName1.AutoSize = true;
            this.userName1.Location = new System.Drawing.Point(20, 118);
            this.userName1.Name = "userName1";
            this.userName1.Size = new System.Drawing.Size(0, 16);
            this.userName1.TabIndex = 1;
            // 
            // userCount
            // 
            this.userCount.AutoSize = true;
            this.userCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userCount.Location = new System.Drawing.Point(88, 39);
            this.userCount.Name = "userCount";
            this.userCount.Size = new System.Drawing.Size(98, 36);
            this.userCount.TabIndex = 0;
            this.userCount.Text = "Users";
            this.userCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.userCount.Click += new System.EventHandler(this.userCount_Click);
            // 
            // absenList
            // 
            this.absenList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.absenList.FormattingEnabled = true;
            this.absenList.ItemHeight = 25;
            this.absenList.Location = new System.Drawing.Point(360, 117);
            this.absenList.Name = "absenList";
            this.absenList.Size = new System.Drawing.Size(286, 479);
            this.absenList.TabIndex = 1;
            // 
            // keteranganAbsen
            // 
            this.keteranganAbsen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keteranganAbsen.FormattingEnabled = true;
            this.keteranganAbsen.ItemHeight = 25;
            this.keteranganAbsen.Location = new System.Drawing.Point(676, 117);
            this.keteranganAbsen.Name = "keteranganAbsen";
            this.keteranganAbsen.Size = new System.Drawing.Size(286, 479);
            this.keteranganAbsen.TabIndex = 2;
            // 
            // event1
            // 
            this.event1.Location = new System.Drawing.Point(26, 28);
            this.event1.Name = "event1";
            this.event1.Size = new System.Drawing.Size(217, 45);
            this.event1.TabIndex = 3;
            this.event1.Text = "Event 1";
            this.event1.UseVisualStyleBackColor = true;
            this.event1.Click += new System.EventHandler(this.event1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1003, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 55);
            this.button1.TabIndex = 8;
            this.button1.Text = "Lihat Alasan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // eventList
            // 
            this.eventList.FormattingEnabled = true;
            this.eventList.ItemHeight = 16;
            this.eventList.Location = new System.Drawing.Point(983, 117);
            this.eventList.Name = "eventList";
            this.eventList.Size = new System.Drawing.Size(215, 308);
            this.eventList.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(287, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 45);
            this.button2.TabIndex = 10;
            this.button2.Text = "Tambah Event";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ShowEventsList
            // 
            this.ShowEventsList.Location = new System.Drawing.Point(1003, 447);
            this.ShowEventsList.Name = "ShowEventsList";
            this.ShowEventsList.Size = new System.Drawing.Size(179, 53);
            this.ShowEventsList.TabIndex = 11;
            this.ShowEventsList.Text = "Lihat Events";
            this.ShowEventsList.UseVisualStyleBackColor = true;
            this.ShowEventsList.Click += new System.EventHandler(this.ShowEventsList_Click);
            // 
            // dateTime
            // 
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime.Location = new System.Drawing.Point(982, 28);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(200, 22);
            this.dateTime.TabIndex = 12;
            this.dateTime.Value = new System.DateTime(2024, 1, 5, 0, 0, 0, 0);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(525, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 45);
            this.button3.TabIndex = 13;
            this.button3.Text = "Hapus Event";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 669);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.ShowEventsList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.eventList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.event1);
            this.Controls.Add(this.keteranganAbsen);
            this.Controls.Add(this.absenList);
            this.Controls.Add(this.userBox);
            this.Name = "adminForm";
            this.Text = "adminForm";
            this.userBox.ResumeLayout(false);
            this.userBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox userBox;
        private System.Windows.Forms.Label userCount;
        private System.Windows.Forms.Label userName2;
        private System.Windows.Forms.Label userName1;
        private System.Windows.Forms.ListBox absenList;
        private System.Windows.Forms.ListBox keteranganAbsen;
        private System.Windows.Forms.Button event1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox eventList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox eventNameAdd;
        private System.Windows.Forms.DateTimePicker eventDateAdd;
        private System.Windows.Forms.Button ShowEventsList;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Button button3;
    }
}